using System;

namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realice un pseudocódigo que itere los primeros N números naturales y me sume únicamente los que sean pares

            //DATOS DE ENTRADA --> int n, int suma
            //PROCESO
            //DATOS DE SALIDA <-- suma

            //Declaré unas variables (inicializé la variable suma)
            int n, suma = 0, i;

            //Le pedí al usuario ingresar el tope por pantalla
            Console.Write("Por favor ingrese los primeros N números: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Hago la iteración
            //primer item: inicializa una variable controladora (casi siempre se inicializa en cero)
            //segundo item: me define hasta dónde quiero llegar (en este caso hasta n)
            //tercer ítem: me suma la variabla iteradora (controladora) de 1 en 1 hasta llegar a n
            for (i = 0; i <= n; i++)  //i = 7  n = 6
            {
                if (i % 2 == 0)
                {
                    //suma = 12
                    suma = suma + i;
                }
            }

            Console.Write("");
            Console.Write("La suma de los primeros " + n + " números pares es: " + suma);
        }
    }
}
