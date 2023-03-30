using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio4
{
    internal class Estudiante : Persona
    {
   

        public string VerEdad(int edad)
        {
            Edad = edad;
            return $"Mi edad es {Edad}";
        }

        public string Estudiar()
        {
            return $"Estoy estudiando mamahuevo";
        }
    }
}
