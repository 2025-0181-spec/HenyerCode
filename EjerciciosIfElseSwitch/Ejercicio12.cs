using System;

namespace EjerciciosControl
{

    public static class Ejercicio12
    {
        public static void Ejecutar()
        {
            Console.Write("Numero 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Numero 3: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
                Console.WriteLine("Hay ceros.");
            else if (a > 0 && b > 0 && c > 0)
                Console.WriteLine("Todos son positivos.");
            else if (a < 0 && b < 0 && c < 0)
                Console.WriteLine("Todos son negativos.");
            else
                Console.WriteLine("Son mixtos (positivos y negativos).");
        }
    }
}
