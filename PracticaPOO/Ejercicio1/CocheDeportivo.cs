using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio1
{
    internal class CocheDeportivo:Coche
    {
        public int Potencia { get; set; }
        public CocheDeportivo(int id, string marca, string modelo, int km, decimal precio, int potencia): base( id, marca, modelo, km, precio)
        {
            Potencia = potencia;
        }


        public override string ToString()
        {
            return $"Coche deportivo Marca: {Marca}, Modelo: {Modelo}, Potencia: {Potencia}";
        }

        public string Acelerar()
        {
            return $"RUUUUUN RUUUUN!!";
        }
    }
}
