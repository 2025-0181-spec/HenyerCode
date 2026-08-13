using System;

namespace EjerciciosControl
{

    public static class Ejercicio06
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la calificacion (0-100): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 60)
                Console.WriteLine("Aprobado.");
            else
                Console.WriteLine("Reprobado.");
        }
    }
}
