using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente : Persona
    {
        public int numSegSoc { get; set; }
        public Paciente(string nombre, string apellido, string dni, string email, int edad, string sexo, string telefono, int NumSecSoc) : base(nombre, apellido, dni, email, edad, sexo, telefono)
        {
            this.numSegSoc = NumSecSoc;
        } 

    }
}
