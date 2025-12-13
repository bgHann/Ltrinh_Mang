using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuliString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.UTF8;
            //string someText = "Daniel is teaching about strings";
            //Console.WriteLine(someText.ToLower());
            //Console.WriteLine(someText.ToUpper());
            //Console.WriteLine(someText.Trim());
            //Console.WriteLine(someText.IndexOf("about"));
            //Console.WriteLine(someText.Replace("Dainel","hana"));
            string s = Console.ReadLine();
            //bui   gia hân
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i]== ' ' && s[i+1]== ' ')
                {
                    s = s.Remove(i, 1);
                    i--;
                }
            }
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            arr[0] = char.ToUpper(arr[0]);
            for (int i =0; i< arr.Length-1; i++)
            {
                if (arr[i]== ' ')
                {
                    arr[i + 1] = char.ToUpper(arr[i + 1]);
                }
            }
            s = new string(arr);

            Console.WriteLine(s);
		}
    }
}
