using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Model
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            Libros = new List<Libro>();
            Lectores = new List<Lector>();
        }

        public List<Libro> Libros { get => libros; set => libros = value; }
        public List<Lector> Lectores { get => lectores; set => lectores = value; }

        public Boolean AgregarLibro(String titulo, String autor, String editorial)
        {
            return true;
        }

        public Boolean AltaLector(String nombre, String dni)
        {
            return true;
        }

        public Libro BuscarLibro(String titulo)
        {
            return libro;
        }

        public Boolean EliminarLibro(String titulo)
        {
            return true;
        }

        public void ListarLibros()
        {
            
        }

        public String PrestarLibro(String titulo, String dni)
        {
            return "";
        }

    }
}
