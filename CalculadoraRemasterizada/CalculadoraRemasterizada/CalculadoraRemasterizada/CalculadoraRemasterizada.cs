using System;
using System.Linq;

namespace Calculadora
{
    internal class CalculadoraRemasterizada
    {
        private const string SELECT_MESSAGE = "  Digita cualquier número para volver al menú o 0 para finalizar. ";
        private const string END_MESSAGE = "  Has finalizado la calculadora, hasta pronto!";
        private const string LINES = "  |─────────────────────────|";

        static void Main(string[] args)
        {
            int option = 1, i, j;
            double num1, num2, sum = 0, res = 0, prod = 1, coci = 1, aux;

            while (option != 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(LINES);
                    Console.WriteLine("  | Calculadora Aritmética! |");
                    Console.WriteLine(LINES);
                    Console.WriteLine("  |    Menú Operaciones     |");
                    Console.WriteLine(LINES);
                    Console.WriteLine("  |   Ingresa una de las    |");
                    Console.WriteLine("  |  siguientes opciones:   |");
                    Console.WriteLine("  |                         |");
                    Console.WriteLine("  | 1. Suma                 |");
                    Console.WriteLine("  | 2. Resta                |");
                    Console.WriteLine("  | 3. Producto             |");
                    Console.WriteLine("  | 4. Cociente             |");
                    Console.WriteLine("  |                         |");
                    Console.WriteLine(LINES);
                    Console.Write("   Opción: ");

                } while (!int.TryParse(Console.ReadLine(), out option));

                Console.WriteLine("");

                if (option < 1 || option > 4)
                {
                    Console.Write("  Elige una opción válida del menú (teclea ENTER) ");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("  ¿Cuántos números deseas operar?: ");
                    double[] numbers = new double[Convert.ToInt32(Console.ReadLine())];

                    //if(numbers.Count() == 0)
                    //{
                    //    Console.WriteLine("   Debes ingresar al menos 2 números");
                    //}

                    for (i = 0; i < numbers.Length; i++)
                    {
                        Console.Write("  Ingresa un número: ");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                    }

                    //Begin Sort Array
                    for (i = 0; i < numbers.Length; i++)
                    {
                        for(j = (i + 1); j < numbers.Length; j++)
                        {
                            if (numbers[i] > numbers[j])
                            {
                                aux = numbers[j];
                                numbers[j] = numbers[i];
                                numbers[i] = aux;
                            }
                        }
                    }
                    //End Sort Array

                    switch (option)
                    {
                        case 1:
                            for (i = 0; i < numbers.Length; i++)
                                sum = sum + numbers[i];
                            Console.WriteLine(String.Format("  La suma es: {0}", sum));
                            Console.WriteLine("");
                            break;

                        case 2:
                            for (i = 0; i < numbers.Length; i++)
                                res = numbers[i] - res;
                            Console.WriteLine(String.Format("  La resta es: {0}", res));
                            Console.WriteLine("");
                            break;

                        case 3:
                            for (i = 0; i < numbers.Length; i++)
                                prod = numbers[i] * prod;
                            Console.WriteLine(String.Format("  El producto es: {0}", prod));
                            Console.WriteLine("");
                            break;

                        case 4:
                            for (i = 0; i < numbers.Length; i++)
                                coci = numbers[i] / coci;
                            if (Double.IsNaN(coci))
                                Console.WriteLine("  El cociente es indeterminado");
                            else
                                Console.WriteLine(String.Format("  El cociente es: {0}", coci));
                            Console.WriteLine("");
                            break;
                    }

                    do
                    {
                        Console.Write(SELECT_MESSAGE);
                    } while (!int.TryParse(Console.ReadLine(), out option));
                }

                Console.Clear();
            }

            Console.WriteLine("");
            Console.WriteLine(END_MESSAGE);
            Console.ReadKey();
        }
    }
}
