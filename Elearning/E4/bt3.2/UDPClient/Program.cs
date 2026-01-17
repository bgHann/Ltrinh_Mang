using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class UDPClient
{
	static void Main()
	{
		try
		{
			UdpClient client = new UdpClient();

			Console.Write("Nhập đường dẫn cần truy xuất: ");
			string path = Console.ReadLine().Trim();

			byte[] sendBytes = Encoding.UTF8.GetBytes(path);
			IPEndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 22333);

			// Gửi dữ liệu đến server
			client.Send(sendBytes, sendBytes.Length, serverEP);
			Console.WriteLine("[Client] Đã gửi đường dẫn tới server.");

			// Nhận dữ liệu từ server
			byte[] receiveBytes = client.Receive(ref serverEP);
			string response = Encoding.UTF8.GetString(receiveBytes);

			Console.WriteLine("\n=== Kết quả từ server ===");
			Console.WriteLine(response);
		}
		catch (Exception ex)
		{
			Console.WriteLine("[Client] Lỗi: " + ex.Message);
		}
		finally
		{
			Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
			Console.ReadKey(); // <--- giữ cửa sổ Console mở
		}
	}
}
