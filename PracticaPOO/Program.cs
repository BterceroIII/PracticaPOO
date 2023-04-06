// See https://aka.ms/new-console-template for more information

using PracticaPOO.Ejercicio1;
using PracticaPOO.Ejercicio7;

Ordenador ordenador = new Ordenador();

ordenador.Encender();
Console.WriteLine("------------------------");
ordenador.AgregarDatos(500);
ordenador.EliminarDatos(100);
Console.WriteLine("------------------------");
Console.WriteLine("------------------------");
Console.WriteLine("------------------------");
ordenador.Apagar();
Console.WriteLine("------------------------");
ordenador.AgregarDatos(100);
ordenador.EliminarDatos(50);

