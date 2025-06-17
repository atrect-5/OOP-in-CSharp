using _3._3_Interfaces_3.Clases;
using _3._3_Interfaces_3.Interfaces;

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
         * Ejemplo 1:
         * Un sistema que guarda los datos de un correo usando interfaces
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);

        Mensaje mensaje = new("destino@gmail.com", "alex1123.nel@gmail.com", "Hello, world!");
        INuevoMensaje nuevoMensaje = mensaje;

        WriteWithColor("Datos del mensaje: ", ConsoleColor.Green);
        Console.WriteLine($"   -Destinatario: {mensaje.Destinatario()}");
        Console.WriteLine($"   -Remitente: {mensaje.Remitente()}");
        Console.WriteLine($"   -Mensaje: {nuevoMensaje.Mensaje()}"); // Debido a que la clase se llama igual que el metodo, instanciamos la interface para usar el metodo

        Mensaje mensaje2 = new("otro@otro.com", "pip@pip.com", "Buenos dias senor sol");
        INuevoMensaje nuevoMensaje2 = mensaje2;

        WriteWithColor("Datos del mensaje 2: ", ConsoleColor.Green);
        Console.WriteLine($"   -Destinatario: {mensaje2.Destinatario()}");
        Console.WriteLine($"   -Remitente: {mensaje2.Remitente()}");
        Console.WriteLine($"   -Mensaje: {nuevoMensaje2.Mensaje()}");

        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}