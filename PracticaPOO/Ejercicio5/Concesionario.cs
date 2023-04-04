using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPOO.Ejercicio1;

namespace PracticaPOO.Ejercicio5
{
    internal class Concesionario
    {
        private Coche[] _coches;
        private int _limite;

        private int _numCoche;

        public Concesionario(int limite)
        {
            this._coches = new Coche[limite];
            _limite = limite; // limite de coches que tendra el array
            _numCoche = 0; // para recorrer el numero de coches que tendra en el array
        }

        public void agregarCoche(Coche c)
        {
            if (c != null && _numCoche < _coches.Length)
            {
                _coches[_numCoche] = c;
                _numCoche++;
            }
        }
        public void MostrarCoche()
        {
            for (int i = 0; i < _numCoche; i++)
            {
                Console.WriteLine(_coches[i].ToString());
            }
        }
        public void VaciarCoche()
        {
            this._coches = new Coche[_limite];
            _numCoche = 0;
        }
        public void EliminarCoche(Coche c)
        {
            if (c != null && _numCoche !=0)
            {
                int posicion = -1;
                for (int i = 0; i < _numCoche; i++)
                {
                    if (c.ID == _coches[i].ID)
                    {
                        posicion = i;
                    }
                }
                if (posicion == -1)
                {
                    Console.WriteLine("No existe el coche");
                }
                else
                {
                    _coches[posicion] = null;
                    for (int i = posicion; i < _numCoche ; i++)
                    {
                        _coches[i] = _coches[i + 1];
                    }

                    _numCoche--;
                }
            }
        }

    }
}
