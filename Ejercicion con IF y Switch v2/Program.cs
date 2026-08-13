using System;

class Program
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
                case "1": Ejercicio1(); break;
                case "2": Ejercicio2(); break;
                case "3": Ejercicio3(); break;
                case "4": Ejercicio4(); break;
                case "5": Ejercicio5(); break;
                case "6": Ejercicio6(); break;
                case "7": Ejercicio7(); break;
                case "8": Ejercicio8(); break;
                case "9": Ejercicio9(); break;
                case "10": Ejercicio10(); break;
                case "0": salir = true; break;
                default: Console.WriteLine("Opcion no valida."); break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }

    static void Ejercicio1()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Bienvenido, acceso permitido.");
        else
            Console.WriteLine("Acceso denegado. Debe ser mayor de edad.");
    }

    static void Ejercicio2()
    {
        Console.Write("Ingrese la calificacion del alumno: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 60)
            Console.WriteLine("Estado: Aprobado");
        else
            Console.WriteLine("Estado: Reprobado");
    }

    static void Ejercicio3()
    {
        Console.Write("Ingrese un numero entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine("Numero Par");
        else
            Console.WriteLine("Numero Impar");
    }

    static void Ejercicio4()
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

    static void Ejercicio5()
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double temp = double.Parse(Console.ReadLine());

        if (temp < 15)
            Console.WriteLine("Alerta: Clima Frio");
        else if (temp <= 28)
            Console.WriteLine("Clima Templado");
        else
            Console.WriteLine("Alerta: Clima Calido");
    }

    static void Ejercicio6()
    {
        Console.Write("Ingrese un numero del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1: Console.WriteLine("Lunes"); break;
            case 2: Console.WriteLine("Martes"); break;
            case 3: Console.WriteLine("Miercoles"); break;
            case 4: Console.WriteLine("Jueves"); break;
            case 5: Console.WriteLine("Viernes"); break;
            case 6: Console.WriteLine("Sabado"); break;
            case 7: Console.WriteLine("Domingo"); break;
            default: Console.WriteLine("Dia invalido."); break;
        }
    }

    static void Ejercicio7()
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

    static void Ejercicio8()
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

    static void Ejercicio9()
    {
        Console.WriteLine("Menu: 1) Cafe  2) Te  3) Chocolate  4) Capuchino");
        Console.Write("Seleccione una opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: Console.WriteLine("Cafe - Precio: $50"); break;
            case 2: Console.WriteLine("Te - Precio: $40"); break;
            case 3: Console.WriteLine("Chocolate - Precio: $60"); break;
            case 4: Console.WriteLine("Capuchino - Precio: $75"); break;
            default: Console.WriteLine("Opcion no disponible."); break;
        }
    }

    static void Ejercicio10()
    {
        Console.Write("Ingrese un mes del ano: ");

        string mes = Console.ReadLine().Trim().ToLower();

        switch (mes)
        {
            case "diciembre":
            case "enero":
            case "febrero":
                Console.WriteLine("Estacion: Invierno");
                break;
            case "marzo":
            case "abril":
            case "mayo":
                Console.WriteLine("Estacion: Primavera");
                break;
            case "junio":
            case "julio":
            case "agosto":
                Console.WriteLine("Estacion: Verano");
                break;
            case "septiembre":
            case "octubre":
            case "noviembre":
                Console.WriteLine("Estacion: Otono");
                break;
            default:
                Console.WriteLine("Mes no valido.");
                break;
        }
    }
}
