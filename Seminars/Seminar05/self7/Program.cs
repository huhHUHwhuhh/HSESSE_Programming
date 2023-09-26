using System;

public class Program
{
    static void Main(string[] args)
    {
        int x;
        string rez = "";
        Console.Write("Введите число: ");
        int.TryParse(Console.ReadLine(), out x);
        while(x>0)
        {
            rez = rez + Convert.ToString(x%10);
            x = x/10;
        };
        
        while(rez[0]=='0')
        {
            rez = rez.Remove(0,1);
        };
        Console.WriteLine(rez);
    }
}   