using System;

public class Program
{
    static void Main(string[] args)
    {
        int k;
        double s = 0;
        Console.WriteLine("Введите число: ");
        int.TryParse(Console.ReadLine(), out k);
        for(double x = 1; x<=k;x++)
        {
            s+=1/x;
        }
        Console.WriteLine("Sum = {0:N4}", s);

    }
}   