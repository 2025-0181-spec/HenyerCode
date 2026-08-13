using System;

namespace EjerciciosControl
{

    public static class Ejercicio19
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora <= 5)
                Console.WriteLine("Madrugada");
            else if (hora >= 6 && hora <= 11)
                Console.WriteLine("Manana");
            else if (hora >= 12 && hora <= 17)
                Console.WriteLine("Tarde");
            else if (hora >= 18 && hora <= 23)
                Console.WriteLine("Noche");
            else
                Console.WriteLine("Hora invalida (debe ser 0-23).");
        }
    }
}
