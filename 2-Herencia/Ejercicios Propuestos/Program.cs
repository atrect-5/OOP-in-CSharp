internal class Program
{
    // Metodo para escribir un mensaje con un color específico
    public static void WriteWithColor(string mensaje, ConsoleColor color)
    {
        var colorOriginal = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(mensaje);
        Console.ForegroundColor = colorOriginal;
    }

    private static void Main(string[] args)
    {
        /*
         * Ejercicio 1:
         * Una ferretería le solicita a usted un programa en C#, en el que debe tener una 
         * clase padre que será herramienta y recibirá los siguientes argumentos:
         * 
         *  -Nombre de la herramienta
         *  -Precio
         *  
         *  Las clases hijas serán: Martillo, Cinta Métrica y Destornillador, todas deben tener un método 
         *  propio según la función de cada herramienta en el campo. La clase padre deberá ser capaz de 
         *  imprimir los argumentos recibidos.
         */
        WriteWithColor("\n--------------------Ejercicio 1--------------------", ConsoleColor.DarkGray);

        Martillo martillo = new(55);
        CintaMetrica cintaMetrica = new(45);
        Destornillador destornillador = new(105);

        martillo.MostrarInformacion();
        martillo.Funcion();

        cintaMetrica.MostrarInformacion();
        cintaMetrica.Funcion();

        destornillador.MostrarInformacion();
        destornillador.Funcion();


        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}

// Se declara la clase Herramienta
class Herramienta(string nombre, double precio)
{
    string? nombre = nombre;
    double precio = precio;

    // Metodo para obtener la informacion de la herramienta
    public void MostrarInformacion()
    {
        Program.WriteWithColor($"Herramienta: {this.nombre}", ConsoleColor.Green);
        Program.WriteWithColor($"   -Precio: {this.precio:C2}", ConsoleColor.DarkCyan);
    }

    // Metodo que indica que la herramienta esta funcionando 
    public virtual void Funcion()
    {
        Program.WriteWithColor("La herramienta esta funcionando...", ConsoleColor.DarkYellow);
    }
}

// Se declara la clase Martillo
class Martillo(double precio) : Herramienta("Martillo", precio)
{
    public override void Funcion() =>
        Program.WriteWithColor("El martillo esta martillando...", ConsoleColor.DarkYellow);
}

// Se declara la clase Cinta Metrica
class CintaMetrica(double precio) : Herramienta("Cinta Metrica", precio)
{
    public override void Funcion() =>
        Program.WriteWithColor("La cinta metrica esta midiendo...", ConsoleColor.DarkYellow);
}

// se declara la clase Destornillador
class Destornillador(double precio) : Herramienta("Destornillador", precio)
{
    public override void Funcion() =>
        Program.WriteWithColor("El destornillador esta desatornillando...", ConsoleColor.DarkYellow);
}