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
using System.Windows.Shapes;

namespace Ejercicios_Propuestos
{
    /// <summary>
    /// Interaction logic for Resultado.xaml
    /// </summary>
    public partial class Resultado : Window
    {
        public Resultado(string? message)
        {
            InitializeComponent();
            TxtResultado.Text = message;
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();
        }
    }
}
