﻿using System;
using System.IO;

namespace CSCourse
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nomeDoArquivo = "arquivo.txt";

			Console.WriteLine(File.Exists(nomeDoArquivo));

			File.WriteAllText(nomeDoArquivo, "Algum texto");

			Console.WriteLine(File.Exists(nomeDoArquivo));

			Console.ReadKey(true);
		}
	}
}
