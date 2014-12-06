using System;
using school;

namespace testschool
{



    public class Tester
    {
        static void Main()
        {
            Faculty scienceFac = University.createFaculty("Science");
            Department compSciDept = scienceFac.openNewDepartment("Computer Science");
            Department physicsDept = scienceFac.openNewDepartment("Physics");
            Console.WriteLine(Object.ReferenceEquals(
                scienceFac, physicsDept.Faculty)); //expected to return scienceFac object

            // have to define static field inside Faculty class and
            // increament it every time you make a new faculty 
            // (i.e. in the constructor)
            // create a static integer  field inside Faculty 
            // and increament  it every time you create an object (in constructor)
            Console.WriteLine(University.numberOfFaculties());

            Faculty engineeringFac = University.createFaculty("Engineering");
            // Our engineering faculty does not have any department yet
            // status is  a field inside Faculty class 
            // 
            engineeringFac.status = Faculty.CLOSED;

            // Let's create some courses in our department 
            Course c1 = compSciDept.addCourse("theory of computation");
            Course c2 = compSciDept.addCourse("computer graphics");


            // One can create a student and then add it to the department 
            Student st1 = new Student("Alan", "Turing");
            compSciDept.addStudent(st1);
            Console.WriteLine(Object.ReferenceEquals(
                compSciDept, st1.Department)); // this should return the object (referenced by) compSciDept

            // One can create this student at the same time specify the department
            // define a constructor in Student with 3 arguments
            // store a reference student's department inside Student class
            Student st2 = new Student("James", "Hetfield", physicsDept);
            Console.WriteLine(Object.ReferenceEquals(
                st2.Department, physicsDept));  // same thing for the student

            // enter marks for student one Using the method of the student class
            st2.enterGrade(c1, 60);
            st2.enterGrade(c2, 20);
            double average = st2.calculateAverage();

            // Enter the marks for student two using a method From the department class
            compSciDept.enterGradeForStudent(st1, c1, 22);
            compSciDept.enterGradeForStudent(st1, c2, 21);
            Console.WriteLine(st2.calculateAverage());
            if (!st2.hasFailed())
            { // if average is less that 50 student has failed 
                Console.WriteLine("has passed");
            }


        }
    }
}
