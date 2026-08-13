using System;

namespace EjerciciosControl
{

    public static class Ejercicio18
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp < 0)
                Console.WriteLine("Hace mucho frio.");
            else if (temp <= 20)
                Console.WriteLine("Clima fresco.");
            else if (temp <= 30)
                Console.WriteLine("Clima agradable.");
            else
                Console.WriteLine("Hace mucho calor.");
        }
    }
}
