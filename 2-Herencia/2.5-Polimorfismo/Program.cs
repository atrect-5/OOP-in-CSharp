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
         * Sobreescribiendo metodos de la clase empleado para registrar asistencia.
         */
        WriteWithColor("\n--------------------Ejemplo 1--------------------", ConsoleColor.DarkGray);

        WriteWithColor("-Tecnico:", ConsoleColor.Green);
        Tecnico tecnico = new("Alejandro", "Gonzalez", 1234);
        tecnico.RegistrarAsistencia();
        tecnico.RecibirPago();

        WriteWithColor("-Secretario:", ConsoleColor.Green);
        Secretario secretario = new("Javier", "Gomez", 2145);
        secretario.RegistrarAsistencia();
        secretario.RecibirPago();

        /*
         * Ejemplo 2:
         * Sobreescribiendo metodos de la clase materia para calificar a los alumnos.
         */
        WriteWithColor("\n\n--------------------Ejemplo 2--------------------", ConsoleColor.DarkGray);

        Matematicas matematicas = new("Alejandro", 12);
        Musica musica = new("Jose", 14);
        Lenguaje lenguaje = new("Alberto", 15);

        matematicas.MostrarInformacion();
        matematicas.Calificacion();
        
        musica.MostrarInformacion();
        musica.Calificacion();

        lenguaje.MostrarInformacion();
        lenguaje.Calificacion();

        WriteWithColor("\n\nPress any key to exit...", ConsoleColor.DarkGray);
        Console.ReadKey();
    }
}


#region Calses de empleado

class Empleado(string nombre, string apellido, int clave)
{
    // Al agregar protected, se puede acceder a los atributos desde clases hijas.
    protected string? nombre = nombre, apellido = apellido;
    int clave = clave;

    // Metodo para obtener la informacion del empleado
    public void MostrarInformacion()
    {
        Console.WriteLine($"   -Clave: {this.clave}\n   -Empleado: {this.nombre} {this.apellido}");
    }

    // Metodo para registrar asistencia del empleado
    public void RegistrarAsistencia () 
    { 
        Program.WriteWithColor($"Se registro la asistencia de {this.nombre} {this.apellido}", ConsoleColor.DarkYellow);
    }

    // Metodo para recibir el pago
    // Al usar la palabra 'virtual' se indica que este método puede ser redefinido por una clase que herede de esta
    public virtual void RecibirPago () 
    {
        Program.WriteWithColor($"Se le pago al empleado {this.nombre} {this.apellido}", ConsoleColor.DarkYellow);
    }
}

class Tecnico(string nombre, string apellido, int clave) : Empleado(nombre, apellido, clave)
{
    public void Analizar()
    {
        Program.WriteWithColor("El tectico esta analizando...", ConsoleColor.DarkBlue);
    }

    // Metodo para registrar asistencia del empleado
    // Al usar la palabra new, se refiere a que no hay sobrecarga de metodos, si no, polimorfismo
    // Dependiendo de que objeto llame a la funcion, es la que se ejecutara (Empleado o Tecnico)
    new public void RegistrarAsistencia()
    {
        Program.WriteWithColor($"Se registro la asistencia del tecnico {this.nombre} {this.apellido} a las {DateTime.Now:HH:mm}", ConsoleColor.DarkYellow);
    }
}
class Secretario(string nombre, string apellido, int clave) : Empleado(nombre, apellido, clave)
{
    public void Archivar()
    {
        Program.WriteWithColor("La secretaria esta archivando documentos...", ConsoleColor.DarkBlue);
    }

    // Metodo para registrar el pago
    // Al usar la palabra 'override' Se indica que se esta sobreescribiendo un metodo de la clase padre
    public override void RecibirPago()
    {
        Program.WriteWithColor($"Se le pago al secretario {this.nombre} {this.apellido} a las {DateTime.Now:HH:mm}", ConsoleColor.DarkYellow);
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
        Program.WriteWithColor($"Materia: {this.nombre}", ConsoleColor.Green);
        Console.WriteLine($"   -Maestro: {this.maestro}\n   -Cantidad de estudiantes: {this.estudiantes}");
    }

    // Metodo que muestra cuanto vale cada uno de los 3 parciales para la calificacion final del semestre.
    public virtual void Calificacion()
    {
        Console.WriteLine("   -Parcial 1: 33% | Parcial 2: 33% | Parcial 3: 34%");
    }
}

class Matematicas (string maestro, int estudiantes) : Materia("Matematicas", maestro, estudiantes) 
{
    // Metodo que muestra cuanto vale cada uno de los 3 parciales para la calificacion final del semestre.
    // Sobreescribiendo el metodo con new (Ocultar comportamiento heredado)(Usa el tipo de la referencia)
    new public void Calificacion()
    {
        Console.WriteLine("   -Parcial 1: 25% | Parcial 2: 35% | Parcial 3: 40%");
    }
}

class Musica (string maestro, int estudiantes) : Materia("Musica", maestro, estudiantes) 
{
    // Metodo que muestra cuanto vale cada uno de los 3 parciales para la calificacion final del semestre.
    // Agregando al metodo con override (Reemplazar comportamiento)(Usa el tipo real del objeto)
    public override void Calificacion() 
    {
        base.Calificacion(); // Se llama al metodo del padre, para agregarle alguna funcion
        Program.WriteWithColor("Se requiere un instrumento para pasar la clase", ConsoleColor.DarkYellow);
    }
}

class Lenguaje(string maestro, int estudiantes) : Materia("Lenguaje", maestro, estudiantes)
{
    // Metodo que muestra cuanto vale cada uno de los 3 parciales para la calificacion final del semestre.
    // Sobreescribiendo el metodo con override (Reemplazar comportamiento)(Usa el tipo real del objeto)
    public override void Calificacion()
    {
        Console.WriteLine("   -Parcial 1: 15% | Parcial 2: 35% | Parcial 3: 50%");
        Program.WriteWithColor("Debe hablar otro idioma para pasar la clase", ConsoleColor.DarkYellow);
    }
}

#endregion