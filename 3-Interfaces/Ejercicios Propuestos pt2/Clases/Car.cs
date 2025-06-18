using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Propuestos_pt2.Clases
{
    internal class Car(string vehicleBrand) : Vehicle(vehicleBrand)
    {
        // Método para mostrar la información específica del carro
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("   -Este es un carro.");
        }
        // Método para indicar que el carro está acelerando
        public override void Accelerate()
        {
            Program.WriteWithColor("El carro está acelerando...", ConsoleColor.DarkYellow);
        }
    }
}
