using System;

namespace numToDay
{
    class Program
    {
        static string DigitAsString(int num)
        {
            int last_digit = num % 10;
            string str="";
            switch (last_digit)
            {
                case 1: str = "one"; break;
                //....
            }
           //  if (last_digit==1) str=="one"
           // else ...,.
            return str; 
        }
        static void Main(string[] args)
        {
      
        }
    }
}
