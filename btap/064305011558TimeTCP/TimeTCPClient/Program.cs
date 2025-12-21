using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

       

        // 2. Tạo socket client
        Socket client = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);

        // 3. Kết nối server
        try
        {
            client.Connect(new IPEndPoint(IPAddress.Loopback, 8888));
            Console.WriteLine(">>> KẾT NỐI SERVER THÀNH CÔNG!");
        }
        catch
        {
            Console.WriteLine(">>> KHÔNG KẾT NỐI ĐƯỢC SERVER!");
            return;
        }
        while (true)
        {
            // 4. Chọn yêu cầu
            Console.WriteLine("1 - Time");
            Console.WriteLine("2 - Date");
            Console.WriteLine("3 - Date & Time");
            Console.Write("Chọn: ");
            string request = Console.ReadLine();

            // 5. Gửi yêu cầu
            client.Send(Encoding.UTF8.GetBytes(request));
            Console.WriteLine("Đã gửi yêu cầu lên server");

            // 6. Nhận kết quả
            byte[] buffer = new byte[1024];
            int len = client.Receive(buffer);
            string response = Encoding.UTF8.GetString(buffer, 0, len);

            Console.WriteLine("Server trả về: " + response);

            Console.WriteLine("Dừng chương trình nhấn N \n" +
                "Tiếp tục Enter");
            string tiep = Console.ReadLine();
            if (tiep == "n" || tiep == "N")
            {
                client.Close();
                Console.WriteLine("Đã ngắt kết nối");
                Console.ReadLine();
                break;
            }
			// 7. Đóng kết nối
			//client.Close();
   //         Console.WriteLine("Đã ngắt kết nối");

            
        }
    }
}
