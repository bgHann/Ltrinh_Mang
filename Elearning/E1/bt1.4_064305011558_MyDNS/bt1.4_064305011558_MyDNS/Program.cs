using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; 

namespace bt1._4_064305011558_MyDNS
{
    internal class Program
    {
        static void Main(string[] args)

        {
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;
			Console.Title = "064305011558 - Bùi Gia Hân";
			string domain; // biến lưu tên truy vấn
			/// ===== KIỂM TRA THAM SỐ DÒNG LỆNH =====
			// Nếu khi chạy chương trình có truyền tham số
			// ví dụ: MyDNS.exe google.com

			if (args.Length > 0)
			{
				domain = args[0]; // Lấy tên miền từ dòng lệnh
			}
			else
			{
				// Nếu KHÔNG có tham số → nhập từ bàn phím
				Console.Write("Nhập tên miền: ");
				domain = Console.ReadLine();
			}

			// truy vấn DNS
			try
			{
				// Gửi yêu cầu DNS để lấy thông tin tên miền
				IPHostEntry entry = Dns.GetHostEntry(domain);
				// in ra màn hình truy vans
				Console.WriteLine("Host name : " + entry.HostName);
				Console.WriteLine("Danh sách địa chỉ IP : ");
				foreach (IPAddress ip in entry.AddressList)
				{
					Console.WriteLine("- " + ip.ToString());
				}
			}
			catch (Exception ex)//  // Nếu có lỗi (nhập sai tên miền, mất mạng...)
			{
				Console.WriteLine("Lỗi truy vấn DNS: " + ex.Message);
			}

			Console.ReadLine();
		}
    }
}
