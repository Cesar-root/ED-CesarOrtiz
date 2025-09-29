using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool salir;
            List<string> listadenombres = new List<string>();
            while (true) 
            {
                string respuesta = "";
                Console.WriteLine("Ingresa el nombre del alumno: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Quieres terminar de ingresar datos? Ingresa FIN para confirmar ");
                if (respuesta == "FIN" || respuesta == "fin") 
                {
                salir = true;
                }
                listadenombres.Add(nombre);
            }
            Console.WriteLine("El pronedio de tu lista es:" + listadenombres.Count());


            //Ejercicio 4: Usaria el binario para ahorrar tiempo ya que sirve para listas ordenadas

            //Ejercicio 5: Por la complejidad que da el tamaño de entrada, si aplicas un enfoque
            // diferente no te saldria del todo bien hablando de la optimizacion

            //Ejercicio 6: Usaria el lineal debido a la cantidad de datos en la lista que es
            // relativamente corto

            //Ejercicio 7: Hasta n = 10, Hasta n = 20

        }
    }
}
