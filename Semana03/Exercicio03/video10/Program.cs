using System;
using System.IO;

namespace CSCourse
{
	class Program
	{
		public static void Main(string[] args)
		{
			string caminho = "/home/nathan/SEII-NathaBernardesCampos/";
			string[] arquivos = Directory.GetFiles(caminho);

			Console.WriteLine(Directory.Exists(caminho));
			foreach (var x in arquivos)
			{
				Console.WriteLine(x);
			}

		}
	}
}
