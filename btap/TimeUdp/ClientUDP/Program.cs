using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientUDP
{
    internal class Program
    {
        private static int port = 9000;
       

        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("============UDP CLIENT============");
            //tạo socket
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //GỬI TỚI SERVER
            IPEndPoint server = new IPEndPoint(IPAddress.Loopback, port);
            client.SendTo(Encoding.UTF8.GetBytes("YÊU CẦU THỜI GIAN"), server);
            //nhận yêu cầu từ user
            
            Console.Write("Nhập yêu cầu (1: ngày ngắn, 2:ngày dài, 3:giờ phút giây): ");
            string request = Console.ReadLine();
			// 5. Gửi yêu cầu
			client.Send(Encoding.UTF8.GetBytes(request));
			Console.WriteLine("Đã gửi yêu cầu lên server");

			// 6. Nhận kết quả
			byte[] data = new byte[1024];
			int len = client.Receive(data);
			string response = Encoding.UTF8.GetString(data, 0, len);

			Console.WriteLine("Server trả về: " + response);
			client.Close();
			Console.WriteLine("Đã ngắt kết nối");
			Console.ReadLine();



		}
	}
}
