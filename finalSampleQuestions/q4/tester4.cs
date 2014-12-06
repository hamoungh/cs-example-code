using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class tester4
    {
        public static void Main()
        {
            Boy a = new Boy();
            Boy b = new Boy();
            Boy c = new Boy();
            List<Boy> boys = new List<Boy>();
            boys.Add(a);
            boys.Add(b);
            boys.Add(c);

            Girl q = new Girl();
            Girl r = new Girl();
            a.girlfriend = q;
            b.girlfriend = q;


        }
    }
}
