// See https://aka.ms/new-console-template for more information


using PracticaPOO.Ejercicio1;
using PracticaPOO.Ejercicio2;

int total = 3;

Persona[] persona = new Persona[total];

for (int i = 0; i < total; i++)
{
    Console.WriteLine("Nombre de la persona");
    persona[i] = new Persona()
    {

        Nombre = Console.ReadLine()
    };
}

for (int i = 0; i < total; i++)
{
    Console.WriteLine(persona[i].ToString());
}