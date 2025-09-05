
internal class Program
{
    
    private static void Main(string[] args)
    {
        static double Promedio(List<double> listanumeros)
        {
            if (listanumeros == null) 
            {
                return 0;
            }
            double suma = 0;
            foreach (double num in listanumeros) 
            {
                 suma += num;
            }
            return suma/listanumeros.Count;
        }


        double dblNumero;
        List<double> listaNumeros = new List<double>();
        bool strClave = true;
        while (true) 
        {
            string respuesta = "";
            Console.WriteLine("Ingresa el numero que deseas guardar");
            dblNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Quieres terminar de agregar numeros? Si/No");
            respuesta = Console.ReadLine();
            if (respuesta == "No" || respuesta == "no")
            {
                strClave = true;
            }
            else if (respuesta == "Si" || respuesta == "si")
            {
                strClave = false;
            }
            else 
            { 
                Console.WriteLine("Error"); 
                strClave = false ;
            }
            listaNumeros.Add(dblNumero);
            if (strClave == false) break;
        }
        Console.WriteLine("El promedio de tu lista de numeros es:"+Promedio(listaNumeros));

        
    }
}