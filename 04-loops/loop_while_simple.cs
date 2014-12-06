using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfIterations = 100; 
        int counter = 0;
        while (counter <= numberOfIterations) 
        {
            Console.WriteLine("this is iteration : {0}",counter);
            counter=counter+1;
        }
    }
}
