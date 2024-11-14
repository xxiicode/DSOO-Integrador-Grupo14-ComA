using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Integrador_Grupo14_ComA
{
    internal class Socio : Cliente
    {
        // Constructor para Socio que llama al constructor de Cliente
        public Socio(string nombre, string apellido, string dni, string direccion, string mail, string telefono, DateTime fechaNacimiento)
            : base(nombre, apellido, dni, direccion, mail, telefono, fechaNacimiento, tipo: "socio")
        {
         
        }
    }
}
