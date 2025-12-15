using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TimeSever
{
    internal class Program

    {
        private static int port = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("========>>>SERVER TIME UDP<<<========");
            //TẠO SOCEKET
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            
                // gắn kêt nối sochet tới port
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
                server.Bind(ep);
                //nhận dữ liệu
                byte[] data = new byte[1024];
                int n;
            while (true) { 
                EndPoint client = new IPEndPoint(IPAddress.Any, 0);
                n = server.ReceiveFrom(data, ref client);
                Console.WriteLine("Nhận được yêu cầu từ client: " + Encoding.ASCII.GetString(data, 0, n));
                //Nhận yêu cầu xử lí
                n = server.ReceiveFrom(data, ref client);
                string request = Encoding.ASCII.GetString(data, 0, n);
                //xử lí yêu cầu
                string response = "";
                if (request == "1")
                    response = DateTime.Now.ToShortDateString();
                else if (request == "2")
                    response = DateTime.Now.ToLongDateString();
                else if (request == "3")
                    response = DateTime.Now.ToString();
                else
                    response = "Yêu cầu không hợp lệ";
                //guwti phải hồi
                server.SendTo(Encoding.ASCII.GetBytes(response), client);

            }

        }
    }
}
