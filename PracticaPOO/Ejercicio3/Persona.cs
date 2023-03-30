using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio3
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"A caso te llamas como el pendejo de {Nombre}";
        }

        ~Persona() 
        { 
            Nombre = string.Empty ;
        }
    }
}
