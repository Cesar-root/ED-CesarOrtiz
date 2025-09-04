internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el radio del circulo: ");
        double dblRadio;
        dblRadio = double.Parse(Console.ReadLine());
        Console.WriteLine("Su area es:" + Area(dblRadio));

    }
    static double Area(double radio) 
    {
        double r = radio;
        return Math.PI * (r * r);
    }
}