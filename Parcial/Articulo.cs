using System;

namespace PuntoDeVenta
{
    public class Articulo
    {
        private string codigo;
        private string descripcion;
        private double precio;
        private int existencia;

        private const int StockMinimo = 5;

        public event Action<string> Mensaje;

        public Articulo(string codigo, string descripcion, double precio, int existencia)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.Existencia = existencia;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    precio = 0;
                else
                    precio = value;
            }
        }

        public int Existencia
        {
            get { return existencia; }
            set
            {
                if (value < 0)
                    existencia = 0;
                else
                    existencia = value;
            }
        }

        private void Avisar(string texto)
        {
            if (Mensaje != null)
                Mensaje(texto);
        }

        public void VenderArticulo(int cantidad)
        {
            if (cantidad <= 0)
            {
                Avisar("La cantidad a vender debe ser mayor que cero.");
            }
            else
            {
                if (cantidad <= this.existencia)
                {
                    this.existencia -= cantidad;
                    Avisar("Venta realizada: " + cantidad + " unidad(es) de " + this.descripcion + ".");
                    Avisar("Existencia restante: " + this.existencia);

                    if (this.existencia < StockMinimo)
                    {
                        Avisar("ALERTA: el stock cayo por debajo del minimo (" + StockMinimo + " unidades).");
                        GenerarOrdenCompraProveedor();
                    }
                }
                else
                {
                    Avisar("Stock insuficiente. Existencia actual: " + this.existencia + ", solicitado: " + cantidad + ".");
                }
            }
        }

        private void GenerarOrdenCompraProveedor()
        {
            Avisar(">> Generando orden de compra al proveedor para el articulo " + this.codigo + " (" + this.descripcion + ")...");
            Avisar(">> Orden de compra enviada al proveedor.");
        }
    }
}
