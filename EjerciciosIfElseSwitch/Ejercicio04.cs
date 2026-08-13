using System;

namespace EjerciciosControl
{

    public static class Ejercicio04
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0)
                Console.WriteLine("El numero SI es multiplo de 5.");
            else
                Console.WriteLine("El numero NO es multiplo de 5.");
        }
    }
}
