using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio03
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Numero Par");
            else
                Console.WriteLine("Numero Impar");
        }
    }
}
