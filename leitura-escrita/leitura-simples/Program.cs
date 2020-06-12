using System;
/*
 *  Ler os dados de 2 pessoas (nome e idade) depois mostrar o nome da pessoa com idade maior
 *  Exe:
 *  Dados da primeira pessoa:
    Nome: Maria
    Idade: 17
    Dados da segunda pessoa:
    Nome: Joao
    Idade: 16
    Pessoa mais velha: Maria
 */
namespace leitura_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.Write("Primeiro Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa");
            Console.Write("Primeiro Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("A pessoa mais velha eh: " + pessoa1.nome);
            }
            else if (pessoa2.idade > pessoa1.idade)
            {
                Console.WriteLine("A pessoa mais velha eh: " + pessoa2.nome);
            }
            else 
            {
                Console.WriteLine(pessoa1.nome + " e " + pessoa2.nome + "tem idades iguais");
            }

        }
    }
}
