using System;

public class Program
{
    static void Main(string[] args)
    {
        double x, y;
        Console.Write("Введите х: ");
        double.TryParse(Console.ReadLine(), out x);
        Console.Write("Введите y: ");
        double.TryParse(Console.ReadLine(), out y);
        if ((x * x + y * y < 4) && (x * x + y * y > 1) && (y > 0))
        {
            Console.WriteLine("inside");
        };
        if ((x * x + y * y == 4) || (x * x + y * y == 1) || ((y==0) && ((x*x>=1)||(x*x<=4))))
        {
            Console.WriteLine("border");
        };
        if ((x * x + y * y > 4) || (x * x + y * y < 1) ||(y<0))
        {
            Console.WriteLine("outside");
        };
    }
}   