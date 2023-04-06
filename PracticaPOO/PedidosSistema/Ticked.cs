using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.PedidosSistema
{
    internal class Ticked
    {
        private Pedido _pedido;

        public Ticked(Pedido pedido)
        {
            _pedido = pedido;
        }

        public string MostrarPedido()
        {
            return $"Nombre del cliente: {_pedido.NombreCiente} direccion cliente: {_pedido.DireccionCliente}" +
                    $"Nombre del producto: {_pedido.NombreProducto} costo: {_pedido.PrecioProducto} fecha de la compra: {_pedido.Fecha}";
        }
    }
}
