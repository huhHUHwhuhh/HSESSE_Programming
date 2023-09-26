using Internal;
using System;

public class Program
{
    static void Main(string[] args)
    {
        int IntCount = 0, DoubleCount = 0, NumCount = 0;
        double x;
        do
        {
            Console.Write("Введите число: ");
            double.TryParse(Console.ReadLine(), out(x));
            if(x==0)
            {
                break;
            }
            if(x==Convert.ToInt32(x))
            {
                ++IntCount;
            }else
            {
                ++DoubleCount;
            };
            ++NumCount;
        }while(true);   
        Console.WriteLine("Количество введенных целых чисел: " + IntCount); 
        Console.WriteLine("Количество введенных ввещественных чисел: " + DoubleCount);
        Console.WriteLine("Количество введенных чисел: " + NumCount);
    }
}   
