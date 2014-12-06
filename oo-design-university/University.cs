

namespace school
{
    class University
    {
        public static Faculty createFaculty(string facName)
        {
            //Faculty f = new Faculty(facName);
            //return f;
            return new Faculty(facName);
        }
    }
}
