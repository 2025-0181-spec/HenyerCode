using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio05
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp < 15)
                Console.WriteLine("Alerta: Clima Frio");
            else if (temp <= 28)
                Console.WriteLine("Clima Templado");
            else
                Console.WriteLine("Alerta: Clima Calido");
        }
    }
}
