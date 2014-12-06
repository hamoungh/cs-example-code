using System;
using school;

namespace testschool
{



    public class Tester
    {
        static void Main1()
        {
            Faculty scienceFac = University.createFaculty("Science");
            Department compSciDept = scienceFac.openNewDepartment("Computer Science");
            Department physicsDept = scienceFac.openNewDepartment("Physics");
            Console.WriteLine(Object.ReferenceEquals(
                scienceFac, physicsDept.Faculty)); //expected to return scienceFac object
            Console.WriteLine(University.numberOfFaculties());


            Faculty engineeringFac = University.createFaculty("Engineering");
            // Our engineering faculty does not have any department yet
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
            Student st2 = new Student("James", "Hetfield", physicsDept);
            Console.WriteLine(Object.ReferenceEquals(
                st2.Department, physicsDept));  // 8uusame thing for the student2v18 X is the

            // enter marks for student one Using the method of the student class
            st2.enterGrade(c1, 60);
            st2.enterGrade(c2, 20);
            double aaverage = st2.calculateAverage();

            // Enter the marks for student two using a method From the department class
            compSciDept.enterGradeForStudent(st1, c1, 22);
            compSciDept.enterGradeForStudent(st1, c2, 21);
            Console.WriteLine(st2.calculateAverage());
            if (!st1.hasFailed())
            { // if average is less that 50 student has failed 
                Console.WriteLine("has passed");
            }


        }
    }
}
