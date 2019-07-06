using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionesSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de perros #1");
            Datos datos1 = Datos.GetInstancia();
            datos1.ListaPerros.Add(new Perro() { Id = 1, Nombre="perro #1" });
            datos1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "perro #2" });
            datos1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "perro #3" });
            datos1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "perro #4" });
            datos1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "perro #5" });


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Lista de perros #1");
            Datos datos2 = Datos.GetInstancia();
            datos2.ListaPerros.Add(new Perro() { Id = 1, Nombre = "Flash" });
            datos2.ListaPerros.Add(new Perro() { Id = 2, Nombre = "Velvet Ears" });
            datos2.ListaPerros.Add(new Perro() { Id = 3, Nombre = "Bora" });
            datos2.ListaPerros.Add(new Perro() { Id = 4, Nombre = "Gigi" });
            datos2.ListaPerros.Add(new Perro() { Id = 5, Nombre = "Cindy" });


            foreach (Perro perro in datos1.ListaPerros)
            {
                Console.WriteLine("Id = " + perro.Id + " Nombre = " + perro.Nombre);
            }
            Console.Read();

            foreach (Perro perro in datos2.ListaPerros)
            {
                Console.WriteLine("Id = " + perro.Id + " Nombre = " + perro.Nombre);
            }
            Console.Read();
        }
    }
}
