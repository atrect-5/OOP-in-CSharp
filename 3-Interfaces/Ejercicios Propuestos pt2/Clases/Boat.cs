using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Propuestos_pt2.Clases
{
    internal class Boat(string vehicleBrand) : Vehicle(vehicleBrand)
    {
        // Método para mostrar la información específica del barco
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("   -Este es un barco.");
        }
        // Método para indicar que el barco está acelerando
        public override void Accelerate()
        {
            Program.WriteWithColor("El barco está acelerando...", ConsoleColor.DarkYellow);
        }
    }
}
