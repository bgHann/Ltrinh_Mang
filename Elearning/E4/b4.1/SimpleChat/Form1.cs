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

namespace SimpleChat
{
    public partial class Form1 : Form
    {
		// ===== SERVER =====
		Socket serverSocket;
		Socket clientSocket; // socket nhận client
		Thread serverThread;//luồng nhận dữ liẹu

		// ===== CLIENT =====
		Socket client;
		Thread clientThread;
		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
			int port = (int)numServerPort.Value;

			serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);

			serverSocket.Bind(ep);
			serverSocket.Listen(10);

			rtbServer.AppendText("Server started...\n");

			serverThread = new Thread(AcceptClient);
			serverThread.IsBackground = true;
			serverThread.Start();
		}
		void AcceptClient()
		{
			clientSocket = serverSocket.Accept();
			Invoke(new Action(() =>
			{
				rtbServer.AppendText("Client connected!\n");
			}));

			Thread receiveThread = new Thread(ReceiveFromClient);
			receiveThread.IsBackground = true;
			receiveThread.Start();
		}
		void ReceiveFromClient()
		{
			try
			{
				byte[] buffer = new byte[1024];

				while (true)
				{
					int bytes = clientSocket.Receive(buffer);
					string msg = Encoding.UTF8.GetString(buffer, 0, bytes);

					Invoke(new Action(() =>
					{
						rtbServer.AppendText("[Client]: " + msg + "\n");
					}));
				}
			}
			catch
			{
				Invoke(new Action(() =>
				{
					rtbServer.AppendText("Client disconnected.\n");
				}));
			}
		}

        private void btnServerSend_Click(object sender, EventArgs e)
        {
			if (clientSocket != null && clientSocket.Connected)
			{
				string msg = txtServerSend.Text;
				byte[] data = Encoding.UTF8.GetBytes(msg);
				clientSocket.Send(data);

				rtbServer.AppendText("[Server]: " + msg + "\n");
				txtServerSend.Clear();
			}
		}

        private void btnStop_Click(object sender, EventArgs e)
        {
			try
			{
				serverSocket.Close();
				clientSocket.Close();
				serverThread.Abort();
				rtbServer.AppendText("Server stopped.\n");
			}
			catch { }
		}
		///client
        private void btnConnect_Click(object sender, EventArgs e)
        {
			string ip = txtIP.Text;
			int port = (int)numClientPort.Value;

			client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			client.Connect(new IPEndPoint(IPAddress.Parse(ip), port));

			rtbClient.AppendText("Connected to server.\n");

			clientThread = new Thread(ReceiveFromServer);
			clientThread.IsBackground = true;
			clientThread.Start();
		}

		void ReceiveFromServer()
		{
			try
			{
				byte[] buffer = new byte[1024];

				while (true)
				{
					int bytes = client.Receive(buffer);
					string msg = Encoding.UTF8.GetString(buffer, 0, bytes);

					Invoke(new Action(() =>
					{
						rtbClient.AppendText("[Server]: " + msg + "\n");
					}));
				}
			}
			catch
			{
				Invoke(new Action(() =>
				{
					rtbClient.AppendText("Disconnected from server.\n");
				}));
			}
		}

        private void btnClientSend_Click(object sender, EventArgs e)
        {
			if (client != null && client.Connected)
			{
				string msg = txtClientSend.Text;
				byte[] data = Encoding.UTF8.GetBytes(msg);
				client.Send(data);

				rtbClient.AppendText("[Client]: " + msg + "\n");
				txtClientSend.Clear();
			}
		}

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
			try
			{
				client.Close();
				clientThread.Abort();
				rtbClient.AppendText("Disconnected.\n");
			}
			catch { }
		}

        private void btnLoadServer_Click(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Text file (*.txt)|*.txt";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				rtbServer.Text = System.IO.File.ReadAllText(ofd.FileName);
			}
		}

        private void btnSaveServer_Click(object sender, EventArgs e)
        {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Text file (*.txt)|*.txt";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(sfd.FileName, rtbServer.Text);
				MessageBox.Show("Saved successfully!");
			}
		}

        private void button5abtnClearServer_Click(object sender, EventArgs e)
        {
			rtbServer.Clear();
		}

        private void btnExitServer_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}

        private void btnLoadClient_Click(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Text file (*.txt)|*.txt";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				rtbClient.Text = System.IO.File.ReadAllText(ofd.FileName);
			}
		}

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Text file (*.txt)|*.txt";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(sfd.FileName, rtbClient.Text);
				MessageBox.Show("Saved successfully!");
			}
		}

        private void btnExitClient_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}

        private void btnClearClient_Click(object sender, EventArgs e)
        {
			rtbClient.Clear();
		}
    }
}
