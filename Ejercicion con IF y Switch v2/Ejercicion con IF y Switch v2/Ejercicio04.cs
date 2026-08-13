using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio04
    {
        public static void Ejecutar()
        {
            decimal saldo = 1000.50m;
            Console.WriteLine("Saldo disponible: " + saldo);
            Console.Write("Ingrese el monto a retirar: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            if (saldo >= monto)
            {
                saldo = saldo - monto;
                Console.WriteLine("Transaccion autorizada.");
                Console.WriteLine("Nuevo saldo: " + saldo);
            }
            else
            {
                Console.WriteLine("Operacion cancelada: Fondos Insuficientes.");
            }
        }
    }
}
