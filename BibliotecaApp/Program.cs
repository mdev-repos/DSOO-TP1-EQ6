// See https://aka.ms/new-console-template for more information
using BibliotecaApp.Model;
Biblioteca biblioteca = new();

biblioteca.AgregarLibro("La naranja mecanica", "Guille", "Ivrea");
biblioteca.AgregarLibro("El tunel", "Cyn", "Ivrea");
biblioteca.AgregarLibro("Martin Fierro", "Mati", "Ivrea");

Console.WriteLine("Escribe el título del libro que quieres buscar: ");
String titulo = Console.ReadLine();
biblioteca.BuscarLibro(titulo);

biblioteca.EliminarLibro("El tunel");

Console.ReadKey();