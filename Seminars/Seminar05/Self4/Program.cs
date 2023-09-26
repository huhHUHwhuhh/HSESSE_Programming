using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(double.Epsilon);
        double x,sum = 0, rez;
        for(x=1;(1/((x)*(x+1)*(x+2)))>Double.Epsilon;x++)
        {
            //Console.Write((1/((x)*(x+1)*(x+2))) + "  ");
            //Console.WriteLine((1/((x)*(x+1)*(x+2)))>Double.Epsilon);
            rez = 1/((x)*(x+1)*(x+2));
            sum+=1/rez;
        }
        Console.WriteLine("Sum: "+sum);
    }
}   