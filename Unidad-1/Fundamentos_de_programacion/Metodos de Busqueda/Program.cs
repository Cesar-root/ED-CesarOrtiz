using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Busqueda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Cual numero quieres buscar ");
            int objetivo = int.Parse(Console.ReadLine());
            int resultado = Busqueda_Binaria(listaNumeros, objetivo)+1;
            if (Busqueda_Binaria(listaNumeros, objetivo) != -1)
            {
                Console.WriteLine("Elemento encontrado en posicion " + resultado);
            }
            else if (Busqueda_Binaria(listaNumeros,objetivo) == -1)
            {
                Console.WriteLine("Elemento no encontrado");
            }
            //if (Busqueda_Lineal(listaNumeros,objetivo) == 1)
            //{
            // Console.WriteLine("Esta en la lista");
            //}
            //else 
            //{
            //  Console.WriteLine("No esta en la lista");
            //}

            

        }
        //static int Busqueda_Lineal(List<int> numeros, int objetivo) 
        //{
        // foreach (int numero in numeros) 
        //{
        //  if (numero == objetivo) { return 1; }

        //}
        //return 0;  
        //}

        static int Busqueda_Binaria(List<int> numeros, int objetivo ) 
        {
            int izquierda, derecha;
            izquierda = 0;
            derecha = numeros.Count - 1;
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                if (numeros[medio] == objetivo)
                {
                    return medio;
                }
                else if (numeros[medio] < objetivo) { izquierda = medio + 1; }
                else { derecha = medio - 1; }
            }
            return -1;
        }
    }
}
