using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.PedidosSistema
{
    internal class Ejecucion
    {
        void test()
        {
            Pedido pedido = new Pedido("Alex Jose", "PC GAMER", "Clinica don bosco 1C N", 100, DateTime.Now);

            Ticked ticked = new Ticked(pedido);

            Console.WriteLine(ticked.MostrarPedido());
        }
    }
}
