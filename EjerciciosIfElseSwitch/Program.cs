using System;

namespace EjerciciosControl
{
    internal class Program
    {
        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n========= MENU (20 EJERCICIOS) =========");
                Console.WriteLine("1. Positivo, negativo o cero    11. Calculo de impuestos");
                Console.WriteLine("2. Par o impar                  12. Clasificacion de numeros");
                Console.WriteLine("3. Mayor de edad                13. Ano bisiesto");
                Console.WriteLine("4. Multiplo de 5                14. Calificacion a letra");
                Console.WriteLine("5. Descuento por edad           15. Puede formar triangulo");
                Console.WriteLine("6. Calificacion aprobatoria     16. Descuento por precio");
                Console.WriteLine("7. Dia de la semana             17. Tipo de triangulo");
                Console.WriteLine("8. Mayor entre dos              18. Evaluacion de temperatura");
                Console.WriteLine("9. Mayor entre tres             19. Hora a turno");
                Console.WriteLine("10. Clasificacion de angulos    20. Clasificacion de IMC");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opcion: ");

                string op = Console.ReadLine();
                Console.WriteLine();

                switch (op)
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
                    case "11": Ejercicio11.Ejecutar(); break;
                    case "12": Ejercicio12.Ejecutar(); break;
                    case "13": Ejercicio13.Ejecutar(); break;
                    case "14": Ejercicio14.Ejecutar(); break;
                    case "15": Ejercicio15.Ejecutar(); break;
                    case "16": Ejercicio16.Ejecutar(); break;
                    case "17": Ejercicio17.Ejecutar(); break;
                    case "18": Ejercicio18.Ejecutar(); break;
                    case "19": Ejercicio19.Ejecutar(); break;
                    case "20": Ejercicio20.Ejecutar(); break;
                    case "0": salir = true; break;
                    default: Console.WriteLine("Opcion no valida."); break;
                }
            }
            Console.WriteLine("Programa finalizado.");
        }
    }
}
