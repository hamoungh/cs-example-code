
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
