using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    // coded by microsoft, cannot be changed 
    class Person  
    {
        public string name;
        public Person() { }
        public Person(string name)
        {
            this.name = name; 
        }
        public void print()
        {
            Console.WriteLine(
                "myname is " + getFullName());
        }
        public virtual string getFullName()
        {
            return name;
        }
    }
    // method hiding 
    // overriding 
    class PersonWithLastName : Person  
    {
        public string lastname;
        public PersonWithLastName():base("empty")
        {
            lastname = "empty"; 
        }
        public PersonWithLastName(string fname, string lname)
            : base(fname)
        {
            lastname = lname; 
        }
        public override string getFullName()
        {
            return (base.getFullName() + " " + lastname);
            // return name + " " + lastname; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p2;
            p2 = new PersonWithLastName( "james", "robson");
            p2.print();
        }
    }
}
