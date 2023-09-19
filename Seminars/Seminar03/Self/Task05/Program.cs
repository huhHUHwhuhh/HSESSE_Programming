using System;
using System.Runtime.Serialization;

public class Program
{
    static void Main(string[] args)
    {
        double a, b, c,D;
        string x1, x2;
        Console.Write("Введите a: ");
        double.TryParse(Console.ReadLine(), out a);
        Console.Write("Введите b: ");
        double.TryParse(Console.ReadLine(), out b);
        Console.Write("Введите c: ");
        double.TryParse(Console.ReadLine(), out c);
        Console.WriteLine("Ваше уравнение: {0}*x^2+{1}*x+{2}=0", a, b, c);
        D = b * b - 4 * a * c;
        if (D > 0) 
        {
            x1 = String.Format("{0}",(-b+Math.Sqrt(D))/(2*a));
            x2 = String.Format("{0}", (-b - Math.Sqrt(D)) / (2 * a));
            Console.WriteLine("Корни: {0}, {1}",x1,x2);
        }else if (D == 0)
        {
            x1 = String.Format("{0}", (-b + Math.Sqrt(D)) / (2 * a));
            Console.WriteLine("Дискриминант = 0, поэтому x1 = x2 = {0} ", x1);
        }
        else
        {
            D = Math.Abs(D);
            x1 = String.Format("{0}", ((-b) / 2 * a));
            x1 = x1 + "+" + String.Format("{0}", (Math.Sqrt(D) / (2 * a))) + "*i";
            x2 = String.Format("{0}", ((-b) / 2 * a));
            x2 = x2 + "-" + String.Format("{0}", (Math.Sqrt(D) / (2 * a))) + "*i";
            Console.WriteLine("Решения в комплексных числах: x1 = {0}, x2 = {1}", x1, x2);
        }

    }
}