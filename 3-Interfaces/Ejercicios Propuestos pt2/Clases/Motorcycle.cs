using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Propuestos_pt2.Clases
{
    internal class Motorcycle(string vehicleBrand) : Vehicle(vehicleBrand)
    {
        // Método para mostrar la información específica de la motocicleta
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("   -Esta es una motocicleta.");
        }
        // Método para indicar que la motocicleta está acelerando
        public override void Accelerate()
        {
            Program.WriteWithColor("La motocicleta está acelerando...", ConsoleColor.DarkYellow);
        }
    }
}
