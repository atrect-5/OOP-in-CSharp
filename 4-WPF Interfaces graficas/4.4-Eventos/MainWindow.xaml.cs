using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4._4_Eventos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Validación de los números ingresados
            if (!int.TryParse(txtNumero1.Text, out int numero1))
            {
                MessageBox.Show("El primer número no es válido.");
                return;
            }

            if (!int.TryParse(txtNumero2.Text, out int numero2))
            {
                MessageBox.Show("El segundo número no es válido.");
                return;
            }

            // Mostrar la suma de los números
            MessageBox.Show($"La suma de {numero1} + {numero2} = {numero1 + numero2}");
        }
    }
}