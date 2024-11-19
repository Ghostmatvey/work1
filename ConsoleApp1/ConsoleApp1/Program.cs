public class Sum
{
    public static double sum(double a, double b)
    {
        return a + b;
    }

 
    private static double droub(double a, double b)
    {
        return (a + b) / 2;
    }

    public static void Main(string[] args)
    { double a,b,c,d;
        
         a= double.Parse(Console.ReadLine());
         b= double.Parse(Console.ReadLine());
       c = sum(a, b);
        d= droub(a, b);
        Console.WriteLine($"Сумма: {c}");
        Console.WriteLine($"Среднее арифметическое: {d}");
    }
}

class piutnibvhjbvff
{
    public static void Main(string[] args)
    {
        double a, g, c;
        a= double.Parse(Console.ReadLine()); g= double.Parse(Console.ReadLine());
        Console.WriteLine(Sum.sum(a, g));
    }
}