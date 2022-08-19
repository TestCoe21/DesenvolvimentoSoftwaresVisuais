using System;

namespace aula3
{
    class Program
    {
        static double calculaModa(double[] numeros)
        {
            double[] repeticoes = new double[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                double atual = numeros[i];
                int cont = 0;

                for (int j = 0; j < numeros.Length; j++)
                {
                    if(numeros[j] == atual){
                        cont++;
                    }
                }
                repeticoes[i] = cont;
            };

            int maior = 0;
            for (int i = 1; i < repeticoes.Length; i++)
            {
                if (repeticoes[i] > repeticoes[i-1])
                {
                    maior = i;
                }
            }
            return numeros[maior];
        }  
        static double calculaMediana(double[] numeros)
        {
            // Array.Sort(numeros);
            
            int meio = numeros.Length / 2;
            if ((numeros.Length % 2) == 0)
            {
                return (numeros[meio] + numeros[meio -1]) / 2;
            } else {
                return numeros[meio];
            }
        }   
        static double calculaMedia(double[] numeros)
        {
            double soma = 0.0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma / numeros.Length;
        }

        static void Main(string[] args)
        {
            double[] numeros = {2, 4, 6, 8, 7, 5, 3, 1, 1, 1, 1, 1, 7, 7, 7};
            double media = calculaMedia(numeros);
            Console.WriteLine("a media eh " + media);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("/n");
            
            double mediana = calculaMediana(numeros);
            Console.WriteLine("a mediana eh " + mediana);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("/n");
            double moda = calculaModa(numeros);
            Console.WriteLine("a moda eh " + moda);
        }
    }
}