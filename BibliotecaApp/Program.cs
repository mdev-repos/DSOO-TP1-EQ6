// See https://aka.ms/new-console-template for more information
using BibliotecaApp.Model;

Console.WriteLine(" ");
Console.WriteLine("***********************************************************************************************************************************");
Console.WriteLine("****************************************************** BIBLIOTECA 'EQUIPO 6' ******************************************************");
Console.WriteLine("***********************************************************************************************************************************");
Console.WriteLine(" ");
Console.WriteLine("APRIETA UNA TECLA PARA IR PROBANDO LAS FUNCIONALIDADES DE LA BIBLIOTECA");
Console.WriteLine(" ");
Console.ReadKey();

//Creacion de una instancia de la clase Biblioteca para demostrar funcionalidad del programa.
Console.WriteLine("--> Creacion de una instancia de la clase Biblioteca para demostrar funcionalidad del programa");
Biblioteca biblioteca = new();
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'ListarLibros' --> Permite recuperar una lista con todos los ejemplares disponibles en la biblioteca.
Console.WriteLine("--> Metodo 'ListarLibros': Permite recuperar una lista con todos los ejemplares disponibles en la biblioteca.");
biblioteca.ListarLibros();
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Esta biblioteca aun esta vacia :(");
Console.WriteLine("Vamos a agregar algunos ejemplares a la coleccion :)");
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'AgregarLibro' --> Permite agregar un ejemplar a la biblioteca indicando "nombre", "autor" y "editorial".
Console.WriteLine("--> Metodo 'AgregarLibro': Permite agregar un ejemplar a la biblioteca indicando 'nombre', 'autor' y 'editorial'.");
biblioteca.AgregarLibro("La naranja mecanica", "Guille", "Ivrea");
biblioteca.AgregarLibro("El tunel", "Cyn", "Ivrea");
biblioteca.AgregarLibro("Martin Fierro", "Mati", "Ivrea");
biblioteca.AgregarLibro("Cementerio de animales", "Stephen King", "Planeta");
biblioteca.AgregarLibro("El amor en los tiempos del colera", "Gabriel Garcia Marquez", "Sudamerica");
biblioteca.AgregarLibro("El pozo y el pendulo", "Edgar Allan Poe", "Atlantis");
biblioteca.AgregarLibro("La llamada de ktulu", "Howard P. Lovecraft", "Universo");
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Ahora volvemos a revisar los libros disponibles...");
Console.WriteLine(" ");
biblioteca.ListarLibros();
Console.WriteLine(" ");
Console.WriteLine("... ya no esta tan vacia!");
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Puedes buscar un libro de tu interes en la biblioteca");
Console.WriteLine("Tendran el Martin Fierro?");
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'BuscarLibro' --> Permite buscar un libro en la biblioteca indicando su titulo.
Console.WriteLine("--> Metodo 'BuscarLibro': Permite buscar un libro en la biblioteca indicando su titulo.");
Console.WriteLine(biblioteca.BuscarLibro("Martin Fierro"));
Console.WriteLine("Parece que si! por que no intentas probar el sistema tu mismo?...");
Console.WriteLine("Ingresa el titulo de tu libro de interes: ");
String? titulo = Console.ReadLine();
Console.WriteLine(biblioteca.BuscarLibro(titulo));

Console.WriteLine(" ");
Console.WriteLine("Pero que es una Biblioteca sin lectores realmente?...");
Console.WriteLine("Vamos a agregar a algunos");
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'AltaLector' --> Permite agregar un lector a la lista de lectores de la Biblioteca indicando nombre y dni.
Console.WriteLine("--> Metodo 'AltaLector': Permite agregar un lector a la lista de lectores de la Biblioteca indicando nombre y dni.");
biblioteca.AltaLector("Matias Mazzitelli", "11222333");
biblioteca.AltaLector("Guillermo Benitex", "22222333");
biblioteca.AltaLector("Emilia Sosa Tomada", "33222333");
biblioteca.AltaLector("Cynthia Sanchez", "44222333");

Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Ahora tenemos algunos lectores para jugar");
Console.WriteLine("Si quisieramos comprobar si un lector esta cargado en la lista de la Biblioteca podriamos mediante su DNI");
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'BuscarLector' --> Permite buscar un lector en la lista de lectores de la Biblioteca indicando su DNI.
Console.WriteLine("--> Metodo 'BuscarLector': Permite buscar un lector en la lista de lectores de la Biblioteca indicando su DNI.");
Console.WriteLine("Vamos a pasarle el DNI de Guillermo...");
Console.WriteLine(biblioteca.BuscarLector("22222333"));
Console.WriteLine("~~ It's a kind of magic ~~");
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Ahora nos falta probar prestarle libros a alguno de nuestros lectores, siempre asegurandonos de que");
Console.WriteLine("que el lector existe, el libro existe y el lector no ha alcanzado su tope de prestamos (3)");
Console.WriteLine("Vamos a prestarle algunos titulos a Guillermo...");
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'PrestarLibro' --> Permite quitar un libro de la lista de libros de la Biblioteca y agregarlo a la lista de libros
//del Lector indicando titulo del libro y dni del lector, siempre que respete las restricciones del metodo.
Console.WriteLine("--> Metodo 'PrestarLibro': Permite quitar un libro de la lista de libros de la Biblioteca y agregarlo a la lista de libros");
Console.WriteLine(" del Lector indicando titulo del libro y dni del lector.");
Console.WriteLine(biblioteca.PrestarLibro("La naranja mecanica", "22222333"));
Console.WriteLine(biblioteca.PrestarLibro("El tunel", "22222333"));
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Le hemos prestado exitosamente 2 titulos a Guillermo, pero esto podria haber fallado. Vamos a 'hacerlo fallar'");
Console.WriteLine("~ Que el libro indicado no existe... ~");
Console.WriteLine(biblioteca.PrestarLibro("El sapo pepe", "22222333"));
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("~ Que el lector indicado no existe... ~");
Console.WriteLine(biblioteca.PrestarLibro("El amor en los tiempos del colera", "99222888"));
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("~ Que el lector ya haya alcanzado el tope permitido de 3... ~");
Console.WriteLine(biblioteca.PrestarLibro("El pozo y el pendulo", "22222333"));
Console.WriteLine(biblioteca.PrestarLibro("El amor en los tiempos del colera", "22222333"));
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Por ultimo, podria interesarnos eliminar un libro de la Biblioteca.");
Console.WriteLine("Biblioteca antes de eliminar un libro");
biblioteca.ListarLibros();
Console.WriteLine(" ");
Console.ReadKey();

//Metodo 'EliminarLibro' --> Permite eliminar un libro de la biblioteca indicando su titulo.
Console.WriteLine("--> Metodo 'EliminarLibro': Permite eliminar un libro de la biblioteca indicando su titulo.");
biblioteca.EliminarLibro("La llamada de ktulu");
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("Biblioteca despues de eliminar un libro (La llamada de ktulu)");
biblioteca.ListarLibros();
Console.WriteLine(" ");
Console.ReadKey();

Console.WriteLine("MUCHAS GRACIAS POR PROBAR NUESTRA APP BIBLIOTECA! :)");
Console.ReadKey();