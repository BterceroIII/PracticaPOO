using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.PedidosSistema
{
    internal class Pedido
    {
        public string NombreCiente { get; set; }
        public string NombreProducto { get; set; }
        public string DireccionCliente { get; set; }
        public int PrecioProducto { get; set; }
        public DateTime Fecha { get; set; }

        public Pedido(string nombreCiente, string nombreProducto, string direccionCliente, int precioProducto, DateTime fecha)
        {
            NombreCiente = nombreCiente;
            NombreProducto = nombreProducto;
            DireccionCliente = direccionCliente;
            PrecioProducto = precioProducto;
            Fecha = fecha;
        }
    }
}
