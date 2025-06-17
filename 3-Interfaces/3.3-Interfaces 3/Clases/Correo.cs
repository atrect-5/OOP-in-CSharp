using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Interfaces_3.Clases
{
    internal class Correo
    {
        public void EnviarCorreo()
        {
            Program.WriteWithColor("Usted ha mandado su correo", ConsoleColor.DarkBlue);
        }
    }
}
