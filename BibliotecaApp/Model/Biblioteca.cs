using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Model
{
    public class Biblioteca
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
            Libro libro = new(titulo, autor, editorial);
            libros.Add(libro);
          
            return true;
            
        }


        public Boolean AltaLector(String nombre, String dni)
        {
            Lector lector = new(nombre, dni);
            lectores.Add(lector);
            return true;
        }

        public Libro? BuscarLibro(String titulo)
        {
            return libros.FirstOrDefault(libro => libro.Titulo == titulo);
        }

        public Boolean EliminarLibro(String titulo)
        {
            Boolean respuesta = false;
            if(BuscarLibro(titulo) != null)
            {
                libros.RemoveAt(libros.FindIndex(libro => libro.Titulo == titulo));
                respuesta = true;
            }
            
            return respuesta; 
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
