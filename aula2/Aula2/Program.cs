using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Informe uma largura:");
                double largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe uma altura:");
                double altura = Convert.ToDouble(Console.ReadLine());
                double area = CalculaArea(largura, altura);
                Console.WriteLine("A área é " + area);
            }
            catch(Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

    static double CalculaArea(double largura, double altura)
    {
        return largura * altura;
    }

    }
}
