using System;

namespace EjerciciosControl
{

    public static class Ejercicio01
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un numero: ");
            double n = double.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("El numero es Positivo.");
            else if (n < 0)
                Console.WriteLine("El numero es Negativo.");
            else
                Console.WriteLine("El numero es Cero.");
        }
    }
}
