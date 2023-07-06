using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_De_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("       Calculadora de IMC        ");
            Console.WriteLine("*********************************");
            Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            // a formula do IMC é o peso dividido a altura ao quadrado
            double resultado = peso / (altura * altura);

            if (resultado < 17)
            {
                Console.WriteLine($"O seu IMC é {resultado} então é muito abaixo do seu peso ideal");
            }
            else if (resultado >= 17 && resultado <= 18.49) 
            {
                Console.WriteLine($"O seu IMC é {resultado} então é abaixo do seu peso ideal");
            }
            else if (resultado >= 18.5 && resultado <= 24.99) 
            {
                Console.WriteLine($"O seu IMC é {resultado} então está em seu peso ideal");
            }
            else if (resultado >= 25 && resultado <= 29.99)
            {
                Console.WriteLine($"O seu IMC é {resultado} então está acima do peso");
            }
            else if (resultado >= 30 && resultado <= 34.99)
            {
                Console.WriteLine($"O seu IMC é {resultado} então está em Obesidade grau 1");
            }
            else if (resultado >= 35 && resultado <= 39.99)
            {
                Console.WriteLine($"O seu IMC é {resultado} então está em Obesidade grau 2");
            }
            else if (resultado >= 40){
                Console.WriteLine($"O seu IMC é {resultado} então está em Obesidade grau 3 (mórbida)");
            }


        }
    }
}
