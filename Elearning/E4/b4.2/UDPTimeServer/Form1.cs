using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPTimeServer
{
    public partial class Form1 : Form
    {
		Socket serverSocket;
		Thread listenThread;
		bool isRunning = false;
		public Form1()
        {
            InitializeComponent();
        }

        private void btnChay_Click(object sender, EventArgs e)
        {
			int port = (int)numPort.Value;

            serverSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Dgram,
                ProtocolType.Udp
                );

			serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
			isRunning = true;

			listenThread = new Thread(ListenClient);
			listenThread.IsBackground = true;
			listenThread.Start();

			btnChay.Enabled = false;
			btnDung.Enabled = true;
			numPort.Enabled = false;

			this.Text = $"UDP Time Server - Port {port}";
		}

        private void btnDung_Click(object sender, EventArgs e)
        {
			isRunning = false;

			try
			{
				serverSocket.Close();
				listenThread.Abort();
			}
			catch { }

			btnChay.Enabled = true;
			btnDung.Enabled = false;
			numPort.Enabled = true;

			this.Text = "UDP Time Server";
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			byte[] buffer = new byte[1024];
			EndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

			while (isRunning)
			{
				try
				{
					int received = serverSocket.ReceiveFrom(buffer, ref clientEP);
					string request = Encoding.UTF8.GetString(buffer, 0, received);

					string response = HandleRequest(request);

					byte[] sendData = Encoding.UTF8.GetBytes(response);
					serverSocket.SendTo(sendData, clientEP);
				}
				catch
				{
					break;
				}
			}
		}
		void ListenClient()
		{
			byte[] buffer = new byte[1024];
			EndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

			while (isRunning)
			{
				try
				{
					int received = serverSocket.ReceiveFrom(buffer, ref clientEP);
					string request = Encoding.UTF8.GetString(buffer, 0, received);

					string response = HandleRequest(request);

					byte[] sendData = Encoding.UTF8.GetBytes(response);
					serverSocket.SendTo(sendData, clientEP);
				}
				catch
				{
					break;
				}
			}
		}

		string HandleRequest(string req)
		{
			DateTime now = DateTime.Now;

			switch (req)
			{
				case "TIME":
					return now.ToString("HH:mm:ss");
				case "DATE":
					return now.ToString("dd/MM/yyyy");
				case "DATETIME":
					return now.ToString("dd/MM/yyyy HH:mm:ss");
				default:
					return "Invalid request";
			}
		}
			private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
	}

