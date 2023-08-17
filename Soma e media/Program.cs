using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaMediaApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à aplicação Soma e Média!");

            Console.Write("Quantos números deseja informar (entre 3 e 10)? ");
            int quantidadeNumeros = ReadIntInRange(3, 10);

            double[] numeros = new double[quantidadeNumeros];

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                while (!double.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Valor inválido. Informe novamente: ");
                }
            }

            double soma = numeros.Sum();
            double media = numeros.Average();

            Console.WriteLine($"Soma dos números: {soma}");
            Console.WriteLine($"Média dos números: {media}");

            Console.ReadLine();
        }

        static int ReadIntInRange(int min, int max)
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.Write($"Valor inválido. Informe um número entre {min} e {max}: ");
            }
            return value;
        }
    }
}




