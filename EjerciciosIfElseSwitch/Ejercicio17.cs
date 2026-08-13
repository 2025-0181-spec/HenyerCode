using System;

namespace EjerciciosControl
{

    public static class Ejercicio17
    {
        public static void Ejecutar()
        {
            Console.Write("Lado 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            double c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Triangulo Equilatero (3 lados iguales).");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triangulo Isosceles (2 lados iguales).");
            else
                Console.WriteLine("Triangulo Escaleno (todos distintos).");
        }
    }
}
