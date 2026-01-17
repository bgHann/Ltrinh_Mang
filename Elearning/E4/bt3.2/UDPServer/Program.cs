using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class UDPServer
{
	static void Main()
	{
		int port = 22333;
		UdpClient server = null;

		try
		{
			server = new UdpClient(port);
			Console.WriteLine($"[Server] Đang lắng nghe trên cổng {port}...");

			IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

			while (true)
			{
				// Nhận dữ liệu từ client
				byte[] data = server.Receive(ref clientEP);
				string path = Encoding.UTF8.GetString(data).Trim();
				Console.WriteLine($"[Server] Nhận đường dẫn từ client: {path}");

				string response;

				if (Directory.Exists(path))
				{
					var folders = Directory.GetDirectories(path);
					var files = Directory.GetFiles(path);

					StringBuilder sb = new StringBuilder();
					sb.AppendLine("Folders:");
					foreach (var folder in folders)
						sb.AppendLine(Path.GetFileName(folder).ToUpper());

					sb.AppendLine("Files:");
					foreach (var file in files)
						sb.AppendLine(Path.GetFileName(file).ToLower());

					response = sb.ToString();
				}
				else
				{
					response = "Đường dẫn không hợp lệ";
				}

				// Gửi dữ liệu trả về client
				byte[] sendBytes = Encoding.UTF8.GetBytes(response);
				server.Send(sendBytes, sendBytes.Length, clientEP);
				Console.WriteLine("[Server] Đã gửi phản hồi về client.\n");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("[Server] Lỗi: " + ex.Message);
		}
		finally
		{
			if (server != null)
				server.Close();
		}
	}
}
