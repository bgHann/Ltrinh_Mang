using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPFileClient
{
    public partial class Form1 : Form
    {
		string filePath;
		public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Nút chọn file đã chạy");

			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Chọn file gửi";
			open.Filter = "All files (*.*)|*.*";

			if (open.ShowDialog() == DialogResult.OK)
			{
				filePath = open.FileName;
				lblFile.Text = filePath;
			}
		}

		private async void btnSend_Click(object sender, EventArgs e)
		{
			TcpClient client = new TcpClient();
			await client.ConnectAsync("127.0.0.1", 9000);

			NetworkStream stream = client.GetStream();
			FileInfo info = new FileInfo(filePath);

			byte[] nameBytes = Encoding.UTF8.GetBytes(info.Name);
			byte[] nameLen = BitConverter.GetBytes(nameBytes.Length);
			byte[] sizeBytes = BitConverter.GetBytes(info.Length);

			await stream.WriteAsync(nameLen, 0, 4);
			await stream.WriteAsync(nameBytes, 0, nameBytes.Length);
			await stream.WriteAsync(sizeBytes, 0, 8);

			progressBar1.Value = 0;
			progressBar1.Maximum = 100;

			using (FileStream fs = new FileStream(filePath, FileMode.Open))
			{
				byte[] buffer = new byte[8192];
				long sent = 0;

				while (sent < info.Length)
				{
					int read = await fs.ReadAsync(buffer, 0, buffer.Length);
					await stream.WriteAsync(buffer, 0, read);
					sent += read;

					progressBar1.Value = (int)(sent * 100 / info.Length);
				}
			}

			client.Close();
			MessageBox.Show("Gửi file xong");
		}
	}
}
