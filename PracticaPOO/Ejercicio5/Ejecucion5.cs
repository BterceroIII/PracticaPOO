using PracticaPOO.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Ejercicio5
{
    internal class Ejecucion5
    {
        void test()
        {
            Concesionario concesionario = new Concesionario(10);

            Coche c1 = new Coche(1, "BMW", "4", 1000, 12000);
            Coche c2 = new Coche(1, "Zentorno", "XS", 1000, 12000);
            Coche c3 = new Coche(1, "Bugati", "4", 1000, 1222000);
            Coche c4 = new Coche(1, "Hundai", "4", 1000, 125000);
            Coche c5 = new Coche(1, "Toyota", "PRADO", 1000, 123000);


            Console.WriteLine("Todos los coches");
            concesionario.agregarCoche(c1);
            concesionario.agregarCoche(c2);
            concesionario.agregarCoche(c3);
            concesionario.agregarCoche(c4);
            concesionario.agregarCoche(c5);
            concesionario.MostrarCoche();
            Console.WriteLine("Eliminar coches los coches");
            concesionario.EliminarCoche(c5);
            concesionario.MostrarCoche();
            Console.WriteLine("Vacio");
            concesionario.VaciarCoche();
            concesionario.MostrarCoche();
        }
    }
}
