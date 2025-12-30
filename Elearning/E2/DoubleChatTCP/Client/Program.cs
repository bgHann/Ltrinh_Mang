using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DoubleChatTCP_Client
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== CLIENT CHAT TCP ===");

            Socket client = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            client.Connect(new IPEndPoint(IPAddress.Loopback, 9999));
            Console.WriteLine("Đã kết nối tới Server!");

            Thread receiveThread = new Thread(() =>
            {
                byte[] buffer = new byte[1024];
                try
                {
                    while (true)
                    {
                        int len = client.Receive(buffer);
                        if (len == 0) break;

                        string msg = Encoding.UTF8.GetString(buffer, 0, len);
                        Console.WriteLine("\nTin nhắn từ đối phương: " + msg);
                    }
                }
                catch { }
            });

            receiveThread.Start();

            while (true)
            {
                Console.Write("Bạn: ");
                string msg = Console.ReadLine();
                client.Send(Encoding.UTF8.GetBytes(msg));
            }
        }
    }
}
