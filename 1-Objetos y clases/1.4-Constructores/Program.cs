internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Sobrecarga de constructores guardando informacion de vehiculos
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        // Se instancia la clase (crea objeto)
        Carro carro1 = new(puertas: 4, color: "Rojo", motor: 1400), carro2 = new();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-Datos del carro 1: ");
        Console.ResetColor();

        Console.WriteLine(carro1.getInfo());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-Datos del carro 2: ");
        Console.ResetColor();

        Console.WriteLine(carro2.getInfo());
        /*
         * Ejemplo 2:
         * Se almacena la cantidad de personas en un autobus, agregando y eliminando segun suben y bajan
         * Tenemos que indicar con cuantas personas se inicio y con cuantas se finalizo
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        BusViaje viaje1 = new(15), viaje2 = new(30);

        viaje1.AgregarPersonas(15);
        viaje1.EliminarPersonas(25);
        viaje1.AgregarPersonas(10);
        viaje1.EliminarPersonas(14);

        viaje2.AgregarPersonas(45);
        viaje2.AgregarPersonas(10);
        viaje2.EliminarPersonas(70);
        viaje2.EliminarPersonas(9);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-Datos del viaje 1: ");
        Console.ResetColor();
        Console.WriteLine(viaje1.getInfoViaje());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-Datos del viaje 2: ");
        Console.ResetColor();
        Console.WriteLine(viaje2.getInfoViaje());

        /*
         * Ejemplo 3:
         * Un banco requiere un programa donde una persona inicia su cuenta con un fondo 
         * y reste/sume segun los depsitos y retiros
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        Banco cuenta1 = new(1000, "Alejandro Gonzalez"), cuenta2 = new(5000, "Jessica Avelar");

        cuenta1.Ingreso(500);
        cuenta1.Retiro(1400);
        cuenta1.Retiro(200);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-Datos de la cuenta 1: ");
        Console.ResetColor();
        Console.WriteLine(cuenta1.getInfoBanco());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-Datos de la cuenta 2: ");
        Console.ResetColor();
        Console.WriteLine(cuenta2.getInfoBanco());


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}

// Se crea la clase carro para el ejemplo 1
class Carro
{
    // Atributos del carro
    int puertas;
    string? color;
    double motor;
    // Se crea el constructor de la clase 
    // Se llama igual que la clase
    // Aunque no retorna nada, no es necesario usar la palabra reservada void
    public Carro()
    {
        this.puertas = 2; 
        this.color = "Azul"; 
        this.motor = 1000;
    }
    // Sobrecarca de constructores
    // Dependiendo de los parametros que se manden al instanciar la clase, es el constructor que se "usara"
    public Carro(int puertas, string? color, double motor)
    {
        this.puertas = puertas;
        this.color = color;
        this.motor = motor;
    }

    // Metodo para obtener informacion del carro
    public string getInfo()
    {
        return $"   -Color: {this.color}\n   -N° Puertas: {this.puertas}\n   -Motor: {this.motor}";
    }
}

// Se crea la clase para el ejemplo 2 
class BusViaje
{
    int inicialPersonas, actualPersonas;
    // Se crea el constructor de la clase
    public BusViaje (int personas)
    {
        this.inicialPersonas = this.actualPersonas = personas;
    }
    // Metodo que registra que llegaron mas personas al autobus
    public void AgregarPersonas (int personas)
    {
        this.actualPersonas += personas;
    }
    // Metodo que indica que se bajaron personas del autobus
    public void EliminarPersonas (int personas)
    {
        if (personas > this.actualPersonas)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"No se pueden bajar mas personas de las que hay en el bus, personas: {this.actualPersonas}");
            Console.ResetColor();
        }else 
            this.actualPersonas -= personas;
    }
    // Metodo que devuelve con cuantas personas inicio el viaje y cuantas hay ahora
    public string getInfoViaje () =>
         $"   -El viaje inicio con: {this.inicialPersonas} personas\n   -Actualmente tiene: {this.actualPersonas} personas";
}

// Se crea la clase banco para el ejemplo 3
class Banco
{
    double inicialMonto, actualMonto;
    string? nombreCliente;
    // Creamos el constructor
    public Banco (double monto,  string? nombreCliente)
    {
        this.inicialMonto = this.actualMonto = monto;
        this.nombreCliente = nombreCliente;
    }
    // Metodo para obtener la informacion de la cuenta del ususario
    public string getInfoBanco() =>
        this.inicialMonto == this.actualMonto ?
            $"{this.nombreCliente}\n   -No ha hecho movimientos en la cuenta" :
            $"{this.nombreCliente}\n   -Inicio con: {this.inicialMonto}\n   -Actualmente tiene: {this.actualMonto}";

    // Metodo para ingresar dinero a la cuenta
    public void Ingreso(double monto)
    {
        if (monto < 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"No se pueden ingresar montos negativos.");
            Console.ResetColor();
        }
        else
            this.actualMonto += monto;
    }
    // Metodo para retirar dinero de la cuenta
    public void Retiro(double monto)
    {
        if (monto < 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"No se pueden retirar montos negativos.");
            Console.ResetColor();
        }
        else if (monto > this.actualMonto)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{this.nombreCliente} No puede retirar mas de lo que tiene en la cuenta, monto actual: {this.actualMonto}");
            Console.ResetColor();
        }
        else
            this.actualMonto -= monto;
    }
}