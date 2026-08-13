using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio02
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la calificacion del alumno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 60)
                Console.WriteLine("Estado: Aprobado");
            else
                Console.WriteLine("Estado: Reprobado");
        }
    }
}
