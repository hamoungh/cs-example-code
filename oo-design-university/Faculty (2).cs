
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
            return new Department(name,this);
        }
    }
}
