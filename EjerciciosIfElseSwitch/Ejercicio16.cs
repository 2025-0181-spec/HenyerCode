using System;

namespace EjerciciosControl
{

    public static class Ejercicio16
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            double descuento;

            if (precio < 50)
                descuento = 0;
            else if (precio <= 100)
                descuento = precio * 0.05;
            else
                descuento = precio * 0.10;

            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Precio final: " + (precio - descuento));
        }
    }
}
