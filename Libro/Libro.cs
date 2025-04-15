using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro
    {
        private string Titulo;
        private string Autor;
        private string Isbn;
        private int NumeroEjemplares;

        public Libro(string titulo, string autor, string isbn, int numeroEjemplares)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            NumeroEjemplares = numeroEjemplares;
        }

        public override string ToString()
        {
            return (Titulo + " // " + Autor + " // " + Isbn + " // " + NumeroEjemplares);
        }
    }
}
