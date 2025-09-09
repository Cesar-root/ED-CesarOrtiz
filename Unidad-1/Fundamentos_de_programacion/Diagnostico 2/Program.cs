using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("En que figura geometrica quieres trabajar: "+"\n"+"1.- Rectangulo"+"\n"+"2.- Cuadrado");
            int intOpcion = int.Parse(Console.ReadLine());
            if (intOpcion == 1)
            {
                Console.WriteLine("Ingresa el alto del rectangulo ");
                double alto = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa lo ancho del rectangulo ");
                double ancho = double.Parse(Console.ReadLine());
                Rectangulo miRectangulo = new Rectangulo(alto, ancho);
                Console.WriteLine(miRectangulo.MostrarDimensiones());
            }
            else if (intOpcion == 2) 
            {
                Console.WriteLine("Ingresa un lado de un cuadrado");
                double lado = double.Parse(Console.ReadLine());
                Cuadrado miCuadrado = new Cuadrado(0, 0, lado);
                Console.WriteLine(miCuadrado.MostrarDimensiones());
            }

        }
    }
}
