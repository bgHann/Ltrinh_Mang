using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LAN_TCP_Server
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int port = 9999;
			Console.OutputEncoding = Encoding.UTF8;
			//tạo socket
			Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			// Lắng nghe tất cả IP trên máy
			server.Bind(new IPEndPoint(IPAddress.Any, port));
			// Chờ kết nối từ client
			server.Listen(5);

			Console.WriteLine("====TCP SERVER====");
			Console.WriteLine("Đang chờ kết nối từ Client...");

			Socket client = server.Accept(); // Chấp nhận client kết nối
			Console.WriteLine("Kết nối thành công với Client!");
			Console.WriteLine("LocalEndPoint (Server): " + client.LocalEndPoint);
			Console.WriteLine("RemoteEndPoint (Client): " + client.RemoteEndPoint);

			byte[] data = new byte[1024];
			int n;

			while (true)
			{
				Console.Write("Server: ");
				string msg = Console.ReadLine();
				client.Send(Encoding.UTF8.GetBytes(msg));

				n = client.Receive(data);
				msg = Encoding.UTF8.GetString(data, 0, n);
				Console.WriteLine("Client: " + msg);
			}
		}
	}
}
