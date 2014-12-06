

namespace school
{
    class University
    {
        public static Faculty createFaculty(string name)
        {
            Faculty fac = new Faculty(name);
            return fac;
        }
    }


}


namespace school
{
    class Faculty
    {
        public static int CLOSED = 1;
        public int status;

        private string name;
        public Faculty(string name)
        {
            this.name = name;
        }
        public Department openNewDepartment(string name)
        {
            return new Department(name, this);
        }
    }
}

namespace school
{
    class Department
    {
        private string name;
        private Faculty myfaculty; 
        public Faculty Faculty{
            get { return myfaculty; }
        }
        public Department(string name, Faculty fac )
        {
            this.name = name;
            this.myfaculty = fac;
        }
        public void addStudent(Student st){
            st.dept = this; 
        }
    }
}

namespace school
{
    class Student
    {
        private string fname;
        private string lname;
        public Department dept;
        public Student(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
    }
}

namespace school
{

    class Course
    {
        private string name;

        // constructor 

    }
}
