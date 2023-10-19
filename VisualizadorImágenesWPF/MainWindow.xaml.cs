using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace VisualizadorImágenesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string rutaArchivo = "";
        private string[] rutasRecientes = Array.Empty<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void abrir_Click(object sender, RoutedEventArgs e)
        {
        }

        private void abrirReciente_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItemRuta = new MenuItem();

            rutasRecientes.Append("Patata");

            menuItemRuta.Header = rutasRecientes[0];
            menuRecientes.Items.Add(menuItemRuta);
        }
    }
}
