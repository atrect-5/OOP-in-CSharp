
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

namespace _5._1_Dependency_properties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declarando mi nueva dependency property

        // Se define la propiedad 
        public int MiPropiedad
        {
            get { return (int)GetValue(dependencyProperty); }
            set { SetValue(dependencyProperty, value); }
        }
        // Se indican las especificaciones de mi propiedad (name, type, owner, metadata)
        public static readonly DependencyProperty dependencyProperty =
            DependencyProperty.Register("MiPropiedad", typeof(int), typeof (MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
        }
    }

    // Nueva clase para crear una property
    public class CustomButton : Button
    {
        public bool ChangeBackground
        {
            get { return (bool)GetValue(ChangeBackgroundProperty); }
            set { SetValue(ChangeBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ChangeBackgroundProperty =
            DependencyProperty.Register("ChangeBackground", typeof(bool), typeof(CustomButton), new PropertyMetadata(false));

    }
}