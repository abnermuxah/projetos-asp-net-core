using System;

namespace geometria_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Digite a altura e largura do retangulo");
            ret.Altura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Area:" + ret.Area());
            Console.WriteLine("Perimetro:" + ret.Perimetro());
            Console.WriteLine("Diagonal:" + ret.Diagonal());
        }
    }
}
