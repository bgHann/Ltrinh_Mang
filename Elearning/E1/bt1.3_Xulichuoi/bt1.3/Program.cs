using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1._3
{
    internal class Program
    {
        //hàm chuyển chữ thường thành hoa
        static void chuhoa(string text)
        {
            Console.WriteLine("1.Chuỗi sau khi đổi tất cả các ký tự trong chuỗi thành chữ hoa: " + text.ToUpper());
        }
        //2.chèn mã sinnh viên cuối chuỗi
        static void chenchuoi(string text)
        {
            string mssv = "064305011558";
            Console.WriteLine("2.Chuỗi mới + mssv: "+ text + mssv);
        }
        //đếm số từ
        static void dem(string text)
        {
            Console.WriteLine("3.Đếm số từ có trong chuỗi: " + text.Length);
        }
        // xuất từ dài nhất
        static void tudainhat(string text)
        {
            string[] tachchuoi = text.Split(' ');
            int max = tachchuoi[0].Length;
            string tudainhat = tachchuoi[0];
            for (int i= 0; i< tachchuoi.Length; i++)
            {

                if (tachchuoi[i].Length > max)
                {
                    max = tachchuoi[i].Length;
                    tudainhat = tachchuoi[i];

                }
                 
            }
            Console.WriteLine("4.Xuất ra màn hình từ dài nhất trong chuỗi: " + tudainhat);
        }
        //sắp xếp lại theo thứ tự abc
        static void sapxep(string str)
        {
            //xóa khoảng trắng
            str = str.Replace(" ", "");
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string kq = new string(arr);
            Console.WriteLine("5.Sắp xếp các từ trong chuỗi theo thứ tự ABC và ghép thành một chuỗi mới : "+ kq);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bùi Gia Hân 064305011558 \n" +
                "=========================================");
            Console.WriteLine("Nhập một chuỗi từ bàn phím");
            string a = Console.ReadLine();
            chuhoa(a);
            chenchuoi(a);
            dem(a);
            tudainhat(a);
            sapxep(a);
            
        }
    }
}
