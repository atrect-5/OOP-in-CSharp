using _3._2_Interfaces_2.Clases;
using _3._2_Interfaces_2.Interfaces;

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
         * Se crean clases para simular recetas de comida
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);

        WriteWithColor("Pollo a las brasas", ConsoleColor.Green);
        
        PolloBrasas polloBrasas = new();
         
        polloBrasas.ComprarIngredientes();
        polloBrasas.LimpiarUtencilios();
        polloBrasas.LimpiarIngredientes();
        polloBrasas.EncenderFuego();
        polloBrasas.CocinarPollo();

        WriteWithColor("Nueva receta (interface)", ConsoleColor.Green);

        INuevaReceta nuevaReceta = polloBrasas;

        nuevaReceta.LimpiarIngredientes();
        nuevaReceta.LimpiarUtencilios();


        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}