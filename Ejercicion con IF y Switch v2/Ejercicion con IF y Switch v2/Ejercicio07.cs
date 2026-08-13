using System;

namespace EjerciciosCondicionales
{
    public static class Ejercicio07
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el primer numero: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la operacion (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+": Console.WriteLine("Resultado: " + (a + b)); break;
                case "-": Console.WriteLine("Resultado: " + (a - b)); break;
                case "*": Console.WriteLine("Resultado: " + (a * b)); break;
                case "/":
                    if (b != 0)
                        Console.WriteLine("Resultado: " + (a / b));
                    else
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    break;
                default: Console.WriteLine("Operacion no valida."); break;
            }
        }
    }
}
