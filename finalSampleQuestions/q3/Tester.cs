using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Tester
    {
        public void Main()
        {
            string[] input = { "hello", "hi", "bye", "ta" };
            string[] output = new Q3().SortStrings(input);
            foreach (string s in output)
                Console.WriteLine(s);
        }
    }
}
