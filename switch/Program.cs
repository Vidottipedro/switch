using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero");
             double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero ");
            double num2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Selecione o operador (+ - * / )");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("O resultado da soma é: " + (num1 + num2));

                    break;

                case "-":
                    Console.WriteLine("O resultado da subtração é: " + (num1 - num2));

                    break;

                case "*":
                    Console.WriteLine("O resultado da multiplicação é: " + (num1 * num2));

                    break;

                case "/":
                    Console.WriteLine("O resultado da divisão é: " + (num1 / num2));

                    break;

                 
            }
              Console.ReadKey(); 

        }
    }
}
