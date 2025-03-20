using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			// Instanciar objeto da classe Aluno
			Aluno a = new Aluno();
			a.nome = "Roberto";
			a.nota1 = 4;
			a.nota2 = 5;
			a.mensagem();
		}
	}
}
