using System;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=100;
            int[] x= new int[n];
            int[] y = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i]=r.Next(1, 40);
                y[i] = r.Next(1, 40);
            }
            // show only the enemies that are 
            // close to  the player (less than 5 unit distance)
            for (int i = 0; i < n; i++)
            {
                double distance =
                   Math.Sqrt(
                   Math.Pow(x[i] - 10, 2) +
                   Math.Pow(y[i] - 10, 2));
                if (distance < 5)
                {
                    gotoxy(x[i], y[i]); Console.Write("o");
                }
            }
            gotoxy(10, 10); Console.Write("+");
            Console.ReadKey();
        }
        public static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, 40 - y);
        }
    } 
 
}
