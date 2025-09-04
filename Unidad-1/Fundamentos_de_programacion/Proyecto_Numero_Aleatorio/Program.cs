using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        
        int intNumeroUsuario = 0;
        
        int NumeroAdivinar = random.Next(0, 100);
        
        while (intNumeroUsuario != NumeroAdivinar) 
        {
            Console.WriteLine("Elige un numero entre 0 y 100");
            intNumeroUsuario = int.Parse(Console.ReadLine());
            if (intNumeroUsuario<NumeroAdivinar) 
            {
                Console.WriteLine("Un poco mas arriba");
            }
            else if (intNumeroUsuario > NumeroAdivinar)
            {
                Console.WriteLine("Un poco mas abajo");
            }
            
        }
        Console.WriteLine("ERES UN ADIVINO");
    
        }
}