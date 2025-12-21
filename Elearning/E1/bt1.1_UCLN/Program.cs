namespace e1_1;
using System;

class Program
{
	static void Main()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.WriteLine("Bùi Gia Hân - 064305011558 - e1.1");
		while (true) {
			

			Console.Write("Nhập số a: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("Nhập số b: ");
		int b = int.Parse(Console.ReadLine());

		int uscln = TinhUSCLN(a, b);
		Console.WriteLine($"USCLN({a},{b}) = {uscln}");
        Console.WriteLine("Nhấn N nếu muốn kết thúc\n" +
			"Tiếp tục Enter");
			string tiep = Console.ReadLine();
			if (tiep == "n" || tiep == "N")

			{
				Console.WriteLine("kết thúc chương trình");
				break;
			}
	}
	}

	static int TinhUSCLN(int a, int b)
	{
		while (a != b)
		{
			if (a > b)
				a = a - b;
			else
				b = b - a;
		}
		return a;
	}
}
