using Ejercicios_Propuestos_pt2.Clases;

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
         * Ejercicio 2:
         * Un predio le pide un programa de consola en C#, en el cual le solicita una clase padre 
         * Vehículo el cual se debe implementar una interfaz que solicite los siguientes métodos: 
         *  -Arrancar
         *  -Acelerar
         *  -Frenar
         * El programa debe contener las clases Carro, Barco y Motocicleta que estas a su vez heredan de Vehículo. 
         */
        WriteWithColor("\n--------------------Ejercicio 2--------------------", ConsoleColor.DarkGray);

        WriteWithColor("-Carro: ", ConsoleColor.Green);
        Car car = new("Ford");

        car.ShowData();
        car.Start();
        car.Accelerate();
        car.Brake();

        WriteWithColor("-Barco: ", ConsoleColor.Green);
        Boat boat = new("Black Pearl");

        boat.ShowData();
        boat.Start();
        boat.Accelerate();
        boat.Brake();

        WriteWithColor("-Motocicleta: ", ConsoleColor.Green);
        Motorcycle motorcycle = new("Susuki");

        motorcycle.ShowData();
        motorcycle.Start();
        motorcycle.Accelerate();
        motorcycle.Brake();

        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}