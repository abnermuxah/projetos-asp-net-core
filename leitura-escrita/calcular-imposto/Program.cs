using System;

namespace calcular_imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            
            Console.WriteLine("Digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario bruto do funcionario: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto a ser cobrado em reais");
            func.Imposto = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Resultado: " + func);

            Console.WriteLine(" Quer aumentar o salario em quantos por cento ?");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);

            Console.WriteLine("Resultado atualizado: " + func);

        }
    }
}
