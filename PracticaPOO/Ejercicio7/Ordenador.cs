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

        public Ordenador()
        {
            _disco = 250;
            _discoMax = 500;
            _encendido = false;
        }

        public int AgregarDatos(int datos)
        {
            if (_encendido == true)
            {

            if (datos <= _discoMax)
            {

                _disco = datos + _disco;

                if (_disco > _discoMax)
                {
                    _disco = _discoMax;
                }

                Console.WriteLine($"Se agrego al de disco {datos}");
                Console.WriteLine($"Total disco de disco {_disco}");
                return _disco;
            }
            else
            {
                

                return _disco = _discoMax;
            }
            }
            else
            {
                Console.WriteLine($"El ordenador debe estar encendido");
                return datos;
            }
        }

        public int EliminarDatos(int datos)
        {
            if (_encendido == true)
            {

                if ( datos > 0)
                {
                    _disco = datos - _disco;

                    Console.WriteLine($"Se elimino {datos}");
                    return _disco;
                }
                else
                {
                     datos = 0;
                    _disco = datos;

                    Console.WriteLine($"Se elimino Todos los datos");
                    return _disco;
                }
            }
            else
            {
                Console.WriteLine($"El ordenador debe estar encendido");
                return datos;
            }
        }

        public bool Encender()
        {
            Console.WriteLine("Ordenador encendido listo para usar");

            return _encendido = true;
        }

        public bool Apagar()
        {
            Console.WriteLine("Ordenador apagado");
            return _encendido = false;
        }


    }
}
