using System;

namespace EjerciciosControl
{

    public static class Ejercicio03
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Es mayor de edad.");
            else
                Console.WriteLine("Es menor de edad.");
        }
    }
}
