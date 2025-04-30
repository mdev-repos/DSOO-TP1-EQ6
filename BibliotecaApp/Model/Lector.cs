using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Model
{
    internal class Lector
    {
        private string codLector;
        private string nombre;
        private string dni;
        private List<Libro> libros;

        public Lector(string nombre, string dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        public Lector(string nombre, string dni, List<Libro> libros)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.libros = libros;
        }

        public string CodLector { get => codLector; set => codLector = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        internal List<Libro> Libros { get => libros; set => libros = value; }
    }
}
