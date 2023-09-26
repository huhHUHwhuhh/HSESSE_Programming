using System;

public class Program
{
    static void Main(string[] args)
    {
        for (var i = 100; i <= 999; i++)
        {
            if(i%111 == 0)
            {
                Console.WriteLine(i);
            }            
        }
    }
}   