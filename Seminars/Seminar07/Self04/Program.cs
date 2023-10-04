using System;
public class Program
{
    
    
    static void PythonAnimation(int n)
    {
        (int x, int y) = Console.GetCursorPosition();
        int size = n*4;
        int[,] indexes = new int[n, size];
        for (int i = 0; i < n; i++)
        {
            for (int j = size-1; j >= 0; j--)
            {
                if(j%2==0)
                {
                    indexes[i,j]=1;
                }
                else if(j%2==1 && (j+1)%4!=0 && i == 0)
                {
                    indexes[0,j]=1;
                } 
                else if((j+1)%4==0 && i == n-1)
                {
                    indexes[n-1,j]=1;
                }
            };
        };
        indexes[n-1, size-1] = 0;

        // for (int i = 0; i < size; i++)
        // {
        //     for (int j = 0; j < size; j++)
        //     {
        //         Console.Write(indexes[i,j]);
        //     };
        //     Console.WriteLine();
        // };

        string State = "up";
        Console.WriteLine();
        (int PosX, int PosY) = Console.GetCursorPosition();

        for (int j = 0; j < size-1; j++)
        {
            if((State == "up") || (State == "up2"))
            {
                for (int i = n-1; i >= 0; i--)
                {
                    if(indexes[i,j]==1)
                    {
                        Console.SetCursorPosition(PosX+j,PosY+i);
                        
                        Console.Write("*");
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Console.SetCursorPosition(PosX+j,PosY+i);
                        Console.Write(" ");
                    }
                
                }
                //Console.Write("**");
                if(State == "up")
                {
                    State = "up2";
                }
                else if(State == "up2")
                {
                    State = "down";
                }else if(State == "down")
                {
                    State = "down2";
                }else if(State == "down2")
                {
                    State = "up";
                }
            }
            else if((State == "down") || (State == "down2"))
            {
                for (int i = 0; i <= n - 1 ; i++)
                {
                    if(indexes[i,j]==1)
                    {
                        
                        Console.SetCursorPosition(PosX+j,PosY+i);
                        
                        Console.Write("*");
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Console.SetCursorPosition(PosX+j,PosY+i);
                        Console.Write(" ");
                    }
                
                }
                if(State == "up")
                {
                    State = "up2";
                }
                else if(State == "up2")
                {
                    State = "down";
                }else if(State == "down")
                {
                    State = "down2";
                }else if(State == "down2")
                {
                    State = "up";
                }
            }
            
        };
        Console.SetCursorPosition(PosX+size,PosY+n);
        Console.WriteLine();

    }

    static void Main(string[] args)
    {
        Console.Clear();
        PythonAnimation(5);
    }
}  