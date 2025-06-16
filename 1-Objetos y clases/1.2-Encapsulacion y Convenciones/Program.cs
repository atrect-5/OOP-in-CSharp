internal class Program
{
    private static void Main(string[] args)
    {
        //Convertir.RetornarPesos(45.5);  // Si se especifica en la clase que el metodo es static, el metodo pertenece a la clase y no a una instancia
        Convertir convertir = new();
        double dollars = 10.00;
        double equivalenteEnPesos = convertir.RetornarPesos(dollars: dollars); // Puede o no especificar el nombre del parametro al invocar el metodo

        Console.WriteLine($"{dollars:C2} dollares equivalen a: {equivalenteEnPesos:C2}");

        // Se cambia el tipo de cambio
        convertir.ActualizarPesos(15.65);
        equivalenteEnPesos = convertir.RetornarPesos(dollars); // No se especifica el nombre del parametro
        Console.WriteLine($"{dollars:C2} dollares equivalen a: {equivalenteEnPesos:C2}");


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}

class Convertir
{
    // Si no se agrega nivel de encapsulamiento, por default se asigna 'private'
    double MNX = 18.91;

    /*
     -> Nivel de acceso public: Simpre inician con mayuscula (PascalCase)
     -> Los que no llevan nivel de acceso publico: inician con minuscula (camelCase)
    */

    // Metodo que retorna cuantos pesos equivale x cantidad de dolares
    // Al incluir 'double' se indica que el metodo retornara un valor de ese tipo
    public double RetornarPesos(double dollars)
    {
        return dollars * MNX;
    }

    // Metodo que actualiza el valor de MNX (el tipo de cambio)
    // Es equivalente a un setter, pero no es necesario que se llame 'set' o 'Set' para que sea un setter
    public void ActualizarPesos(double MNX)
    {
        this.MNX = MNX; // Al usar this, se refiere a la variable de la clase, al no usarlo, se refiere al parametro recibido en el metodo
        Console.WriteLine($"Actualizacion: $1.00 Dollar -> {MNX:C2} MNX");
    }
}