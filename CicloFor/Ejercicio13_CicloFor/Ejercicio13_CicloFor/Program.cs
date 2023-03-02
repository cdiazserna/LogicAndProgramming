using System;

namespace Ejercicio13_CicloFor
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, gender;
            float percentageMale, percentageFemale, persons;
            int i, counterMale = 0, counterFemale = 0;

            Console.Write("¿Cuántas personas quieres ingresar? ");
            persons = Convert.ToInt32(Console.ReadLine());
            Console.Write("");

            for (i = 0; i < persons; i++)
            {
                Console.Write("Nombre: ");
                firstName = Console.ReadLine();
                Console.Write("");

                Console.Write("Apellido: ");
                lastName = Console.ReadLine();
                Console.Write("");

                Console.Write("Digite M para masculino o F para femenino: ");
                gender = Console.ReadLine();
                Console.Write("");

                if (gender == "M" || gender == "m") counterMale++;
                else counterFemale++;
            }

            percentageMale = (counterMale / persons) * 100;
            percentageFemale = (counterFemale / persons) * 100;

            Console.WriteLine($"El procentaje de hombres es: {String.Format("{0:0.##}", percentageMale)}%");
            Console.WriteLine($"El procentaje de mujeres es: {String.Format("{0:0.##}", percentageFemale)}%");
        }
    }
}
