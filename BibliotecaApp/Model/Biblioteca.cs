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
            //AGREGAR VALIDACION PARA QUE NO SE CARGEN 2 MAS LIBROS IGUALES
            Libro libro = new(titulo, autor, editorial);
            libros.Add(libro);
          
            return true;
            
        }


        public Boolean AltaLector(String nombre, String dni)
        {
            //AGREGAR VALIDACION PARA QUE NO SE CARGEN 2 O MAS LECTORES IGUALES
            Lector lector = new(nombre, dni);
            lectores.Add(lector);
            return true;
        }

        public Libro? BuscarLibro(String titulo)
        {
            //AGREGAR METODO TOUPPER O TOLOWER PARA EVITAR ERRORES DE 'FORMATO'
            return libros.FirstOrDefault(libro => libro.Titulo == titulo);
        }

        public Boolean EliminarLibro(String titulo)
        {
            Boolean respuesta = false;
            Libro? libro = BuscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                respuesta = true;
            }
            
            return respuesta; 
        }

        public void ListarLibros()
        {
            libros.ForEach(libro=> Console.WriteLine(libro));
        }

        public Lector? BuscarLector(String dni)
        {
            return lectores.FirstOrDefault(lector => lector.Dni == dni);
        }

        public String PrestarLibro(String titulo, String dni)
        {
            Libro? libroRequerido = BuscarLibro(titulo);

            if (libroRequerido == null)
            {
                return "LIBRO INEXISTENTE";
            }

            Lector? lectorRequerido = BuscarLector(dni);

            if (lectorRequerido == null)
            {
                return "LECTOR INEXISTENTE";
            }

            if(lectorRequerido.Libros.Count > 2) 
            {
                return "TOPE DE PRESTAMO ALCAZADO";
            }

            //Prestamo exitoso
            lectorRequerido.Libros.Add(libroRequerido);
            libros.Remove(libroRequerido);

            return "PRESTAMO EXITOSO";
        }

    }
}
