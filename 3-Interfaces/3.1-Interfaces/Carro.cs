using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Interfaces
{
    internal class Carro(string color, string marca, int motor) : Vehiculo, IVehiculo
    {
        string? color = color, marca = marca;
        int motor = motor;

        public string Color()
        {
            return this.color ?? "";
        }

        public string Marca()
        {
            return this.marca ?? "";
        }

        public int Motor()
        {
            return this.motor;
        }

        public int Ruedas()
        {
            return 4;
        }
    }
}
