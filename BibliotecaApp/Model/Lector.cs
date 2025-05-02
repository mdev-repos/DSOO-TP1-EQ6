using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Model
{
    public class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> libros;

        public Lector(string nombre, string dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Libros = new List<Libro>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public List<Libro> Libros { get => libros; set => libros = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre + ". DNI: " + dni;
        }
    }
}
