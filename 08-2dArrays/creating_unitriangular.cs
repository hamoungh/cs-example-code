using System;

namespace multidimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];
            // intialize m[i,j]=5 
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (i < j)
                        m[i, j] = 1;
                    else
                        m[i, j] = 0;
                }
            //-------------------------------
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(m[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
