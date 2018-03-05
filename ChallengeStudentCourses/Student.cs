using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            this.StudentId = 0;
            this.Name = "undefined";
            this.Courses = new List<Course>();

        }
            
        public Student(int studentID, string Name, List<Course> course)
        {
            this.StudentId = studentID;
            this.Name = Name;
            this.Courses = new List<Course>(course);
        }

        public string PrintStudentDetails()
        {
            string result = "";

            result = String.Format("<h3>{0} - {1}</h3>", this.StudentId, this.Name);

            foreach (Course course in this.Courses)
            {
                result += course.Name + "<br/>";

            }

            return result;

        }

    }

    

}