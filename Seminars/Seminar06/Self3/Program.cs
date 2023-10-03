using System;

public class Program
{
    static void Main(string[] args)
    {
        string s;
        char a1,a2,a3,a4;
        int count=0;
        for(int x=2000; x<=3000;x++)
        {
            s = Convert.ToString(x);
            a1 = s[0];
            a2 = s[1];
            a3 = s[2];
            a4 = s[3];
            if((a1==a2||a1==a3||a1==a4)||(a2==a3||a2==a4)||(a3==a4))
            {

            }
            else
            {
                count++;
                Console.WriteLine(s);
            }
        }
    }
}   