using System;
public class Program
{
    static void Triangle(int N, int PosX, int PosY)
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
                Console.SetCursorPosition(PosX,PosY);
                Console.Write("*");
                PosX++;
            }
            for (int i = 1; i <= spaces; i++)
            {
                Console.SetCursorPosition(PosX,PosY);
                Console.Write(" ");
            }
            PosX = PosX - stars;
            PosY++;

        }
        Console.SetCursorPosition(PosX,PosY);
    }
    static void Ornament(int N, int M)
    {
        (int x, int y) = Console.GetCursorPosition();
        int PosY = y;
        if(M<=0)
        {
            return;
        }
        for(int i = 0; i<M;i++)
        {
            int PosX = i*N + x;
            Triangle(N,PosX, PosY);
        }
    }
    static void Main(string[] args)
    {
        Ornament(6,5);
    }
}  