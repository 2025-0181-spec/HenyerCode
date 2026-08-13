using System;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AutoDeportivo miCarro = new AutoDeportivo("Rayo Azul");
            miCarro.marca = "Toyota";
            miCarro.modelo = "Supra";
            miCarro.color = "Azul";
            miCarro.tieneLuces = true;

            Console.WriteLine("===== " + miCarro.getNombre() + " (" + miCarro.marca + " " + miCarro.modelo + ") =====");
            Console.WriteLine("Estado inicial: " + miCarro.getEstado());
            Console.WriteLine();

            miCarro.encender();
            miCarro.encenderLuces();
            miCarro.acelerar(100, 60);
            miCarro.mover();
            miCarro.activarTurbo();
            miCarro.mover();
            miCarro.frenar(120);
            miCarro.mover();
            miCarro.apagarLuces();
            miCarro.apagar();

            Console.WriteLine();
            Console.WriteLine("Kilometros recorridos: " + miCarro.getKilometroRecorridos());
            Console.WriteLine("Velocidad final: " + miCarro.getVelocidad() + " km/h");
        }
    }
}
