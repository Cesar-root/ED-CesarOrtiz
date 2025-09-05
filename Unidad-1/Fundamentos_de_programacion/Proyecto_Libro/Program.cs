using Proyecto_Libro;

internal class Program
{
    private static void Main(string[] args)
    {
        Coche miChoche = new Coche();
        Console.WriteLine("Introduce la marca del carro");
        string strMarca = Console.ReadLine();
        miChoche.Marca = strMarca;
        Console.WriteLine("Introduce el modelo del carro");
        string strModelo = Console.ReadLine();
        miChoche.Modelo = strModelo;
        Console.WriteLine("Cuanros kilometros de velocidad tiene");
        double dblVelocidad = double.Parse(Console.ReadLine());
        miChoche.Velocidad = dblVelocidad;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Presiona S para frenar");
        Console.WriteLine("Presiona W para acelerar");
        Char chrInput = char.Parse(Console.ReadLine());
        if (chrInput == 'W' || chrInput == 'w')
        {
            Console.WriteLine(miChoche.Acelerar());
        }
        else if (chrInput == 'S' || chrInput == 's') 
        {
            Console.WriteLine(miChoche.Frenar());
        }
    }
}