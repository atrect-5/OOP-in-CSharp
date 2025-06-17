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
        // Sustitucion
        // Es siempre un??

        // Un conserje es siempre un empleado? si
        Empleado empleadoConserje = new Conserje("Alejandro", "Gonzlaez", 1234);
        empleadoConserje.MostrarInformacion(); // Funciona
        //empleado.Limpiar(); // Error, no existe en 'Empleado'

        // Un empleado es siempre un conserje? no
        //Conserje conserje = new Empleado("Juan", "Perez", 1452); // Error

        // Un tecnico es siempre un empleado? si
        Empleado empleadoTecnico = new Tecnico("Carlos", "Lopez", 5678);
        empleadoTecnico.MostrarInformacion(); // Funciona
        //empleadoTecnico.Analizar(); // Error, no existe en 'Empleado'

        // Un secretario es siempre un empleado? si
        Empleado empleadoSecretario = new Secretario("Maria", "Ramirez", 9101);
        empleadoSecretario.MostrarInformacion(); // Funciona
        //empleadoSecretario.Archivar(); // Error, no existe en 'Empleado'



        Secretario secretario = new("Gabriel", "Lopez", 4568);
        Empleado empleado = new("No", "name", 0);

        empleado = secretario;
        empleado.MostrarInformacion();
        /*
            -Clave: 4568
            -Empleado: Gabriel Lopez
        */
        //empleado.Archivar(); // Error, no existe en 'Empleado'

        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}

#region Calses de empleado

class Empleado(string nombre, string apellido, int clave)
{
    string? nombre = nombre, apellido = apellido;
    int clave = clave;

    // Metodo para obtener la informacion del empleado
    public void MostrarInformacion()
    {
        Console.WriteLine($"   -Clave: {this.clave}\n   -Empleado: {this.nombre} {this.apellido}");
    }
}

class Tecnico(string nombre, string apellido, int clave) : Empleado(nombre, apellido, clave)
{
    public void Analizar()
    {
        Program.WriteWithColor("El tectico esta analizando...", ConsoleColor.DarkBlue);
    }
}
class Secretario(string nombre, string apellido, int clave) : Empleado(nombre, apellido, clave)
{
    public void Archivar()
    {
        Program.WriteWithColor("La secretaria esta archivando documentos...", ConsoleColor.DarkBlue);
    }
}

class Conserje(string nombre, string apellido, int clave) : Empleado(nombre, apellido, clave)
{
    public void Limpiar()
    {
        Program.WriteWithColor("El conserje esta limpiando...", ConsoleColor.DarkBlue);
    }
}

#endregion