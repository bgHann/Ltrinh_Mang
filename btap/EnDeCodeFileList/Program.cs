using System;

namespace EnDeCodeFileList
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"D:\buigiahan";   // THƯ MỤC NÀY

			string s = EnDeCodeDirInfo.encode(path);
			Console.WriteLine("Chuỗi mã hoá:");
			Console.WriteLine(s);

			Console.WriteLine("--------------");

			Console.WriteLine(EnDeCodeDirInfo.decode(s));

			Console.ReadLine();
		}

	}
}
