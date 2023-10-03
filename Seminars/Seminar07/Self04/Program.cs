using System;
public class Program
{
    static void Python(int n)
    {
        (int x, int y) = Console.GetCursorPosition();
        int PosY = y, PosX = x;
        for(int k = 0; k<n;k++)//рисуем несколько изломов друг за другом
        {
            PosX = x+4*k;
            for (int i = 0; i < n; i++) //рисует один излом
            {
                if(i == 0)
                {
                    Console.SetCursorPosition(PosX,PosY);
                    Console.Write("***");
                }
                else 
                {
                    Console.SetCursorPosition(PosX,PosY);
                    Console.Write("* *");
                }
                if(i == n-1)
                {
                    if(k!=n-1)
                    {
                        Console.SetCursorPosition(PosX+3,PosY);
                        Console.WriteLine("*");
                    }
                }
                PosY++;
            }
            PosY = PosY - n;
        }
    }
    static void Main(string[] args)
    {
        Python(5);
    }
}  