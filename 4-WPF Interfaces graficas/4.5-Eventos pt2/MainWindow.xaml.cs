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

namespace _4._5_Eventos_pt2
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

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Controla la visibilidad del placeHolder del password
            passwordPlaceholder.Visibility = string.IsNullOrEmpty(PswPassword.Password)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUser.Text))
            {
                MessageBox.Show("Por favor, ingrese un usuario.", "Error");
                TxtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PswPassword.Password))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error");
                PswPassword.Focus();
                return;
            }

            if (PswPassword.Password == "admin123" && TxtUser.Text == "alex1123.nel")
            {
                MainAppWindow mainApp = new();
                mainApp.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error");
                PswPassword.Clear();
                PswPassword.Focus();
            }

        }
    }
}