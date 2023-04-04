using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.EJercio6
{
    internal class Aleatorio
    {
        private Random _random;

        public Aleatorio()
        {
            this._random = new Random();
        }

        public int GenerarNumero(int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }

            return this._random.Next(min, max + 1);
        }
        public int[] GenerarNumeros(int longitud,int min, int max)
        {
            if (longitud <= 0)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = GenerarNumero(min, max);
            }

            return numeros;
        }
    }
}
