// See https://aka.ms/new-console-template for more information
using BibliotecaApp.Model;
Biblioteca biblioteca = new();




Console.WriteLine("Escribe el título del libro que quieres buscar: ");
String titulo = Console.ReadLine();
biblioteca.BuscarLibro(titulo);
Console.ReadKey();