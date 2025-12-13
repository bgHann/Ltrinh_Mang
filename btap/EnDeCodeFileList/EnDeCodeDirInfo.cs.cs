using System;
using System.Collections.Generic;
using System.IO;

namespace EnDeCodeFileList
{
	public class EnDeCodeDirInfo
	{
		// =====================================
		// HÀM MÃ HOÁ THƯ MỤC
		// =====================================
		public static string encode(string path)
		{
			string s = "$";

			DirectoryInfo dir = new DirectoryInfo(path);

			// Tổng số folder + file
			int total = dir.GetDirectories().Length + dir.GetFiles().Length;
			s += total;

			// Thêm các thư mục (0)
			foreach (DirectoryInfo d in dir.GetDirectories())
			{
				s += ";" + d.Name + ";0";
			}

			// Thêm các file (1)
			foreach (FileInfo f in dir.GetFiles())
			{
				s += ";" + f.Name + ";1";
			}

			// Ký tự kết thúc
			s += "#";

			return s;
		}

		// =====================================
		// HÀM GIẢI MÃ CHUỖI
		// =====================================
		public static string decode(string S)
		{
			// Kiểm tra chuỗi hợp lệ
			if (S[0] != '$' || S[S.Length - 1] != '#')
				return "Chuỗi không hợp lệ!";

			// Bỏ $ và #
			S = S.Substring(1, S.Length - 2);

			// Tách các thành phần
			string[] part = S.Split(';');

			int n = int.Parse(part[0]);

			List<string> folders = new List<string>();
			List<string> files = new List<string>();

			// Duyệt từng phần tử
			for (int i = 1; i <= n; i++)
			{
				string name = part[i * 2 - 1];
				string type = part[i * 2];

				if (type == "0")
					folders.Add(name);
				else if (type == "1")
					files.Add(name);
			}

			// Tạo chuỗi kết quả
			string result = "Danh sách thư mục:\n";
			foreach (string f in folders)
				result += " + " + f + "\n";

			result += "Danh sách file:\n";
			foreach (string f in files)
				result += " . " + f + "\n";

			return result;
		}
	}
}
