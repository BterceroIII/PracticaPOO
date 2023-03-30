using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio2
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"Hola mi nombre es {Nombre}";
        }
    }
}
