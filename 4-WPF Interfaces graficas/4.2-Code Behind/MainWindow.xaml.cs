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
using System.Windows.Shell;

namespace _4._2_Code_Behind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new();
            
            Button button = new();
            TextBlock textBlock = new();
            ComboBox comboBox = new();

            textBlock.Text = "Code Behind se refiere a agregar los componentes por medio de codigo C#";
            textBlock.Foreground = Brushes.White;
            textBlock.FontFamily = new("MV Boli");
            textBlock.Margin = new Thickness(0, 10, 0, 0);
            textBlock.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock.VerticalAlignment = VerticalAlignment.Top;

            button.Width = 150;
            button.Height = 35;
            button.Content = "Un boton";
            button.Foreground = Brushes.White;
            button.FontSize = 13;
            button.FontFamily = new("MV Boli");
            button.Margin = new Thickness(0, 0, 0, 70);
            button.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 88, 88, 88));
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.VerticalAlignment = VerticalAlignment.Bottom;
            button.Cursor = Cursors.Hand;

            // Crear el pincel de degradado
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0.5, 0);
            gradientBrush.EndPoint = new Point(0.5, 1);

            // Agregar los puntos de color
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(255, 39, 61, 103), 1));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(255, 65, 115, 209), 0.32));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(255, 39, 61, 103), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(255, 65, 115, 209), 0.669));

            // Asignar el pincel de degradado al fondo del botón y del grid
            button.Background = gradientBrush;
            grid.Background = gradientBrush;

            comboBox.Width = 275;
            comboBox.Height = 20;
            comboBox.Margin = new Thickness(0, 0, 0, 142);
            comboBox.HorizontalAlignment = HorizontalAlignment.Center;
            comboBox.VerticalAlignment = VerticalAlignment.Bottom;
            
            comboBox.Resources.Add(typeof(ComboBoxItem), new Style(typeof(ComboBoxItem))
            {
                Setters =
                {
                    new Setter(ComboBoxItem.ForegroundProperty, Brushes.White),
                    new Setter(ComboBoxItem.BackgroundProperty, new SolidColorBrush(Color.FromRgb(48,48,48))),
                    new Setter(ComboBoxItem.BorderBrushProperty, new SolidColorBrush(Color.FromRgb(48,48,48))),
                }
            });

            ComboBoxItem item = new()
            {
                Content = "Selecciona el metodo de pago",
                IsSelected = true,
                IsEnabled = false
            };
            ComboBoxItem item1 = new() { Content = "Efectivo" };
            ComboBoxItem item2 = new () { Content = "Transferencia" };
            ComboBoxItem item3 = new () { Content = "Tarjeta" };

            comboBox.Items.Add(item);
            comboBox.Items.Add(item1);
            comboBox.Items.Add(item2);
            comboBox.Items.Add(item3);

            // Se agregan los componentes al Grid
            grid.Children.Add(comboBox);
            grid.Children.Add(textBlock); 
            grid.Children.Add(button); 
            this.Content = grid; // Se agrega el Grid como contenido de la ventana
        }
    }
}