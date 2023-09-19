using System;

public class Program
{
    static void Main(string[] args)
    {
        double l, n;
        Console.Write("Введите количество сторон: ");
        do
        {
            double.TryParse(Console.ReadLine(), out n);
            if (n < 3 || n > 11)
            {
                Console.Write("Количество сторон должно быть больше 3, но меньше 11, введите заново: ");
            }
            else
            {
                break;
            }
        } while (true);
        Console.Write("Введите длину стороны: ");
        do
        {
            double.TryParse(Console.ReadLine(), out l);
            if (l <= 0)
            {
                Console.Write("Длина стороны должна быть больше 0, введите заново: ");
            }
            else
            {
                break;
            }
        } while (true);
        double S = (n * l * l) / (4 * Math.Tan((Math.PI) / n));
        Console.WriteLine("Площадь:" + S);
    }
}