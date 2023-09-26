using System;

public class Program
{
    static void Main(string[] args)
    {
        double x, y;
        Console.Write("Введите Х: ");
        double.TryParse(Console.ReadLine(), out x);
        Console.Write("Введите Y: ");
        double.TryParse(Console.ReadLine(), out y);
        if((x*x+y*y<=4)&&(x>=0)&&(y<=x))
        {
            Console.WriteLine("True");
        }else
        {
            Console.WriteLine("False");
        }
    }
}   