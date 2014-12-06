
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] staticS = { "canada", "usa", "cuba" }; 
        List<string> s = new List<string>(staticS);
        /*s.Add("canada");
        s.Add("usa");
        s.Add("cuba");*/
        for (int i = 0; i < s.Count; i++)
            Console.WriteLine(s[i]);
        Console.WriteLine("--------");
        s.Sort();
        foreach(string ss in s)
            Console.WriteLine(ss);
    }
}
