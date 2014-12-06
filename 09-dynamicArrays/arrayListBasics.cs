using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // declaration
        int[] i;
        List<int> j;
        // instantiation 
        i=new int[10];
        j = new List<int>();
        //inserting elements
        i[0] = 5;
        j.Add(5); 
        //accessing
        Console.WriteLine(i[0]);
        Console.WriteLine(j[0]);
        if (j.Contains(5))
            Console.WriteLine("it has 5");
        Console.WriteLine(j.Count);
        j.IndexOf(1000); // searches for 1000
        j.Insert(5, 1000000);
        j.Sort();




    }
}

