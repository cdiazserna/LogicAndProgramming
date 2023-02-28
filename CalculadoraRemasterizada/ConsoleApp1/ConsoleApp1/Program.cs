using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Type the top of numbers: ");
                int top = Convert.ToInt32(Console.ReadLine());

                ICollection<int> evenNumbers = CalculateEvenNumber(top);
                int counter = 1;

                foreach (int evenNumber in evenNumbers)
                {
                    Console.Write($"{counter}- Even number : {evenNumber}\n");
                    counter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static ICollection<int> CalculateEvenNumber(int top)
        {
            ICollection<int> evenNumbers = new List<int>();

            for (int i = 0; i < top; i++)
                if (i % 2 != 0)
                    evenNumbers.Add(i);
            return evenNumbers;
        }
    }
}


