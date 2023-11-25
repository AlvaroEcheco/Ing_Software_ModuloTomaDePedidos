using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TomaPedidosSQLite.Modelos;

namespace TomaPedidosSQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Pedido> pedidos = ObtenerPedidos(); 
            lstView.ItemsSource = pedidos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            if (button.Background == Brushes.Green)
            {
                button.Background = Brushes.Red;
            }
            else
            {
                button.Background = Brushes.Green;
            }
        }

        private List<Pedido> ObtenerPedidos()
        {
            

            return new List<Pedido>
            {
                new Pedido { NumeroPedido = 1, RazonSocial = "Cliente A", Ci = "12345", Estado = "Pendiente", Total = 100.50 },
                new Pedido { NumeroPedido = 2, RazonSocial = "Cliente B", Ci = "67890", Estado = "Entregado", Total = 75.20 },
                
            };
        }
    }
}
