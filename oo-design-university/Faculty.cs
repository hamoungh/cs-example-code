
namespace school
{
    class Faculty
    {
        private string name;
        public Faculty(string name) {
            this.name = name;
        }
        public Department openNewDepartment(string deptname)
        {
            return new Department(deptname);
        }
    }
}
