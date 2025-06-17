using _3._2_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Interfaces_2.Clases
{
    internal class PolloBrasas : Recetas, INuevaReceta, ICalentar
    {
        public void CocinarPollo ()
        {
            Program.WriteWithColor("El pollo se esta cocinando...", ConsoleColor.DarkYellow);
        }

        public void EncenderFuego()
        {
            Program.WriteWithColor("El fuego esta encendiendo...", ConsoleColor.DarkYellow);
        }

        public void LimpiarIngredientes()
        {
            Program.WriteWithColor("Los ingredientes se estan limpiando...", ConsoleColor.DarkYellow);
        }

        public void LimpiarUtencilios()
        {
            Program.WriteWithColor("Los utencilios se estan limpiando...", ConsoleColor.DarkYellow);
        }
    }
}
