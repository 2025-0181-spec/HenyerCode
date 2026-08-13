using System;

namespace EjerciciosControl
{

    public static class Ejercicio13
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un ano: ");
            int anio = int.Parse(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                Console.WriteLine("El ano es Bisiesto.");
            else
                Console.WriteLine("El ano NO es Bisiesto.");
        }
    }
}
