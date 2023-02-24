using System;

namespace Calculadora
{
    internal class CalculadoraRemasterizada
    {
        private const string COCIENTE = "  Cociente: ";
        private const string SELECT_MESSAGE = "  Digita cualquier número para ingresar 2 nuevos números o 0 para finalizar. ";
        private const string END_MESSAGE = "  Has finalizado la calculadora, hasta pronto!";

        static void Main(string[] args)
        {
            int option = 1;
            double num1, num2, sum, res, prod, coci;

            while (option != 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("  |─────────────────────────|");
                    Console.WriteLine("  | Calculadora Aritmética! |");
                    Console.WriteLine("  |─────────────────────────|");
                    Console.WriteLine("  |    Menú Operaciones     |");
                    Console.WriteLine("  |─────────────────────────|");
                    Console.WriteLine("  |   Ingresa una de las    |");
                    Console.WriteLine("  |  siguientes opciones:   |");
                    Console.WriteLine("  |                         |");
                    Console.WriteLine("  | 1. Suma                 |");
                    Console.WriteLine("  | 2. Resta                |");
                    Console.WriteLine("  | 3. Producto             |");
                    Console.WriteLine("  | 4. Cociente             |");
                    Console.WriteLine("  |                         |");
                    Console.WriteLine("  |─────────────────────────|");
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
                    Console.Write("  Ingresa tu primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("  Ingresa tu segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    switch (option)
                    {
                        case 1:
                            sum = num1 + num2;
                            Console.WriteLine(String.Format("  Suma: {0} + {1} = {2}", num1, num2, sum));
                            Console.WriteLine("");
                            break;

                        case 2:
                            res = num1 - num2;
                            Console.WriteLine(String.Format("  Resta: {0} - {1} = {2}", num1, num2, res));
                            Console.WriteLine("");
                            break;

                        case 3:
                            prod = num1 * num2;
                            Console.WriteLine(String.Format("  Producto: {0} x {1} = {2}", num1, num2,prod));
                            Console.WriteLine("");
                            break;

                        case 4:
                            if (num1 == 0 && num2 == 0)
                            {
                                Console.WriteLine("  División indeterminada");
                                Console.WriteLine("");
                            }
                            else if (num1 == 0)
                            {
                                coci = num1 / num2;
                                Console.WriteLine(String.Format("{0}{1} ÷ {2} = {3}", COCIENTE, num1, num2, coci));
                                Console.WriteLine("");
                            }
                            else if (num2 == 0)
                            {
                                coci = num2 / num1;
                                Console.WriteLine(String.Format("{0}{1} ÷ {2} = {3}", COCIENTE, num2, num1, coci));
                                Console.WriteLine("");
                            }
                            else
                            {
                                coci = num1 / num2;
                                Console.WriteLine(String.Format("{0}{1} ÷ {2} = {3}", COCIENTE, num1, num2, coci));
                                Console.WriteLine("");
                            }
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
