internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el primer numero de la operacion");
        double dblN1 = 0;
        dblN1 = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingresa la operacion que deseas elaborar");
        Console.WriteLine("");
        Console.WriteLine(" + para suma");
        Console.WriteLine(" - para resta");
        Console.WriteLine("/ para division");
        Console.WriteLine("* para multiplicar");
        char chrOperacion;
        chrOperacion = char.Parse(Console.ReadLine());
        Console.Clear();
        switch (chrOperacion)
        {
            case '+': Console.WriteLine("Ingresa el numero que le sumaras "); break;
            case '-': Console.WriteLine("Ingresa el numero que le restaras"); break;
            case '/': Console.WriteLine("Ingresa el numero por el que lo dividiras"); break;
            case '*': Console.WriteLine("Ingresa el numero por el que lo multiplicaras"); break;
            default: Console.WriteLine("No ingresaste lo solicitado"); break;
        }
        double dblN2 = 0;
        dblN2 = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Tu resultado es "+Operacion(dblN1,dblN2,chrOperacion));
    }
        
        static double Operacion(double N1, double N2, char Operacion)
            {
                switch(Operacion) 
                {
                    case '+': return N1 + N2;   ; break;
                    case '-': return N1 - N2; break;
                    case '/': return N1 / N2; break;
                    case '*': return N1 * N2;
                }
                return 0;

            }

}

