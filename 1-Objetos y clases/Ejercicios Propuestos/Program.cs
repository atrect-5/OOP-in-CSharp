internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejercicio 1:
         * Una empresa le solicita a usted como programador en C# que elabore un programa en consola
         * que sea capaz de recibir registro de algún empleado y que pueda registrar su asistencia. 
         * El programa debe permitir ingresar Clave, Nombre y edad del Empleado. El programa debe dar un 
         * informe sobre la asistencia del empleado
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n--------------------Ejercicio 1--------------------");
        Console.ResetColor();
        
        Empleado[] empleados = 
        [
             new Empleado("12345", "Juan Pérez", 30),
             new Empleado("543211", "Alejandro Gonzalez", 24),
             new Empleado("45789", "Jessica Avelar", 26)
        ];
        empleados[1].RegistrarAsistencia();
        empleados[2].RegistrarAsistencia();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Informe de Asistencia de Empleados:");
        foreach (var empleado in empleados)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Empleado:");
            Console.ResetColor();
            empleado.MostrarInformacion();
        }

        /*
         * Ejercicio 2:
         * Un salón de belleza solicita un programa en consola que pueda ir registrando los cosméticos 
         * que va utilizando. El programa debe ser capaz de recibir Nombre del cosmético utilizado, unidad 
         * de medida y cantidad utilizada. El programa debe dar un informe sobre 3 cosméticos.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 2--------------------");
        Console.ResetColor();

        Cosmetico[] cosmeticos =
        [
            new Cosmetico("Shampoo", "ml", 250),
            new Cosmetico("Acondicionador", "ml", 200),
            new Cosmetico("Crema para peinar", "g", 150),
        ];
        cosmeticos[0].AumentarCantidad(50);
        cosmeticos[1].AumentarCantidad(30);
        cosmeticos[2].AumentarCantidad(20);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Informe de Cosméticos Utilizados:");
        Console.ResetColor();
        foreach (var cosmetico in cosmeticos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cosmético:");
            Console.ResetColor();
            cosmetico.MostrarInformacion();
        }


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}

// Clase para registrar un empleado
class Empleado(string clave, string nombre, int edad)
{
    string? nombre = nombre, clave = clave;
    int edad = edad;
    bool asistenciaRegistrada = false;

    // Método para mostrar la información del empleado
    public void MostrarInformacion()
    {
        Console.WriteLine($"   -Clave: {clave}\n   -Empleado: {nombre}\n   -Edad: {edad}");
        Console.WriteLine(asistenciaRegistrada ? "   -Asistencia: Registrada" : "   -Asistencia: No registrada");
    }

    // Metodo para registrar asistencia 
    public void RegistrarAsistencia()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Asistencia registrada para el empleado: {nombre}");
        Console.ResetColor();
        asistenciaRegistrada = true;
    }
}


// Clase para registrar un cosmético utilizado
class Cosmetico(string nombre, string unidadMedida, double cantidad)
{
    string? nombre = nombre, unidadMedida = unidadMedida;
    double cantidad = cantidad;

    // Método para mostrar la información del cosmético
    public void MostrarInformacion()
    {
        Console.WriteLine($"   -Cosmético: {nombre}\n   -Unidad de Medida: {unidadMedida}\n   -Cantidad Utilizada: {cantidad}");
    }

    // Metodo para aumentar la cantidad utilizada
    public void AumentarCantidad(double cantidadAdicional)
    {
        cantidad += cantidadAdicional;
    }
}