using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio06
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un numero del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Dia invalido."); break;
            }
        }
    }
}
