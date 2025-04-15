using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Clases
    {
        public Nodo primero = null;
        public Nodo ultimo = null;

        internal bool verificarLista()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregarLibro(Libro libro)
        {
            if (verificarLista())
            {
                primero = new Nodo { dato = libro };
            }
            else
            {
                Nodo temp = primero;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                Nodo nuevo = new Nodo { dato = libro, siguiente = null, anterior = temp };
                temp.siguiente = nuevo;
            }
        }
        public void mostrarLibros()
        {
            if (verificarLista())
            {
                Console.WriteLine("No hay libros en la lista");
                return;
            }
            else
            {
                Nodo temp = primero;
                while (temp.siguiente != null)
                {
                    Console.WriteLine(temp.dato.ToString());
                    temp = temp.siguiente;
                }
            }
        }
        public void mostrarLibrosInverso()
        {
            if (verificarLista())
            {
                Console.WriteLine("No hay libros en la lista");
                return;
            }
            else
            {
                Nodo temp = ultimo;
                while (temp.anterior != null)
                {
                    Console.WriteLine(temp.dato.ToString());
                    temp = temp.anterior;
                }
            }
        }
        public int totalLibros()
        {
            if (verificarLista())
            {
                return 0;
            }
            else
            {
                int totalLibros = 0;
                Nodo temp = primero;
                while (temp.siguiente != null)
                {
                    totalLibros++;
                    temp = temp.siguiente;
                }
            }
            return totalLibros();
        }

        public void eliminarLibro(String nombreLibro)
        {
            if (verificarLista())
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo temp = primero;
                Nodo temp2 = null;
                while (temp.siguiente != null)
                {
                    temp2 = temp;
                    temp = temp.siguiente;
                    if (nombreLibro.Equals(temp.siguiente))
                    {

                    }
                }   
            }
        }
    }
}
