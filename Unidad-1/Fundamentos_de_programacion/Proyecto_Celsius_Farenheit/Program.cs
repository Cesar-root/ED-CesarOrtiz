using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa los grados en celsius ");
        double dblGrados = 0;
        dblGrados = double.Parse(Console.ReadLine());
        Console.WriteLine("Estas a "+ Conversion(dblGrados) +" Grados");
    }
        static double Conversion(double dblGrados) 
        {
            double Grados = dblGrados;
            return Grados * 1.8 + 32;
        }
    
}
