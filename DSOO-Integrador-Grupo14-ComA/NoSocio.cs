using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Integrador_Grupo14_ComA
{
    internal class NoSocio : Cliente
    {
        // Constructor para NoSocio que llama al constructor de Cliente
        public NoSocio(string nombre, string apellido, string dni, string direccion, string mail, string telefono, DateTime fechaNacimiento)
            : base(nombre, apellido, dni, direccion, mail, telefono, fechaNacimiento, tipo: "no-socio")
        {
        
        }
    }
}
