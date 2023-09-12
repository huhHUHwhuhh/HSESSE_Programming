
﻿using System;

public class Program {
    static void Main(string[] args) {
        Console.Write("Введите напряжение: ");
        double U = double.Parse(Console.ReadLine());
        Console.Write("Введите сопротивление: ");
        double R = double.Parse(Console.ReadLine());
        double I = U/R;
        double P = U*U/R;
        Console.WriteLine("Сила тока I = " + I);
        Console.WriteLine("Мощность P = " + P);
    }
}