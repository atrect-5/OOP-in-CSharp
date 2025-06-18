using Ejercicios_Propuestos_pt2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Propuestos_pt2.Clases
{
    internal class Vehicle(string vehicleBrand) : INewVehicle
    {
        string vehicleBrand = vehicleBrand;

        // Metodo para indicar que el vehiculo esta acelerando
        public virtual void Accelerate()
        {
            Program.WriteWithColor("El vehiculo esta acelerando...", ConsoleColor.DarkYellow);
        }

        // Metodo para indicar que el vehiculo esta frenando
        public void Brake()
        {
            Program.WriteWithColor("El vehiculo esta frenando...", ConsoleColor.DarkYellow);
        }

        // Metodo para indicar que el vehiculo esta encendido
        public void Start()
        {
            Program.WriteWithColor("El vehiculo esta encendido...", ConsoleColor.DarkYellow);
        }

        // Metodo para mostrar la informacion de vehiculo
        public virtual void ShowData()
        {
            Console.WriteLine($"   -La marca del vehiculo es: {this.vehicleBrand}");
        }
    }
}
