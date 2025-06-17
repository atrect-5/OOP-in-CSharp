using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Interfaces
{
    internal interface IVehiculo
    {
        // Se declaran los metodos en la interfaz que retornaran los valores de las propiedades del vehiculo
        // Tambien pueden recibir parametros, en cuyo caso, se debe recibir el parametro en el metodo de la clase que hereda
        int Ruedas();
        int Motor();
        string Color();
        string Marca();
    }
}
