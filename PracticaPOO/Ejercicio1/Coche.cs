﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio1
{
    internal class Coche
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int KM { get; set; }
        public decimal Precio { get; set; }

        public Coche(int id, string marca, string modelo, int km, decimal precio)
        {
            ID = id;
            Marca = marca;
            Modelo = modelo;
            KM = km;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"El coche es {ID} -- {Marca} -- {Modelo} -- {KM} -- {Precio}";
        }

        
    }
}
