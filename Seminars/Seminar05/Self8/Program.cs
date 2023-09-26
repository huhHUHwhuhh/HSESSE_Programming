using System;

public class Program
{
    static void Main(string[] args)
    {
        int k;
        string x;
        Console.Write("Введите число: ");
        x = Console.ReadLine();
        Console.Write("Введите N: ");
        int.TryParse(Console.ReadLine(), out k);
        if(k<=x.Length)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(x[i]);
            }
        }else
        {
            Console.Write("Error");
        }
        
    }
}   