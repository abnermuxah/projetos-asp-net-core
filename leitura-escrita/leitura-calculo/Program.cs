using System;

namespace leitura_calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

           
            Console.WriteLine("Digite o nome do funcionario 1");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do funcionario 1");
            f1.salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionario 2");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do funcionario 2");
            f2.salario = int.Parse(Console.ReadLine());

            Console.WriteLine("A media salariao eh " + (f1.salario + f2.salario)/ 2 );
        }
    }
}
