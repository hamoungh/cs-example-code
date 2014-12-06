using System;



class Program
{
    static string TestStringOut(string str)
    {
        string str_out = str + ". so what?";
        return str_out; 
    }
    static int TestInOut(int i)
    {
        Console.WriteLine("hello world  " + i);
        return i*2;
    }
    static void TestInt(int i)
    {
        Console.WriteLine("hello world  "+i);
    }
    static void Test()
    {
        Console.WriteLine("hello world");
    }
    static void Main(string[] args)
    {
        string ret=TestStringOut("xxxxxxxxxx");
       // int j=TestInOut(TestInOut(8));
       Console.WriteLine(ret);

    }
}
