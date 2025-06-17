using _3._1_Interfaces;

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
         * Implementamos interfaces en la clase Carro (Que tambien hereda de vehiculo)
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);

        WriteWithColor("-Carro", ConsoleColor.Green);
        Carro carro = new("Rojo", "Ford", 2500);
        Console.WriteLine($"   -Color: {carro.Color()}");
        Console.WriteLine($"   -Motor: {carro.Motor()}");
        Console.WriteLine($"   -Ruedas: {carro.Ruedas()}");
        Console.WriteLine($"   -Marca: {carro.Marca()}");
        carro.Encender();

        WriteWithColor("-Barco", ConsoleColor.Green);
        Barco barco = new("Negro", "Black pearl", 6000);
        Console.WriteLine($"   -Color: {barco.Color()}");
        Console.WriteLine($"   -Motor: {barco.Motor()}");
        Console.WriteLine($"   -Ruedas: {barco.Ruedas()}");
        Console.WriteLine($"   -Marca: {barco.Marca()}");
        barco.Encender();


        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}