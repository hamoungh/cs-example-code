using System;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] myIntArray = new int[5];
            for (int i = 0; i < myIntArray.Length; i++ )
                myIntArray[i] = 5;*/

            int[] locX = new int[100];
            int[] locY = new int[100];
            // populate with 10 random numbers between 1 and 10
            Random rand = new Random();
            for (int i = 0; i < locX.Length; i++)
            {
                locX[i] = rand.Next(1, 20);
                locY[i] = rand.Next(1, 20);
            }
            // what enemies are less than 3 units away 
            // player ->(10,5)

            for (int i = 0; i < locX.Length; i++)
            {
                double distance =
                    Math.Sqrt(
                        Math.Pow(locX[i] - 10, 2) +
                        Math.Pow(locY[i] - 5, 2));
                if (distance<3)
                {
                    Console.SetCursorPosition(locX[i], locY[i]);
                    Console.Write("o");
                }
            }
            Console.SetCursorPosition(10,5);
            Console.Write("+");
            Console.ReadKey();


        }
    }
}
