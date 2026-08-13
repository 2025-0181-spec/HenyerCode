using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio09
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Menu: 1) Cafe  2) Te  3) Chocolate  4) Capuchino");
            Console.Write("Seleccione una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("Cafe - Precio: $50"); break;
                case 2: Console.WriteLine("Te - Precio: $40"); break;
                case 3: Console.WriteLine("Chocolate - Precio: $60"); break;
                case 4: Console.WriteLine("Capuchino - Precio: $75"); break;
                default: Console.WriteLine("Opcion no disponible."); break;
            }
        }
    }
}
