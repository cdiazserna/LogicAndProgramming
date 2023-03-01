using System;

namespace CIcloFor_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un algoritmo que pida por pantalla N números y calcule el factorial de ellos.

            double n, i, factorial = 1;

            Console.Write("Digite el número factorial: ");
            n = Convert.ToDouble(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de: " + n + " es: " + factorial);
        }
    }
}
