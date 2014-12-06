
using System;
using System.Collections.Generic;
using System.Reflection;

class Tester
{
    static void testFacultyCreation()
    {
        // Faculty scienceFac = University.createFaculty("Science");
        Type univType = Type.GetType("school.University");
        Object scienceFac = Type.GetType("school.University")
            .GetMethod("createFaculty")
            .Invoke(null, new object[] { "Science" });
        //Faculty engineeringFac = University.createFaculty("Engineering");
        Object engineeringFac = univType.GetMethod("createFaculty")
            .Invoke(univType, new object[] { "Engineering" });
        // if (University.numberOfFaculties()!=2) 
        //     throw new Exception( "I was expecting to faculties to be created "); 
        if ((int)(univType.GetMethod("numberOfFaculties")
              .Invoke(univType, new object[0])) != 2)
            throw new Exception("I was expecting to faculties to be created ");

    }
    static void testDepartmentCreation()
    {
        //            Faculty scienceFac = University.createFaculty("Science");
        object scienceFac = Type.GetType("school.University")
            .GetMethod("createFaculty")
         .Invoke(null, new object[] { "Science" });

        // Department compSciDept = scienceFac.openNewDepartment("Computer Science");
        object physicsDept = Type.GetType("school.Faculty").GetMethod("openNewDepartment")
            .Invoke(scienceFac, new object[] { "Physics" });

        /* if(!Object.ReferenceEquals(
             scienceFac, physicsDept.Faculty))
             throw new Exception("Failed to set the field faculty"+
                         "in the Department object in the method openNewDepartment"); */
        if (!Object.ReferenceEquals(scienceFac,
            Type.GetType("school.Department").GetProperty("Faculty")
            .GetMethod.Invoke(physicsDept, new object[0])))
            throw new Exception("Failed to set the field faculty" +
                        "in the Department object in the method openNewDepartment");
    }

    static void testStudentCreation()
    {
        object scienceFac = Type.GetType("school.University")
            .GetMethod("createFaculty")
            .Invoke(null, new object[] { "Science" });

        object compSciDept = Type.GetType("school.Faculty")
            .GetMethod("openNewDepartment")
            .Invoke(scienceFac, new object[] { "Computer Science" });

        object st1 = Activator.CreateInstance(Type.GetType("school.Student"),
            new object[] { "Alan", "Turing" });

        Type.GetType("school.Department").GetMethod("addStudent")
            .Invoke(compSciDept, new object[] { st1 });


        if (!Object.ReferenceEquals(compSciDept,
         Type.GetType("school.Student").GetProperty("Department")
         .GetMethod.Invoke(st1, new object[0])))
            throw new Exception("Failed to set the field department" +
                        "in the Student object in the method Department.addStudent(...)");
    }

    static void testAveraging()
    {
        Type type = Type.GetType("school.Student");
        MethodInfo enterGrade = type.GetMethod("enterGrade");
        object st = Activator.CreateInstance(type,
            new object[] { "fname", "lastname" });
        enterGrade.Invoke(st, new object[] { new school.Course("c1"), 21 });
        enterGrade.Invoke(st, new object[] { new school.Course("c2"), 22 });
        object result = type.GetMethod("calculateAverage").Invoke(st, null);
        if ((double)result != 21.5)
            throw new Exception("Average of 21 and 22 Should be 21.5");
    }   

    static void fieldcheck(string fullClassName, string fieldname)
    {
        List<string> s = new List<string>();
        foreach (FieldInfo fi in Type.GetType(fullClassName).GetFields(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance))
            s.Add(fi.Name);
        if (!s.Contains(fieldname)) throw
            new Exception("could not find the field " + fieldname);
    }

    static void testFields()
    {
        fieldcheck("school.Student", "fname");
        fieldcheck("school.Student", "lname");
        fieldcheck("school.Department", "name");
        fieldcheck("school.Faculty", "name");
        fieldcheck("school.Course", "name");
    }
    static void testConstructors()
    {
        /*  if (Type.GetType("school.Student").GetConstructor(
             new Type[] { typeof(string), typeof(string) }) == null)
              throw new Exception("no (string,string) constructor for Student"); 
          */
        Type type = Type.GetType("school.Student");

        object st = Activator.CreateInstance(type,
            new object[] { "fname", "lastname" });


    }
    static void typetest(string name)
    {
        if (Type.GetType(name) == null) throw new Exception("There's no class " + name);
    }
    static void testClassExistence()
    {
        typetest("school.University");
        typetest("school.Faculty");
        typetest("school.Department");
        typetest("school.Course");
        typetest("school.Student");
    }
    static void Main()
    {
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1) testClassExistence();
        // else if (choice == 2) testFields();
        else if (choice == 2) testConstructors();
        else if (choice == 3) testAveraging();
        else if (choice == 4) testFacultyCreation();
        else if (choice == 5) testDepartmentCreation();
        else if (choice == 6) testStudentCreation();  
    }
}
