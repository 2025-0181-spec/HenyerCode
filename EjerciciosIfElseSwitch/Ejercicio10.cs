using System;

namespace EjerciciosControl
{

    public static class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el angulo en grados: ");
            double ang = double.Parse(Console.ReadLine());

            if (ang < 90)
                Console.WriteLine("Angulo Agudo.");
            else if (ang == 90)
                Console.WriteLine("Angulo Recto.");
            else if (ang < 180)
                Console.WriteLine("Angulo Obtuso.");
            else if (ang == 180)
                Console.WriteLine("Angulo Llano.");
            else
                Console.WriteLine("Angulo mayor a 180 grados.");
        }
    }
}
