using System;
public class Program
{
    static void Triangle(int N)
    {
        if(N<=0)
        {
            return;
        }
        
        int spaces, stars;
        for(stars=1,spaces = N-1;stars<=N;stars++,spaces--)
        {
            for (int i = 1; i <= stars; i++)
            {
                Console.Write("*");
            }
            for (int i = 1; i <= spaces; i++)
            {
                Console.Write(" ");
            }
        Console.WriteLine();
        }
    }
    static void Ornament(int N, int M)
    {
        if(M<=0)
        {
            return;
        }
        for(int i = 1; i<=M;i++)
        {
            Triangle(N);
        }
    }
    static void Main(string[] args)
    {
        Ornament(5,3);
    }
}  
