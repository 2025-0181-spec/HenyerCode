using System;

namespace EjerciciosCondicionales
{
    internal class Program
    {
        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n===== MENU DE EJERCICIOS =====");
                Console.WriteLine("1.  Control de acceso por edad");
                Console.WriteLine("2.  Sistema de calificaciones");
                Console.WriteLine("3.  Numeros pares e impares");
                Console.WriteLine("4.  Cajero automatico");
                Console.WriteLine("5.  Clasificador de temperatura");
                Console.WriteLine("6.  Dias de la semana");
                Console.WriteLine("7.  Calculadora basica");
                Console.WriteLine("8.  Roles de usuario");
                Console.WriteLine("9.  Dispensador de bebidas");
                Console.WriteLine("10. Estaciones del ano");
                Console.WriteLine("0.  Salir");
                Console.Write("Elige una opcion: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicio01.Ejecutar(); break;
                    case "2": Ejercicio02.Ejecutar(); break;
                    case "3": Ejercicio03.Ejecutar(); break;
                    case "4": Ejercicio04.Ejecutar(); break;
                    case "5": Ejercicio05.Ejecutar(); break;
                    case "6": Ejercicio06.Ejecutar(); break;
                    case "7": Ejercicio07.Ejecutar(); break;
                    case "8": Ejercicio08.Ejecutar(); break;
                    case "9": Ejercicio09.Ejecutar(); break;
                    case "10": Ejercicio10.Ejecutar(); break;
                    case "0": salir = true; break;
                    default: Console.WriteLine("Opcion no valida."); break;
                }
            }

            Console.WriteLine("Programa finalizado.");
        }
    }
}
