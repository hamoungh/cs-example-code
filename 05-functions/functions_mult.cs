using System;

// write a new function  that takes number
// and multiplies it by 2
// and prints the result 
// test the function from Main
// call it multNum 
class Program
{

    static int multNums(int i, int j)
    {
        int k=i*j;
        return k; 
    }

    static int multNum(int i)
    {
        int j=i*2;
        return j; 
    }

    static void Main(string[] args)
    {
        Console.WriteLine(multNums(9, 8));
    }
}
