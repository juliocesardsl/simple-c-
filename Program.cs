using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Qual o seu nome?");
            string name = Console.ReadLine();
            File.WriteAllText("C:\\Users\\Public\\Documents\\HelloWorld.txt", "Hello " + name);
            Console.WriteLine("Me diga 3 números");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine($"Você digitou o número {number}");
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    i--;
                }
            }
            
            int conta = Soma(numbers);
            string resultado = $"A soma dos números é: {conta}";

            File.AppendAllText("C:\\Users\\Public\\Documents\\HelloWorld.txt", Environment.NewLine + resultado);
            Console.WriteLine("Seu resultado foi salvo no arquivo HelloWorld.txt");

        }

        static int Soma(List<int> numbers)
        {
            int soma = 0;
            foreach (int number in numbers)
            {
                soma += number;
            }
            Console.WriteLine($"A soma dos números é: {soma}");
            return soma;
        }
    }
}