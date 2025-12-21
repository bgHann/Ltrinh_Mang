using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TimeTCPServer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("======= Time TCP Server =======");

			// 1. Tạo socket server
			Socket server = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Stream,
				ProtocolType.Tcp);

			// 2. Bind IP + Port
			server.Bind(new IPEndPoint(IPAddress.Any, 8888));

			// 3. Lắng nghe
			server.Listen(5);
			Console.WriteLine(">>> SERVER ĐANG CHẠY, ĐỢI CLIENT <<<");

			// 4. Chấp nhận client
			Socket client = server.Accept();
			Console.WriteLine(">>> CLIENT ĐÃ KẾT NỐI");

			while (true)
			{
				byte[] buffer = new byte[1024];

				// 5. Nhận dữ liệu
				int len = client.Receive(buffer);

				// Client đã đóng kết nối
				if (len == 0)
				{
					Console.WriteLine("Client đã ngắt kết nối");
					break;
				}

				string request = Encoding.UTF8.GetString(buffer, 0, len);
				Console.WriteLine("Nhận từ client: " + request);

				// Client yêu cầu thoát
				if (request == "n" || request == "N")
				{
					client.Send(Encoding.UTF8.GetBytes("Server đã đóng kết nối"));
					client.Close();
					Console.WriteLine("Đã đóng socket client");
					break;
				}

				// 6. Xử lý yêu cầu
				string response;
				if (request == "1")
					response = DateTime.Now.ToString("HH:mm:ss");
				else if (request == "2")
					response = DateTime.Now.ToString("dd/MM/yyyy");
				else if (request == "3")
					response = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
				else
					response = "Sai yêu cầu";

				// 7. Gửi lại client
				client.Send(Encoding.UTF8.GetBytes(response));
				Console.WriteLine("Đã gửi dữ liệu cho client");
			}

			// 8. Đóng server
			server.Close();
			Console.WriteLine("Server đã tắt");
			Console.ReadLine();
		}
	}
}
