using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sever_TCP
{
    internal class Program
    {
        private static int port =8888;
        static int UCLN(int a ,int b)
        {
                       while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;

		}
		static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
			Console.WriteLine("TCP_SERVER");
           
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // bind ip and port
                server.Bind(new IPEndPoint(IPAddress.Any, port));
                // lắng nghe kết nối từ client
                server.Listen(5);
                Console.WriteLine("Server dang chạy...");
            // chấp nhận kết nối từ client
        
			while (true)
			{
				Console.WriteLine("Đang chờ client " );
				Socket client = server.Accept();

			
				Console.WriteLine("Client đã kết nối!");
				
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    // nhận dữ liệu từ cilent
                    int len = client.Receive(buffer);
                    if (len == 0)
                    {

                        Console.WriteLine("Client đã ngắt kết nối");
                        break;
                    }
                    // chuyển dữ liệu từ byte[] sang string
                    string request = Encoding.UTF8.GetString(buffer, 0, len);

                    Console.WriteLine("Client: " + request);
                    if (request == "exit")
                    {
                        Console.WriteLine("Client đã thoát");
                        client.Close();
                        break;

                    }
                    // xử lí bài toán 
                    string[] parts = request.Split(' ');
                    int a = int.Parse(parts[0]);
                    int b = int.Parse(parts[1]);

                    int kq = UCLN(a, b);
                    string response = " UCLN = " + kq;
                    // trả kq ve cho client
                    client.Send(Encoding.UTF8.GetBytes(response));


                }
                client.Close();
                //server.Close();
            }
		}
	}
}
