internal class Program
{
    private static void Main(string[] args)
    {
        AnotherClass anotherClass = new(); // Se crea una instancia de AnotherClass
        anotherClass.HelloWorld(); // Se llama al método HelloWorld de AnotherClass

        AnotherClass anotherClass2 = new AnotherClass(); // Se crea otra instancia de AnotherClass
        anotherClass2.HelloWorld(); // Se llama al método HelloWorld de la segunda instancia

        //anotherClass2.text = "Otro texto"; // AnotherClass.text es privado, por lo que no se puede acceder directamente a él desde fuera de la clase


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}


// Se crea una nueva clase llamada AnotherClass
class AnotherClass
{
    // private -> hace referencia a la encapsulación de clases en C# (no puede ser accedida desde fuera de la clase)
    private string text = "Hello, World! from AnotherClass"; // Se define una variable de instancia

    // Esta clase tiene un método llamado HelloWorld que imprime un mensaje en la consola
    // void -> hace referencia al tipo de retorno del método (no retorna nada)
    // public -> hace referencia a la encapsulación de clases en C# (desde donde puede ser accedido)
    public void HelloWorld()
    {
        Console.WriteLine(text);
    }
}