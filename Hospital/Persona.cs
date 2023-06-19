using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string apellido, string dni, string email, int edad, string sexo, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Email = email;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Telefono = telefono;
        }



    }
}
