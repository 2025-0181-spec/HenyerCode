using System;

namespace EjerciciosControl
{

    public static class Ejercicio08
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el primer numero: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("El mayor es: " + a);
            else if (b > a)
                Console.WriteLine("El mayor es: " + b);
            else
                Console.WriteLine("Los numeros son iguales.");
        }
    }
}
