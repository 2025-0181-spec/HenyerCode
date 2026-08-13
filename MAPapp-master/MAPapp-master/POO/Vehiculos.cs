using System;

namespace POO
{

    public class Vehiculos
    {
        public string marca = "";
        public string modelo = "";
        public string anioFabricacion = "";
        public string color = "";
        public string matricula = "";
        public bool tieneLuces;
        public string tipo = "";
        public string maxVelocity = "";
        public bool esElectrico;
        public string placa = "";
        private bool estado;
        private bool lucesEncendidas;

        public Vehiculos() { }

        public bool encender()
        {
            this.estado = true;
            Console.WriteLine("El vehiculo se ha encendido.");
            return this.estado;
        }

        public bool apagar()
        {
            this.estado = false;
            this.lucesEncendidas = false;
            Console.WriteLine("El vehiculo se ha apagado.");
            return this.estado;
        }

        public string getEstado()
        {
            if (this.estado == true)
            {
                return "Encendido";
            }
            return "Apagado";
        }

        public void encenderLuces()
        {
            if (this.getEstado() == "Apagado")
            {
                Console.WriteLine("No se pueden encender las luces: el vehiculo esta apagado.");
                return;
            }
            if (this.tieneLuces == false)
            {
                Console.WriteLine("Este vehiculo no tiene luces.");
                return;
            }
            this.lucesEncendidas = true;
            Console.WriteLine("Luces encendidas.");
        }

        public void apagarLuces()
        {
            if (this.lucesEncendidas == false)
            {
                Console.WriteLine("Las luces ya estan apagadas.");
                return;
            }
            this.lucesEncendidas = false;
            Console.WriteLine("Luces apagadas.");
        }

        public bool getLuces()
        {
            return this.lucesEncendidas;
        }
    }

    public class Automovil : Vehiculos
    {
        private int cantRuedas;
        public int cantPuertas;
        public string uso = "";
        public string segmento = "";
        public string motor = "";
        public string tipoCombustible = "";
        public bool tieneEspejos;
        public int pasajeros;
        private int kilometraje;
        private int velocidadActual;
        string nombre;

        public Automovil(string? name)
        {
            this.nombre = name ?? "Coshita";
        }

        public void acelerar(int velocidad, int tiempo)
        {
            if (this.getEstado() == "Apagado")
            {
                Console.WriteLine("No se puede acelerar: enciende el vehiculo primero.");
                return;
            }
            this.velocidadActual += velocidad;

            this.kilometraje += velocidad * tiempo / 1000;
            Console.WriteLine(this.nombre + " acelera a " + this.velocidadActual + " km/h.");
        }

        public void frenar(int cantidad)
        {
            this.velocidadActual -= cantidad;
            if (this.velocidadActual < 0)
            {
                this.velocidadActual = 0;
            }
            Console.WriteLine(this.nombre + " frena. Velocidad actual: " + this.velocidadActual + " km/h.");
        }

        public void mover()
        {
            if (this.velocidadActual > 0)
            {
                Console.WriteLine(this.nombre + " se esta moviendo a " + this.velocidadActual + " km/h.");
            }
            else
            {
                Console.WriteLine(this.nombre + " esta detenido.");
            }
        }

        public int getVelocidad()
        {
            return this.velocidadActual;
        }

        public int getKilometroRecorridos()
        {
            return this.kilometraje;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }

    public class AutoDeportivo : Automovil
    {
        public AutoDeportivo(string? name) : base(name) { }

        public void activarTurbo()
        {
            if (this.getEstado() == "Apagado")
            {
                Console.WriteLine("Enciende el auto antes de usar el turbo.");
                return;
            }
            Console.WriteLine(">> Turbo activado! Aceleracion extra.");
            this.acelerar(80, 30);
        }
    }
}
