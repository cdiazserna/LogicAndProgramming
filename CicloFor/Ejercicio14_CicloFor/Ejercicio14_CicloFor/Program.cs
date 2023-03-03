using System;

namespace Ejercicio14_CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un algoritmo que permita mostrar los números primos existentes entre 1 y N

            int numbers, i, j;
            bool isPrime = true;

            Console.Write("Ingrese un tope: "); //6
            numbers = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= numbers; i++) //i = 4
            {
                isPrime = true;

                for (j = 2; j < i; j++) //i = 4, j=2
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"El número {i} es primo");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
