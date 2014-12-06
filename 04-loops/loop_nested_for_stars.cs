using System;

class Program
{ 
    // write a program that outputs a N*N square of stars 
    // read N from input  
    static void Main(string[] args)
    {
        int N=int.Parse(Console.ReadLine()); 
        for (int j = 10; j >0; j--){
            for (int i = 1; i <= N; i++){
                Console.Write(j);
            }
            Console.Write("\n");
        }

    }
}

