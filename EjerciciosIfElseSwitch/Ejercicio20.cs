using System;

namespace EjerciciosControl
{

    public static class Ejercicio20
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("Su IMC es: " + imc);

            if (imc < 18.5)
                Console.WriteLine("Clasificacion: Bajo peso.");
            else if (imc < 25)
                Console.WriteLine("Clasificacion: Normal.");
            else if (imc < 30)
                Console.WriteLine("Clasificacion: Sobrepeso.");
            else
                Console.WriteLine("Clasificacion: Obesidad.");
        }
    }
}
