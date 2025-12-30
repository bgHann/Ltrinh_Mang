using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerTCP
{
    internal class Program
    {
        private static int port = 9999;
        static TcpClient client1;
        static TcpClient client2;
		static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("SERVER TCP");
            // TẠO SOCKET
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // bind
            server.Bind(new IPEndPoint(IPAddress.Any, port));
            // lawsg nghe
            server.Listen(2);

            // chờ client 1
            Console.WriteLine("Dang cho client 1 ket noi...");
            Socket client1 = server.Accept();
            Console.WriteLine("Client 1 đã kết nối");
            //client 2
            Console.WriteLine("Đang chờ client 2 kết nối...");
            Socket client2 = server.Accept();
            Console.WriteLine("Client 2 kết nối thành công...");

			Thread t1 = new Thread(() => Relay(client1, client2, "Client 1"));
			Thread t2 = new Thread(() => Relay(client2, client1, "Client 2"));

			t1.Start();
			t2.Start();

		}

		static void Relay(Socket from, Socket to, string name)
		{
			byte[] buffer = new byte[1024];
			try
			{
				while (true)
				{
					int len = from.Receive(buffer);
					if (len == 0) break;

					string msg = Encoding.UTF8.GetString(buffer, 0, len);
					Console.WriteLine($"{name}: {msg}");

					to.Send(Encoding.UTF8.GetBytes(msg));
				}
			}
			catch
			{
				Console.WriteLine($"{name} đã ngắt kết nối");
			}
		}
	}
}

