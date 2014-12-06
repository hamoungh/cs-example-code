
namespace school
{
    class Department
    {
        private string name;
        private Faculty faculty; 
        public Faculty Faculty
        {
            get { return faculty; }
        }

        public Department(string name)
        {
            this.name = name;
        }
    }
}
