using System;

public class Program
{
    static void Main(string[] args)
    {
        for(int x=0;x<=50;x++)    
        {
            if(x%6==0)
            {
                Console.WriteLine(x+", Число делится на 2 и на 3");
            }else if(x==20)
            {

            }else
            {
                Console.WriteLine(x+", Число не соответсвует условиям");
            }
        }
    
    }
}   