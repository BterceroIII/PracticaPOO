using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.EJercio6
{
    internal class Ejecucion6
    {
        void Test()
        {
            Aleatorio a = new Aleatorio();

            Console.WriteLine("Genero 20 numeros entre 1 y 20");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(a.GenerarNumero(1, 20));
            }

            Console.WriteLine("Genero 20 numeros entre 1 y 20 en un array");
            int[] arr = a.GenerarNumeros(5, 1, 20);

            for (int i = 0; arr != null && i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



        }
    }
}
