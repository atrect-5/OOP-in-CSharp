using System.Security.Cryptography.X509Certificates;

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
         * Explicacion
         * Crear una instancia de un elemento hijo, este llama al constructor del padre por medio de base()
         * Para esto, creamos clases que representan vehiculos (Carro, moto, barco)
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);

        WriteWithColor("-Carro:", ConsoleColor.Cyan);
        Carro carro = new("Chevrolet");

        carro.ImprimirMarca();

        WriteWithColor("-Barco:", ConsoleColor.Cyan);
        Barco barco = new("BMW");

        barco.ImprimirMarca();

        WriteWithColor("-Moto:", ConsoleColor.Cyan);
        Moto moto = new("Susuki");

        moto.ImprimirMarca();

        /*
         * Ejemplo 2:
         * Se crean clases e instancias que representan empleados (Tecnico, Secretaria, Conserje)
         */
        WriteWithColor("\n\n--------------------Ejemplo 2--------------------", ConsoleColor.DarkGray);

        Tecnico tecnico = new("Alejandro", "Gonzalez", 1234);
        Secretario secretaria = new("Jessica", "Avelar", 4321);
        Conserje conserje = new("Juan", "Perez", 2451);

        WriteWithColor("Informacion de los empleados", ConsoleColor.Green);
        WriteWithColor("-Tecnico: ", ConsoleColor.Cyan);
        tecnico.MostrarInformacion();
        tecnico.Analizar();

        WriteWithColor("-Secretaria: ", ConsoleColor.Cyan);
        secretaria.MostrarInformacion();
        secretaria.Archivar();

        WriteWithColor("-Conserje: ", ConsoleColor.Cyan);
        conserje.MostrarInformacion();
        conserje.Limpiar();

        /*
         * Ejemplo 3:
         * Se crean clases e instancias que representan materias (Matematicas, Musica, Lenguaje)
         */
        WriteWithColor("\n\n--------------------Ejemplo 3--------------------", ConsoleColor.DarkGray);

        Matematicas maematicas = new("Alejandro Gonzalez", 40);
        Musica musica = new("Juan Perez", 38);
        Lenguaje lenguaje = new("Jessica Avelar", 25);

        WriteWithColor("Informacion de las materias", ConsoleColor.Green);
        maematicas.MostrarInformacion();

        musica.MostrarInformacion();

        lenguaje.MostrarInformacion();


        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}

#region Clases de Vehiculos

// Declaramos la clase padre Vehiculo
class Vehiculo (string marca)
{

    public string? marca = marca;
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

    // Metodo para mostrar la marca del vehiculo
    public void ImprimirMarca()
    {
        Console.WriteLine($"La marca del vehiculo es: {this.marca}");
    }
}

// Declaramos la clase hija Carro
class Carro(string marca) : Vehiculo(marca) // Forma mas rapida de llamar al constructor padre
{
    public void AbrirPuertas ()
    {
        Console.WriteLine("Se abrieron las puertas del carro");
    }
}

// Declaramos la clase hija Barco
class Barco : Vehiculo
{
    // Declaramos el constructor llamando al constructor padre
    public Barco(string marca) : base (marca) {}
    public void LevantarAncla ()
    {
        Console.WriteLine("Se levanto el ancla del barco");
    }
}

// Declaramos la clase hija Moto
class Moto : Vehiculo
{
    public Moto (string marca) : base (marca) {}
    public void LevantarPata()
    {
        Console.WriteLine("Se levanto la pata de la moto");
    }
}

#endregion

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

#region Clases de Escuela

class Materia (string nombre, string maestro, int estudiantes)
{ 
    string? nombre = nombre;
    string? maestro = maestro;
    int estudiantes = estudiantes;
    
    // Metodo para mostrar la informacion de la materia
    public void MostrarInformacion ()
    {
        Program.WriteWithColor($"Materia: {this.nombre}", ConsoleColor.Cyan);
        Console.WriteLine($"   -Maestro: {this.maestro}\n   -Cantidad de estudiantes: {this.estudiantes}");
    }
}

class Matematicas (string maestro, int estudiantes) : Materia("Matematicas", maestro, estudiantes) {}

class Musica (string maestro, int estudiantes) : Materia("Musica", maestro, estudiantes) {}

class Lenguaje(string maestro, int estudiantes) : Materia("Lenguaje", maestro, estudiantes) { }

#endregion