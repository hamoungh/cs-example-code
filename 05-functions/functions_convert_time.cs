using System;


class Program
{
    //write a function that converts pst time to est and prints it 
    // will get pst time 
    // converts it to toronto time and prints it 
    static void ConvertTimes(int pstTime)
    {
        int est = pstTime + 3;
        if (est > 24) Console.WriteLine(est - 24);
        else Console.WriteLine(est);
         // Console.WriteLine((pstTime + 3) % 24); 
    }

    static void Main(string[] args)
    {
        int pst = int.Parse(Console.ReadLine());
       ConvertTimes(pst);  //10 pm pst == 22 pst == 25%24 = 1 am est 
    }
 }

