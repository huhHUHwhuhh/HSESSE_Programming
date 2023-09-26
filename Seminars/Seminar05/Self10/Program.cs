using System;

public class Program
{
    static double G(double x)
    {
        if(x<=0.5)
        {
            return(Math.Sin(Math.PI/2));
        }
        else
        {
            return(Math.Sin(((x-1)*Math.PI)/2));
        }
    }
    static void Main(string[] args)
    {
        double x;
        Console.Write("Введите число: ");
        double.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("G(X) = "+ G(x));
    }
}   
