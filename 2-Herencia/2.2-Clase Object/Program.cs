internal class Program
{
    // Metodo para escribir un mensaje con un color específico
    static void WriteWithColor(string mensaje, ConsoleColor color)
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
         * Usamos metodos de la clase object (Siempre se hereda de esta, aunque no se muestre)
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);
        Carro carro = new(), carro2 = new();
        Barco barco = new();

        WriteWithColor("Metodo 'Equals' de la clase 'Object'", ConsoleColor.Cyan);
        Console.WriteLine($"carro.Equals(barco): {carro.Equals(barco)}"); // false
        Console.WriteLine($"carro.Equals(carro): {carro.Equals(carro)}"); // true
        Console.WriteLine($"carro.Equals(carro2): {carro.Equals(carro2)}"); // false


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