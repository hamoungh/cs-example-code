
// Write a program that reads from the console 
// a sequence of 5 integer numbers and returns
// the maximum of them.

using System;
  class Program
  {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write("enter the number of items:"); 
            int numCount = int.Parse(Console.ReadLine());
            double sum = 0; 
            while (i <= numCount) {
                Console.Write("enter number {0}:", i);
                int num = int.Parse(Console.ReadLine());
                sum += num; //sum = sum + num;
                i++; // i = i + 1;
            }
            // double average = sum/numCount; 
            Console.WriteLine("sum is {0} and average is:{0}",
                sum, sum/numCount); 
        }
  }
