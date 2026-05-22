using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        // Agregar 3 alumnos
        lista.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        lista.AgregarAlumno(new Alumno(2, "María", 9.0));
        lista.AgregarAlumno(new Alumno(3, "Pedro", 7.5));

        // Listar alumnos
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        // Buscar alumno que existe
        Alumno encontrado = lista.BuscarAlumno("María");
        Console.WriteLine($"\nBúsqueda 'María': {encontrado}");

        // Buscar alumno que NO existe
        Alumno noExiste = lista.BuscarAlumno("Carlos");
        Console.WriteLine($"Búsqueda 'Carlos': {(noExiste != null ? noExiste.ToString() : "No existe")}");

        // Eliminar por nombre y listar
        Alumno pedro = lista.BuscarAlumno("Pedro");
        lista.EliminarAlumno(pedro);
        Console.WriteLine("\n=== Después de eliminar Pedro ===");
        foreach (Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        // Eliminar primer elemento y listar
        lista.EliminarEnPosicion(0);
        Console.WriteLine("\n=== Después de eliminar posición 0 ===");
        foreach (Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        // Agregar 3 alumnos
        diccionario.AgregarAlumno(1001, "Juan");
        diccionario.AgregarAlumno(1002, "María");
        diccionario.AgregarAlumno(1003, "Pedro");

        // Listar alumnos
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} - Nombre: {par.Value}");
        }

        // Buscar alumno que existe
        string encontrado = diccionario.BuscarAlumno(1002);
        Console.WriteLine($"\nBúsqueda legajo 1002: {encontrado}");

        // Buscar alumno que NO existe
        string noExiste = diccionario.BuscarAlumno(9999);
        Console.WriteLine($"Búsqueda legajo 9999: {(noExiste ?? "No existe")}");

        // Eliminar y listar
        diccionario.EliminarAlumno(1001);
        Console.WriteLine("\n=== Después de eliminar legajo 1001 ===");
        foreach (var par in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} - Nombre: {par.Value}");
        }
    }

    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine($"Primero: {linq.GetPrimero().Titulo}");
        Console.WriteLine($"Último: {linq.GetUltimo().Titulo}");
        Console.WriteLine($"Total precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio precios: {linq.GetPromedioPrecios():C}");

        Console.WriteLine("\n=== Libros con Id mayor a 15 ===");
        foreach (var libro in linq.GetListById())
            Console.WriteLine(libro.Titulo);

        Console.WriteLine("\n=== Títulos y precios ===");
        foreach (var item in linq.GetLibros())
            Console.WriteLine(item);

        Console.WriteLine($"\nMayor precio: {linq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"Menor precio: {linq.GetMenorPrecio().Titulo}");

        Console.WriteLine("\n=== Libros sobre el promedio ===");
        foreach (var libro in linq.GetMayorPromedio())
            Console.WriteLine(libro.Titulo);

        Console.WriteLine("\n=== Libros ordenados por título descendente ===");
        foreach (var libro in linq.GetOrdenadosPorTitulo())
            Console.WriteLine(libro.Titulo);
    }




}
