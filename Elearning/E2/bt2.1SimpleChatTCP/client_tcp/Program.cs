using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LAN_TCP_Client
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int port = 9999;
			Console.OutputEncoding = Encoding.UTF8;

			Console.Write("Nhập IP Server: ");
			string serverIP = Console.ReadLine();  // Nhập 192.168.1.108
			// tạo socket
			Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			// kết nối tới server
			client.Connect(new IPEndPoint(IPAddress.Parse(serverIP), port));

			Console.WriteLine("====TCP CLIENT====");
			Console.WriteLine("Đã kết nối tới Server!");
			Console.WriteLine("LocalEndPoint (Client): " + client.LocalEndPoint);
			Console.WriteLine("RemoteEndPoint (Server): " + client.RemoteEndPoint);

			byte[] data = new byte[1024];
			int n;

			while (true)
			{
				n = client.Receive(data); //// Nhận tin nhắn từ Server
				string msg = Encoding.UTF8.GetString(data, 0, n);
				Console.WriteLine("Server: " + msg);

				Console.Write("Client: ");
				msg = Console.ReadLine();
				client.Send(Encoding.UTF8.GetBytes(msg));//// Gửi tới Server
			}
		}
	}
}
