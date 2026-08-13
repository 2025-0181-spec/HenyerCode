using System;

namespace EjerciciosControl
{

    public static class Ejercicio05
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 60)
                Console.WriteLine("Aplica para el descuento del 50%.");
            else
                Console.WriteLine("No aplica para el descuento.");
        }
    }
}
