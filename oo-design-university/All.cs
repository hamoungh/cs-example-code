﻿using System;

namespace school
{
    public class University
    {
        //declare a field called faculty with the type Faculty
        private Faculty faculty;
        //declare a property called Faculty with the type Faculty
        public Faculty Faculty
        {
            set { this.faculty = value; }
            get { return this.faculty; }
        }
        static int count = 0;
        public static Faculty createFaculty(string facultyname)
        {
            count++;
            return new Faculty(facultyname);
        }
        public static int numberOfFaculties()
        {
            int number = count;
            return number;
        }
    }
    public class Faculty
    {
        private string Name;
        public Faculty(string name)
        {
            this.Name = name;
        }
        public Department openNewDepartment(string departmentname)
        {
            return new Department(departmentname, this);
        }
        public bool status;
        public static bool CLOSED = false;
        public static bool OPEN = true;
    }
    public class Department
    {
        //declare a field called faculty with the type Faculty
        private Faculty faculty;
        //declare a property called Faculty with the type Faculty
        public Faculty Faculty
        {
            set { this.faculty = value; }
            get { return this.faculty; }
        }
        private string Name;
        public Department(string name)
        {
            this.Name = name;
        }
        public Department(string name, Faculty fac)
        {
            this.Name = name;
            this.faculty = fac;
        }
        public Course addCourse(string coursename)
        {
            return new Course(coursename);
        }
        private Student student;
        /*public Student Student
        {
            set { this.student = value; }
            get { return this.student; }
        }*/
        public void addStudent(Student student)
        {
            this.student = student;
            student.Department = this;
        }
        public void enterGradeForStudent(Student student, Course course, int grade)
        {
            student.enterGrade(course, grade);
        }
    }
    public class Student
    {
        private string FirstName;
        private string LastName;
        public Student(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        private Department department;
        public Department Department
        {
            set { this.department = value; }
            get { return this.department; }
        }
        public Student(string fname, string lname, Department Department)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Department = Department;

        }
        private double[] studentgrade = new double[4];
        private int coursecount = 0;
        public void enterGrade(Course course, int grade)
        {
            coursecount++;

            studentgrade[coursecount - 1] = grade;
        }
        public double calculateAverage()
        {
            double gradesum = 0;
            for (int i = 0; i < coursecount; i++)
            {
                gradesum = gradesum + studentgrade[i];
            }
            double average = gradesum / coursecount;
            return average;
        }
        public bool hasFailed()
        {
            if (calculateAverage() < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Course
    {
        private string Name;
        public Course(string name)
        {
            this.Name = name;
        }
    }

}

