using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPFileServer
{
    public partial class Form1 : Form
    {
		TcpListener listener;

		public Form1()
        {
            InitializeComponent();
        }

		private async void btnStart_Click(object sender, EventArgs e)
		{
			listener = new TcpListener(IPAddress.Any, 9000);
			listener.Start();
			lblStatus.Text = "Server đang chờ client...";

			TcpClient client = await listener.AcceptTcpClientAsync();
			lblStatus.Text = "Client đã kết nối";

			await ReceiveFile(client);
		}

		private async Task ReceiveFile(TcpClient client)
		{
			NetworkStream stream = client.GetStream();

			// Nhận độ dài tên file
			byte[] nameLenBytes = new byte[4];
			await stream.ReadAsync(nameLenBytes, 0, 4);
			int nameLen = BitConverter.ToInt32(nameLenBytes, 0);

			// Nhận tên file
			byte[] nameBytes = new byte[nameLen];
			await stream.ReadAsync(nameBytes, 0, nameLen);
			string fileName = Encoding.UTF8.GetString(nameBytes);

			// Nhận kích thước file
			byte[] sizeBytes = new byte[8];
			await stream.ReadAsync(sizeBytes, 0, 8);
			long fileSize = BitConverter.ToInt64(sizeBytes, 0);

			SaveFileDialog save = new SaveFileDialog();
			save.FileName = fileName;

			if (save.ShowDialog() != DialogResult.OK) return;

			progressBar1.Value = 0;
			progressBar1.Maximum = 100;

			using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
			{
				byte[] buffer = new byte[8192];
				long received = 0;

				while (received < fileSize)
				{
					int read = await stream.ReadAsync(buffer, 0, buffer.Length);
					if (read == 0) break;

					fs.Write(buffer, 0, read);
					received += read;

					progressBar1.Value = (int)(received * 100 / fileSize);
				}
			}

			lblStatus.Text = "Nhận file hoàn tất";
			client.Close();
		}


	}
}
