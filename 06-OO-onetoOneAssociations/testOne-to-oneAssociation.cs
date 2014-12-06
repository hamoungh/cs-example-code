using System;
using System.Collections.Generic;

class testListOfCustomObj
{
    public static void Main()
    {
        Boy a = new Boy();
        Boy b = new Boy();
        Boy c = new Boy();


        Girl q = new Girl();
        Girl r = new Girl();
        a.girlfriend = q;
        b.girlfriend = q; 


    }
}

