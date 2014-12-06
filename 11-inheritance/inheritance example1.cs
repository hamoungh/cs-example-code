using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Person {
        public string name; 
        public Person(string p)
        {
            this.name = p;
        }
        public virtual void print()
        {
            Console.WriteLine(name); 
        }
    }
    class TitledPerson : Person {
        string title;
        public TitledPerson(string name, string title)
            : base(name) 
        {
            this.title = title; 
        }
        public override  void print()
        {
            Console.WriteLine( title+" "+name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("aa");
            a.print(); 
            Person b = new TitledPerson("james", "dr");
            b.print(); 

        }
    }
}
