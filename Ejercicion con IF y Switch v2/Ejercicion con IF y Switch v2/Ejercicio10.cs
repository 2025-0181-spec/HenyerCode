using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un mes del ano: ");
            string mes = Console.ReadLine().Trim().ToLower();

            switch (mes)
            {
                case "diciembre":
                case "enero":
                case "febrero":
                    Console.WriteLine("Estacion: Invierno");
                    break;
                case "marzo":
                case "abril":
                case "mayo":
                    Console.WriteLine("Estacion: Primavera");
                    break;
                case "junio":
                case "julio":
                case "agosto":
                    Console.WriteLine("Estacion: Verano");
                    break;
                case "septiembre":
                case "octubre":
                case "noviembre":
                    Console.WriteLine("Estacion: Otono");
                    break;
                default:
                    Console.WriteLine("Mes no valido.");
                    break;
            }
        }
    }
}
