using System;

public class Program
{
    static void Main(string[] args)
    {
        double A, N, S = 0;
        int i = 0;
        Console.Write("Введите А: ");
        double.TryParse(Console.ReadLine(), out A);
        Console.Write("Введите N: ");
        double.TryParse(Console.ReadLine(), out N);
        while(i<=N)
        {
            S +=((A-i*A/N)*(A-i*A/N))*(A/N);
            ++i;
        }
        Console.WriteLine("S = " + S);
    }
}   