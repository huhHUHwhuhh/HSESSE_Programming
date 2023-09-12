using System;
public class Program {
    static void Main(string[] args) {
        Console.Write("Введите длину 1 катета: ");
        double K1 = double.Parse(Console.ReadLine());
        Console.Write("Введите длину 2 катета: ");
        double K2 = double.Parse(Console.ReadLine());
        double H = Math.Sqrt(K1*K1 + K2*K2);
        Console.WriteLine("Гипотенуза: " + H);
    }
}