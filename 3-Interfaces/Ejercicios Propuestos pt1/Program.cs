using Ejercicios_Propuestos_pt1.Clases;

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
         * Un zoológico le pide un programa de consola en C#, en el cual le solicita una clase padre Animal 
         * el cual se debe implementar una interfaz que solicite los siguientes métodos: 
         *  -Caminar
         *  -Dormir
         *  -Comer
         * El programa debe contener las clases Gato, Caballo y Perro que estas a su vez heredan de Animal. 
         * La clase Animal debe solicitar el nombre del animal.
         */
        WriteWithColor("\n--------------------Ejercicio 1--------------------", ConsoleColor.DarkGray);

        WriteWithColor("-Gato: ", ConsoleColor.Green);
        Cat cat = new("Tom");

        cat.ShowData();
        cat.Walk();
        cat.Eat();
        cat.Sleep();

        WriteWithColor("-Perro: ", ConsoleColor.Green);
        Dog dog = new("Firlais");

        dog.ShowData();
        dog.Walk();
        dog.Eat();
        dog.Sleep();

        WriteWithColor("-Caballo: ", ConsoleColor.Green);
        Horse horse = new("Spirit");

        horse.ShowData();
        horse.Walk();
        horse.Eat();
        horse.Sleep();


        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}