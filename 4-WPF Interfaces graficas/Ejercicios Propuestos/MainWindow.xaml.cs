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

namespace Ejercicios_Propuestos
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
        // Funcion que verifica campos validos
        private bool TryGetInputValues(out double numero1, out double numero2)
        {
            numero2 = 0;

            if (!double.TryParse(TxtNumero1.Text, out numero1) || !double.TryParse(TxtNumero2.Text, out numero2))
            {
                MessageBox.Show("Ingrese numeros validos");
                TxtNumero1.Clear();
                TxtNumero2.Clear();
                TxtNumero1.Focus();
                return false;
            }
            return true;
        }

        // Funcion que abre la siguiente ventana
        private void GoToResulWindow(string? message)
        {
            Resultado resultado = new(message);
            resultado.Show();
            this.Close();
        }

        // Funcion que realiza la suma
        private void Sumar(object sender, RoutedEventArgs e)
        {
            if (TryGetInputValues(out double numero1, out double numero2))
            {
                GoToResulWindow($"La Suma de {numero1} + {numero2} = {numero1 + numero2}");
            }
        }
        // Funcion que realiza la resta
        private void Restar(object sender, RoutedEventArgs e)
        {
            if (TryGetInputValues(out double numero1, out double numero2))
            {
                GoToResulWindow($"La Resta de {numero1} - {numero2} = {numero1 - numero2}");
            }
        }
        // Funcion que realiza la multiplicacion
        private void Multiplicar(object sender, RoutedEventArgs e)
        {
            if (TryGetInputValues(out double numero1, out double numero2))
            {
                GoToResulWindow($"La Multiplicacion de {numero1} x {numero2} = {numero1 * numero2}");
            }
        }
        // Funcion que realiza la division
        private void Dividir(object sender, RoutedEventArgs e)
        {
            if (TryGetInputValues(out double numero1, out double numero2))
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("No se puede dividir por cero.");
                    return;
                }
                GoToResulWindow($"La División de {numero1} / {numero2} = {numero1 / numero2}");
            }
        }
    }
}