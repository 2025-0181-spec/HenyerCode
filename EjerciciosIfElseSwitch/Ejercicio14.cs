using System;

namespace EjerciciosControl
{

    public static class Ejercicio14
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la calificacion (0-100): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 90)
                Console.WriteLine("Letra: A");
            else if (nota >= 80)
                Console.WriteLine("Letra: B");
            else if (nota >= 70)
                Console.WriteLine("Letra: C");
            else if (nota >= 60)
                Console.WriteLine("Letra: D");
            else
                Console.WriteLine("Letra: F");
        }
    }
}
