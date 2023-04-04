using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio7
{
    internal class Ordenador
    {
        private int _disco;
        private int _discoMax;
        private bool _encendido;

        public Ordenador(bool encendido)
        {
            _disco = 250;
            _discoMax = 500;
            _encendido = encendido;
        }

        public int AgregarDatos(int datos)
        {
            if (_encendido == true)
            {
                if (_disco >= _discoMax)
                {
                    _disco = _discoMax;
                }

                return _discoMax = datos;
            }
            else
            {
                return datos;
            }
        }




    }
}
