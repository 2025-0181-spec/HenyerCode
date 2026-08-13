using System;

namespace EjerciciosControl
{

    public static class Ejercicio09
    {
        public static void Ejecutar()
        {
            Console.Write("Numero 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Numero 3: ");
            double c = double.Parse(Console.ReadLine());

            double mayor = a;
            if (b > mayor) mayor = b;
            if (c > mayor) mayor = c;

            Console.WriteLine("El mayor es: " + mayor);
        }
    }
}
