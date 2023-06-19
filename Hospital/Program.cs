using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            // Listas de Pacientes y Médicos
            List<Medico> listaMedicos = new List<Medico>();
            List<Paciente> pacientes = new List<Paciente>();

            // Variables de lógica del programa
            bool trabajo = true;
            int orden;

            while (trabajo)
            {
                Console.WriteLine("Hospital Dos Germanas");
                Console.WriteLine("1- Introducir un médico");
                Console.WriteLine("2- Introducir un paciente");
                orden = Convert.ToInt32(Console.ReadLine());
                switch (orden)
                {
                    case 1:
                        listaMedicos.Add(CrearPersonaMedico());
                        break;
                    case 2:
                        pacientes.Add(CrearPersonaPaciente());
                        break;
                }
            }
        }
        static Medico CrearPersonaMedico()
        {
            // Variables para médico
            string name;
            string lastname;
            string NID;
            string mail;
            int age;
            string sex;
            string phone;
            int collegeNumber;
            // Parametros de introduccón
            Console.Clear();
            Console.WriteLine("Introduce un nombre");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce un apellido");
            lastname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce el DNI");
            NID = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce un correo electronico");
            mail = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce la edad");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduce el sexo");
            sex = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce el teléfono");
            phone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce el numero de colegiado");
            collegeNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Medico p = new Medico(name, lastname, NID, mail, age, sex, phone, collegeNumber);
            return p;
        }

        static Paciente CrearPersonaPaciente()
        {
            string name;
            string lastname;
            string NID;
            string mail;
            int age;
            string sex;
            string phone;
            int numSeguridad;
            // Parametros de introduccón
            Console.Clear();
            Console.WriteLine("Introduce un nombre");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce un apellido");
            lastname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce el DNI");
            NID = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce un correo electronico");
            mail = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce la edad");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduce el sexo");
            sex = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce el teléfono");
            phone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduce el numero de colegiado");
            numSeguridad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Paciente p = new Paciente(name, lastname, NID, mail, age, sex, phone, numSeguridad);
            return p;
        }

        /*static void AsignarPaciente()
        {
            int nC;
            Console.WriteLine("Para asignar un paciente primero");
            Console.WriteLine("Introduce el numero de colegiado");
            nC = Convert.ToInt32(Console.ReadLine());
            
        }*/
    }
}
