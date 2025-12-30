using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_TCP
{
    internal class Program
    {
        private static int port =8888;

        static void Main(string[] args)

        { 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("TCP_CLIENT");
			// tajosk socket
			Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // kết nối  
            client.Connect(new IPEndPoint(IPAddress.Loopback, port));
            Console.WriteLine("đã kết nối đến server");
            while (true)
            {
                //nhập dữ liệu
                Console.Write("[Nhấn exit để dừng chuong trình] \n" +
                    "Nhập 2 số a và b: ");
                string request = Console.ReadLine();
				//gửi dữ liệu đến server
                client.Send(Encoding.UTF8.GetBytes(request));
                // nhận kq từ server
                byte[] buffer = new byte[1024];
                int len = client.Receive(buffer);
                string response = Encoding.UTF8.GetString(buffer, 0, len);
                Console.WriteLine("Server: " + response);
                if (request == "exit") 
                    break;
                
                
			}
			// đóg kn
			Console.WriteLine("ngắt kết nối tới sever");
			client.Close();
          
		}
    }
}
