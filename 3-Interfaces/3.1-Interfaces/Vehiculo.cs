using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Interfaces
{
    internal class Vehiculo
    {
        public void Encender () 
        {
            Program.WriteWithColor("El vehiculo encendio", ConsoleColor.DarkYellow);
        }

        public void Acelerar()
        {
            Program.WriteWithColor("El vehiculo acelero", ConsoleColor.DarkYellow);
        }
    }
}
