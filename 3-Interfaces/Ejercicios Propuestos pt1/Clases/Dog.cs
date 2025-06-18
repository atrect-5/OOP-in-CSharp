using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Propuestos_pt1.Clases
{
    internal class Dog(string name) : Animal(name)
    {
        // Sobreescribimos el metodo de mostrar informacion para que tambien se muestre que animal es
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("   -Y es un perro.");
        }

        // Sobreescribimos el metodo de caminar para que muestre un mensaje diferente
        public override void Walk()
        {
            Program.WriteWithColor("El perro esta caminando alegremente...", ConsoleColor.DarkYellow);
        }
    }
}
