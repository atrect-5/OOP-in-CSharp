internal class Program
{
    private static void Main(string[] args)
    {

        /* Ejemplo 1:
         * Operaciones aritmeticas basicas
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        Operaciones operaciones = new();
        
        Console.Write(" - Introduzca el primer número: ");
        operaciones.numero1 = Convert.ToDouble(Console.ReadLine());
        Console.Write(" - Introduzca el segundo número: ");
        operaciones.numero2 = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n - Resultados de las operaciones: ");
        Console.ResetColor();
        Console.WriteLine($"   - Suma: {operaciones.Sumar()}");
        Console.WriteLine($"   - Resta: {operaciones.Restar()}");
        Console.WriteLine($"   - Multiplicacion: {operaciones.Multiplicar()}");
        Console.WriteLine($"   - Division: {operaciones.Dividir()}");


        /*
         * Ejemplo 2:
         * Clase para calcular el area y perimetro de un circulo
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        double radio;

        Console.Write(" - Introduzca el radio del circulo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n - Area y perimetro del circulo: ");
        Console.ResetColor();
        Console.WriteLine($"   -Area: {Circulo.Area(radio)} u^2");
        Console.WriteLine($"   -Perimetro: {Circulo.Perimetro(radio)} u");


        /*
         * Ejemplo 3:
         * Tendremos una clase carro con sus diferentes metodos y atributos
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        Carro carro1 = new(), carro2 = new();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n - Carro 1: ");
        Console.ResetColor();
        // Encendemos, aceleramos y frenamos el carro1
        if (carro1.Encender("BMW"))
            Console.WriteLine($"{carro1.marca} Encendio exitosamente");
        else
            Console.WriteLine($"{carro1.marca} No encendio");

        if (carro1.Acelerar())
            Console.WriteLine($"{carro1.marca} Acelero exitosamente");
        else
            Console.WriteLine($"{carro1.marca} No acelero");

        if (carro1.Frenar())
            Console.WriteLine($"{carro1.marca} Freno exitosamente");
        else
            Console.WriteLine($"{carro1.marca} No freno");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n - Carro 2: ");
        Console.ResetColor();
        // Encendemos y frenamos el carro2
        if (carro2.Encender("Chevrolet"))
            Console.WriteLine($"{carro2.marca} Encendio exitosamente");
        else
            Console.WriteLine($"{carro2.marca} No encendio");

        if (carro2.Frenar())
            Console.WriteLine($"{carro2.marca} Freno exitosamente");
        else
            Console.WriteLine($"{carro2.marca} No freno");

        // Debido a que son objetos diferentes, cada uno guarda su propio estado.


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}

// Declaración de la clase Operaciones para el ejemplo 1
class Operaciones
{
    public double numero1, numero2;

    // Metodo de clase que suma dos números
    public double Sumar ()
    {
        return numero1 + numero2;
    }
    // Metodo de clase que resta dos números (El mayor menos el menor)
    public double Restar()
    {
        if (numero1 > numero2)
            return numero1 - numero2;
        else
            return numero2 - numero1;
    }
    // Metodo de clase que multiplica dos números
    public double Multiplicar ()
    {
        return numero1 * numero2;
    }
    // Metodo de clase que Divide dos números (mientras no sean 0)
    public double Dividir ()
    {
        if (numero1 != 0 && numero2 != 0)
            return numero1 / numero2;
        else
            return 0;
    }
}

// Declaracion de la clase Circulo para el ejemplo 2
class Circulo
{
    private const double PI = Math.PI;
    
    // Metodo de clase (No se instancia) para calcular el area
    public static double Area (double radio)
    {
        radio = Math.Abs (radio);
        return PI * radio * radio;
    }
    // Metodo de clase (No se instancia) para calcular el perimetro
    public static double Perimetro(double radio)
    {
        radio = Math.Abs(radio);
        return 2 * PI * radio;
    }
}

// Declaracion de la clase carro para el ejemplo 3
class Carro
{
    public string? marca;
    bool encendio = false, acelero = false, freno;

    // Metodo que simula el encender el carro 
    // Se enciende si todo es falso (el carro esta apagado)
    // Retorna si se pudo encender o no el carro
    public bool Encender (string marca)
    {
        this.marca = marca;
        if (!encendio && !acelero && !freno)
        {
            this.encendio = true;
            return true;
        } else
        {
            return false;
        }
    }

    // Metodo que simula el acelerar el carro 
    // Se acelera si el carro esta ecendido y no ha acelerado
    // Retorna si se pudo acelerar o no el carro
    public bool Acelerar()
    {
        if (encendio && !acelero && !freno)
        {
            this.acelero = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    // Metodo que simula el frenar el carro 
    // Se acelera si el carro acelero y no ha frenado
    // Retorna si se pudo frenar o no el carro
    public bool Frenar()
    {
        if (encendio && acelero && !freno)
        {
            this.freno = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}