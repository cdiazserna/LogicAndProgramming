using System;

namespace ValidarParImpar
{
    public class ValidarParImpar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para validar si los números son pares o impares");
            Console.WriteLine("--------------------------------------------------------");

            //Definir num1, num2 Como Entero -- DECLARAR VARIABLES
            int num1, num2;

            Console.WriteLine("Ingresar primer número:");
            num1 =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"El número 1 es par: {num1}");
            }
            else
            {
                Console.WriteLine($"El número 1 es impar: {num1}");
            }

            if (num2 % 2 == 0)
            {
                Console.WriteLine($"El número 2 es par: {num2}");
            }
            else
            {
                Console.WriteLine($"El número 2 es par: {num2}");
            }
        }
    }
}
