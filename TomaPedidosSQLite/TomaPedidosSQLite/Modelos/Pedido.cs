using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TomaPedidosSQLite.Modelos
{
    public class Pedido
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int NumeroPedido {  get; set; }
        public DateTime HoraPedido { get; set; }
        public string Estado {  get; set; }
        public double Total { get; set; }
    }
}
