using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class tester2
    {
        public static void Main()
        {
            int[] x = new int[50];
            int[] y = new int[50];
            new Q2().GenerateRandomCoordinates(x, y);
        }
    }
}
