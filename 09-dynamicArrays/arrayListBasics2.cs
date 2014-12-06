using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynaArray
{
    class Program
    {
        static void Main1(string[] args)
        {
            // declaration 
            int[] a; // static array
            List<int> b; //dynamic

            // instantiate
            a=new int[100];
            b = new List<int>();

            // inserting an element 
            a[0] = 10000;
            b.Add(10000);

            List<string> ss = new List<string>();
            ss.Add("test1");
            ss.Add("test2");
            for (int i = 0; i < ss.Count; i++)
            {
                Console.WriteLine(ss[i]);
            }

            foreach (string s in ss)
            {
                Console.WriteLine(s);
            }
            int[] aa = {4,99,200 };
            List<int> list = new List<int>(aa);
            
            //find all the  elements
            // in the array that are > 80 
            //int result=list.Find(item => item > 80);
            //Console.WriteLine(result);
            foreach (int i in list)
                if (i>80) Console.WriteLine(i);
        
            // sort them alphabetically (list.sort)
            string[] f = { "toronto", "kingston", "antwerp" };
            List<string> sr = new List<string>(f);
            sr.Sort();
            foreach (string s in sr)
                Console.WriteLine(s);






        }
    }
}
 