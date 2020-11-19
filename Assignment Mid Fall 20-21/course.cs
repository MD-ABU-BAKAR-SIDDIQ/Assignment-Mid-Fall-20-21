using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class course
    {
        private int courseId;
        public int num
        {
            get { return courseId; }
            set { courseId = value; }
        }

      
        private string courseName;
        public string CourseId
        {
            get { return courseName; }
            set { courseName = value; }
        }
        
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private int courseCredit;

        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        private double courseTeachingHours;

        public double CourseTeachingHours
        {
            get { return courseTeachingHours; }
            set { courseTeachingHours = value; }
        }


        private section[] sections;
        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }

        public course()
        {
            sections = new section[10];
            sectionCount = 0;
        }
        public course(string courseName, int courseId, int courseCredit, double courseTeachingHours)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;

            sections = new section[10];
            sectionCount = 0;
        }
        public course(string courseName, int courseId, int courseCredit, double courseTeachingHours, int Number)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;
            this.num = num;
            sections = new section[10];
            sectionCount = 0;
        }
        public void AddScetion(params section[] sections)
        {
            foreach (var a in sections)
            {
                if (sectionCount < 20)
                {
                    this.sections[sectionCount++] = a;
                }
                else
                {
                    Console.WriteLine("Cannot Add Any More Section For The Course : " + a.CourseId);
                }
            }
        }
        public void ShowAllTheSections()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                sections[i].ShowInfo();
            }
        }
        public section SearchSection(int sectionNumber)
        {
            section a = null;
            for (int i = 0; i < sectionCount; i++)
            {
                if (sections[i].CourseId.Equals(sectionNumber))
                {
                    a = sections[i];
                    break;
                }
            }
            return a;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Id Number: " + courseId);
            Console.WriteLine("Course Credit Number: " + courseCredit);
            Console.WriteLine("Course Teaching Hours: " + courseTeachingHours);

        }
        public void AddCourseNumber(int x)
        {
            num += x;
        }

    }
}
