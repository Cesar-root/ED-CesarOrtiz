internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Elige un numero");
        int Numero = 0;
        Numero = int.Parse(Console.ReadLine());
        if (Numero % 2 == 0)
        {
            Console.WriteLine("No es primo");
        }
        else 
        { 
            Console.WriteLine("Es primo");
        }
    }
}