using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }


        public Course()
        {
            this.CourseId = 0;
            this.Name = "Undefined";
            this.Students = new List<Student>();

        }

        public Course(int courseID, string name, Student student)
        {
            this.CourseId = courseID;
            this.Name = name;
            this.Students = new List<Student> { student };
        }

        public string PrintCourseName()
        {
            return String.Format("<h3>Course ID: {0} - {1} <h3>", this.CourseId, this.Name);
            
        }

        public string PrintCourseDetails()
        {
            string result = String.Format("<H2>{0} - {1}</H2>",
                this.CourseId,
                this.Name);
            foreach  (Student student in this.Students)
            {
                result += student.StudentId + " - " + student.Name;
            }
            return result;
        }

    }
}