using System;
using System.Collections.Generic;

class q1
{
    static void PrintSentence(string str){
        Console.WriteLine("[ {0} ]",str);
    }

    static void CompareNumbers(int i, int j)
    {
        if (i > j)  PrintSentence("first one was bigger");
        else PrintSentence("second one was bigger"); 
    }

    static void Main(string[] args)
    {
        PrintSentence("toronto");
    }
}

