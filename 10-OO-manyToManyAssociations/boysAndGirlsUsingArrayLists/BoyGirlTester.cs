using System;


class Program
{
    static void Main(string[] args)
    {
        Boy a = new Boy("a"),
            b = new Boy("b"),
            c = new Boy("c");
        Girl p = new Girl("p"),
             q = new Girl("q");
        // graph

        p.boyfriends.Add(a);
        // which one of p's boyfriends 
        // does not think he is p's boyfriend 
            if (!a.girlfriends.Contains(p))
                Console.WriteLine(a.name);
    }
}
