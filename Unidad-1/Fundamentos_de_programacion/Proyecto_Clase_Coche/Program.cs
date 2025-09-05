using Proyecto_Clase_Coche;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro miLibro = new Libro();
        Console.WriteLine("Ingresa el titulo del Libro ");
        string strTitulo = Console.ReadLine();
        miLibro.Titulo = strTitulo;
        Console.WriteLine("Ingresa el nombre del Autor ");
        string strAutor = Console.ReadLine();
        miLibro.Autor = strAutor;
        Console.WriteLine(miLibro.ToString());

    }
}