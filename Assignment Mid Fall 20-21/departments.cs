using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class departments
    {
        public string DepartmentName { get; set; }
        course[] listOfCourses;
        public int totalCourse { get; set; }
        public section Section { get; set; }
        Thour[] teachingHours;
        public int CreditCount { get; set; }
        public departments()
        {
            listOfCourses = new course[100];
            teachingHours = new Thour[1000];
        }
        public departments(string name)
        {
            DepartmentName = name;
            listOfCourses = new course[100];
            teachingHours = new Thour[1000];


        }
        public void ShowInfo()
        {
            Console.WriteLine("Name Of The Department: " + DepartmentName);
            Console.WriteLine("Total Number Of Courses: " + totalCourse);
        }
        public void AddCourse(params course[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 100)
                    listOfCourses[totalCourse++] = course;
            }
        }
        public void Removecourse(course course)
        {
            for (int i = 0; i < totalCourse; i++)
            {
                if (course.CourseId.Equals(listOfCourses[i].CourseId))
                {
                    for (int j = i; j < totalCourse - 1; j++)
                    {
                        listOfCourses[j] = listOfCourses[j + 1];
                    }
                    totalCourse--;
                    break;
                }

            }
        }
        public void AddNewCourseNumber(course course, int number)
        {
            course.AddCourseNumber(number);
        }
        public course SearchCourse(string id)
        {
            course b = null;
            for (int i = 0; i < totalCourse; i++)
            {
                if (listOfCourses[i].CourseId.Equals(id))
                {
                    b = listOfCourses[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfCourses[i].ShowInfo();
            }
        }
        public void AddTeachingHours(Thour teachingHour)
        {
            teachingHours[CreditCount++] = teachingHour;
        }
        public void ShowAllCredits()
        {

            for (int i = 0; i < CreditCount; i++)
            {
                Console.WriteLine("Department Info");
                teachingHours[i].Departments.ShowInfo();
                Console.WriteLine("Teaching  Hours");
                teachingHours[i].ShowInfo();
                
            }

        }


    }
}