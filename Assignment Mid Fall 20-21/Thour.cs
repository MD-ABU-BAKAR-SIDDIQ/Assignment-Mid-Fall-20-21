using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Thour
    {
        public string CourseName { get; set; }
        public int CourseCreditNumber { get; set; }
        public departments Departments { get; set; }
        course[] courses;
        public int CreditCount { get; set; }
        public Thour()
        {
            courses = new course[5];
        }
        public Thour(string courseName, int courseCreditNumber, departments departments)
        {
            CourseName = courseName;
            CourseCreditNumber = courseCreditNumber;
            Departments = departments;
            courses = new course[5];
        }
        public void AddThour(params course[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 7)
                    this.courses[CreditCount++] = course;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name " + CourseName);
            Console.WriteLine("Course Credit Number  " + CourseCreditNumber);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
    }
}
