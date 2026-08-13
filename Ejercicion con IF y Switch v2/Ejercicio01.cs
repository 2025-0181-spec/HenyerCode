using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio01
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Bienvenido, acceso permitido.");
            else
                Console.WriteLine("Acceso denegado. Debe ser mayor de edad.");
        }
    }
}
