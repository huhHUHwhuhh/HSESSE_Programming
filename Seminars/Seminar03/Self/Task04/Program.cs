using System;
using System.Runtime.Serialization;

public class Program
{
    static void Main(string[] args)
    {
        double x, y, rez;
        Console.Write("Введите х: ");
        double.TryParse(Console.ReadLine(), out x);
        Console.Write("Введите y: ");
        double.TryParse(Console.ReadLine(), out y);
        if (x < y)
        {
            rez = Math.Sin(x) + Math.Cos(y) * Math.Cos(y);
        } else if (x == y)
        {
            rez = Math.Log(x);
        }else
        {
            rez = Math.Sin(x * x) + Math.Cos(y);
        }
        Console.WriteLine("x: {0} y: {1} result {2}",x,y,rez);
                
    }
}