using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico : Persona
    {
        public int NumColegiado;
        public List<Paciente> pacientesDelMedico = new List<Paciente>();

        public Medico(string nombre, string apellido, string dni, string email, int edad, string sexo, string telefono, int numColegiado) : base(nombre, apellido, dni, email, edad, sexo, telefono)
        {
            this.NumColegiado = numColegiado;
        }
        public void AsignarPaciente(Paciente p)
        {
            pacientesDelMedico.Add(p);
        }
    }
}
