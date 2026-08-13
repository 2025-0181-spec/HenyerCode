using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio08
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la letra del rol (A, E, T, L): ");
            char rol = Console.ReadLine().ToUpper()[0];

            switch (rol)
            {
                case 'A':
                    Console.WriteLine("Rol: Administrador - Permisos: acceso total al sistema.");
                    break;
                case 'E':
                    Console.WriteLine("Rol: Editor - Permisos: crear y modificar contenido.");
                    break;
                case 'T':
                    Console.WriteLine("Rol: Autor - Permisos: crear su propio contenido.");
                    break;
                case 'L':
                    Console.WriteLine("Rol: Lector - Permisos: solo lectura.");
                    break;
                default:
                    Console.WriteLine("Rol: Invitado - Permisos: acceso limitado.");
                    break;
            }
        }
    }
}
