using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caso Biblioteca");
            Clases.Clases biblioteca = new Clases.Clases();
            Console.WriteLine("MODIFICACION HECHA POR OMAR PARA PULL REQUEST");
            Console.WriteLine("1. Mostrar libros");
            Console.WriteLine("2. Agregar libro");
            Console.WriteLine("0. Salir");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                case 1:
                    biblioteca.mostrarLibros();
                    break;
                case 2:
                    Console.Write("Ingrese el título del libro: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Ingrese el nombre del autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Ingrese el ISBN: ");
                    string isbn = Console.ReadLine();

                    Console.Write("Ingrese el número de ejemplares: ");
                    int numeroEjemplares = int.Parse(Console.ReadLine());
                    biblioteca.agregarLibro(new Clases.Libro(titulo, autor, isbn, numeroEjemplares));
                    break;
            }   
        }
    }
}
