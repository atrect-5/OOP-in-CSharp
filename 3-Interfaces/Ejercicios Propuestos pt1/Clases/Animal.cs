using Ejercicios_Propuestos_pt1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Propuestos_pt1.Clases
{
    internal class Animal(string name) : INewAnimal
    {
        // Se define el nombre del animal
        protected string? name = name ?? "";

        // Se define el metodo que indica que esta caminando
        public virtual void Walk()
        {
            Program.WriteWithColor("El animal esta caminando...", ConsoleColor.DarkYellow);
        }

        // Se define el metodo que indica que esta comiendo
        public void Eat()
        {
            Program.WriteWithColor("El animal esta comiendo...", ConsoleColor.DarkYellow);
        }

        // Se define el metodo que indica que esta durmiendo
        public void Sleep()
        {
            Program.WriteWithColor("SHH, el animal esta durmiendo...", ConsoleColor.DarkYellow);
        }

        // Se define el metodo para mostrar el nombre del animal
        public virtual void ShowData()
        {
            Program.WriteWithColor($"   -El animal se llama: {this.name}", ConsoleColor.Gray);
        }
    }
}
