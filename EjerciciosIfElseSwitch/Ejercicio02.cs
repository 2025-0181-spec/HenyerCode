using System;

namespace EjerciciosControl
{

    public static class Ejercicio02
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un numero entero: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("El numero es Par.");
            else
                Console.WriteLine("El numero es Impar.");
        }
    }
}
