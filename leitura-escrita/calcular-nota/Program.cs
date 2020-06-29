using System;

namespace calcular_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Digite a nota 1 de " + aluno1.Nome);
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2 de " + aluno1.Nome);
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3 de " + aluno1.Nome);
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: " + aluno1.NotaFinal());
            Console.WriteLine("Aprovado: " + aluno1.Aprovado());
            Console.WriteLine("Nota Restante:" + aluno1.NotaFinal());
        }
    }
}
