
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
         * Explicacion de herencia
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);
        Carro carro = new();
        Barco barco = new();
        Moto moto = new();

        WriteWithColor("-Carro:", ConsoleColor.Green);
        carro.AbrirPuertas();
        carro.Encender();
        carro.Acelerar();
        carro.Frenar();

        WriteWithColor("-Barco:", ConsoleColor.Green);
        barco.Encender();
        barco.LevantarAncla();
        barco.Acelerar();
        barco.Frenar();

        WriteWithColor("-Moto:", ConsoleColor.Green);
        moto.Encender();
        moto.LevantarPata();
        moto.Acelerar();
        moto.Frenar();

        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}

// Declaramos la clase padre Vehiculo
class Vehiculo
{
    // Metodo para encender el vehículo
    public void Encender()
    {
        Console.WriteLine("El vehículo está encendido.");
    }

    // Metodo para acelerar el vehiculo
    public void Acelerar()
    {
        Console.WriteLine("El vehículo está acelerando.");
    }

    // Metodo para frenar el vehiculo
    public void Frenar()
    {
        Console.WriteLine("El vehículo está frenando.");
    }
}

// Declaramos la clase hija Carro
class Carro : Vehiculo
{
    public void AbrirPuertas ()
    {
        Console.WriteLine("Se abrieron las puertas del carro");
    }
}

// Declaramos la clase hija Barco
class Barco : Vehiculo
{
    public void LevantarAncla ()
    {
        Console.WriteLine("Se levanto el ancla del barco");
    }
}

// Declaramos la clase hija Moto
class Moto : Vehiculo
{
    public void LevantarPata()
    {
        Console.WriteLine("Se levanto la pata de la moto");
    }
}