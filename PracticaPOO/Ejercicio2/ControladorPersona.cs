using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio2
{
    internal class ControladorPersona: Persona
    {
        public void IngresoPersona(int total)
        {
            
            Persona[] persona = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                persona[i] = new Persona();
                {
                    Nombre = Console.ReadLine();
                }
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persona[i].ToString());
            }
        }
    }
}
