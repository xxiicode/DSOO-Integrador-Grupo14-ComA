using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Integrador_Grupo14_ComA.entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string direccion;
        private string mail;
        private string telefono;
        private DateTime fechaNacimiento;
        private string tipo;

        public Cliente() { 
        }

        public Cliente(string nombre, string apellido, string dni, string direccion, string mail, string telefono, DateTime fechaNacimiento, string tipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.mail = mail;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
