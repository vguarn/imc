using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu peso?");
             Double peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura?");
             Double altura = Double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc <= 16.9)
            {
                Console.WriteLine("Seu imc é " + imc);
                Console.WriteLine("Você está muito abaixo do peso.");
            } 
            else if (imc <=18.4)
            {
                Console.WriteLine("Seu imc é " + imc);
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Seu imc é " + imc);
                Console.WriteLine("Você está com o peso normal.");
            }
            else if (imc <=29.9)
            {
                Console.WriteLine("Seu imc é " + imc);
                Console.WriteLine("Você está acima do peso.");
            }
            else if (imc <=34.9)
            {
                Console.WriteLine("Seu imc é" + imc);
                Console.WriteLine("Você está com obesidade grau 1.");
            }
             else if (imc <= 40)
            {
                Console.WriteLine("Seu imc é " + imc);
                Console.WriteLine("Você está com obesidade grau 2.");
            }
            else if (imc > 40 )
            {
                Console.WriteLine("Seu imc é " + imc);
                Console.WriteLine("Você está com obesidade grau 3.");
            }
            else
            {
                Console.WriteLine("Algo deu errado! Tente novamente.");
            }
            Console.ReadKey();
        }
    }
}
