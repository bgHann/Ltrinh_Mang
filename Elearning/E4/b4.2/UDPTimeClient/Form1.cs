using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPTimeClient
{
    public partial class Form1 : Form
    {
		Socket clientSocket;
		EndPoint serverEP;

		public Form1()
        {
            InitializeComponent();
        }
		private void Form1_Load(object sender, EventArgs e)
		{
			cboRequest.SelectedIndex = 0; // chọn TIME mặc định
		}

		private void btnGui_Click(object sender, EventArgs e)
        {
			try
			{
				// Tạo socket UDP client
				clientSocket = new Socket(
					AddressFamily.InterNetwork,
					SocketType.Dgram,
					ProtocolType.Udp
				);

				// Địa chỉ server
				serverEP = new IPEndPoint(
					IPAddress.Parse(txtIP.Text),
					(int)numPort.Value
				);

				// Lấy yêu cầu từ ComboBox
				string request = cboRequest.SelectedItem.ToString();

				// Gửi yêu cầu
				byte[] sendData = Encoding.UTF8.GetBytes(request);
				clientSocket.SendTo(sendData, serverEP);

				// Nhận phản hồi
				byte[] buffer = new byte[1024];
				EndPoint tempEP = new IPEndPoint(IPAddress.Any, 0);
				int received = clientSocket.ReceiveFrom(buffer, ref tempEP);

				string response = Encoding.UTF8.GetString(buffer, 0, received);

				// Hiển thị kết quả
				MessageBox.Show(response, "Kết quả từ Server");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			try
			{
				clientSocket?.Close();
			}
			catch { }

			this.Close();
		
	}
    }
}
