using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidosSQLite.Modelos
{
    class PedidoProducto
    {
        [ForeignKey(name: "IdPedido")]
        public int IdPedido { get; set; }
        [ForeignKey(name: "IdProducto")]
        public int IdProducto { get; set; }

        public int Cantidad { get; set; }
        public double PrecioTotal { get; set; }
    }
}
