using System;

namespace EjerciciosControl
{

    public static class Ejercicio15
    {
        public static void Ejecutar()
        {
            Console.Write("Lado 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("SI pueden formar un triangulo.");
            else
                Console.WriteLine("NO pueden formar un triangulo.");
        }
    }
}
