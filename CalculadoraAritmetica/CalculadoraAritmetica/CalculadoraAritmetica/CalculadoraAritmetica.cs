using System;

namespace CalculadoraAritmetica
{
    internal class CalculadoraAritmetica
    {
        static void Main(string[] args)
        {
            double num1, num2, sum, rest, prod, coci;
            int option = 1;
            string message = "Digita cualquier número regresar al menú o 0 para finalizar";
            string lines = "----------------------";
            string divMessage = "La división es: ";

            while (option != 0)
            {
                Console.WriteLine(lines);
                Console.WriteLine("Calculadora Aritmética");
                Console.WriteLine(lines);
                Console.WriteLine("         Menú");
                Console.WriteLine(lines);
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Producto");
                Console.WriteLine("4. Cociente");
                Console.WriteLine("Digite 0 para salir");
                Console.WriteLine("");
                Console.Write("Ingresa una de las opciones del menú: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (option == 0)
                {
                    option = 0;
                }
                else if (option < 1 || option > 4)
                {
                    Console.WriteLine("Elige una opción válida del menú (teclee ENTER)");
                    Console.ReadKey();
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("Ingresa el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Ingresa el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    switch (option)
                    {
                        case 1:
                            sum = num1 + num2;
                            Console.WriteLine("La suma es: " + sum);
                            Console.WriteLine("");
                            break;

                        case 2:
                            rest = num1 - num2;
                            Console.WriteLine("La resta es: " + rest);
                            Console.WriteLine("");
                            break;

                        case 3:
                            prod = num1 * num2;
                            Console.WriteLine("La multiplicación es: " + prod);
                            Console.WriteLine("");
                            break;

                        case 4:
                            if (num1 == 0 && num2 == 0)
                            {
                                Console.WriteLine("División indeterminada!");
                                Console.WriteLine("");
                            }
                            else if (num1 == 0)
                            {
                                coci = num1 / num2;
                                Console.WriteLine(divMessage + coci);
                                Console.WriteLine("");
                            }
                            else if (num2 == 0)
                            {
                                coci = num2 / num1;
                                Console.WriteLine(divMessage + coci);
                                Console.WriteLine("");
                            }
                            else
                            {
                                coci = num1 / num2;
                                Console.WriteLine(divMessage + coci);
                                Console.WriteLine("");
                            }
                            break;
                    }

                    Console.WriteLine(message);
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }

                Console.Clear();
            }

            Console.WriteLine("Has finalizado la calculadora, chao!");
        }
    }
}
