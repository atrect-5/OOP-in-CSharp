using _3._3_Interfaces_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Interfaces_3.Clases
{
    internal class Mensaje (string destinatario, string remitente, string mensaje) : Correo, INuevoMensaje
    {
        string? destinatario = destinatario, remitente = remitente, mensaje = mensaje;
        public string Destinatario()
        {
            return this.destinatario ?? "";
        }

        public string Remitente()
        {
            return this.remitente ?? "";
        }

        string INuevoMensaje.Mensaje()
        {
            return this.mensaje ?? "";
        }
    }
}
