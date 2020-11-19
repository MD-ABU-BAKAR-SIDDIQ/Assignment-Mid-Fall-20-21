using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class section : course
    {
        private string sectionName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
      
        public section() { }
        public section(string sectionName, string courseName, int courseId, int courseCredit, double courseTeachingHours) : base(courseName, courseId, courseCredit, courseTeachingHours)
        {
            this.sectionName = sectionName;
            
        }
        virtual public void ShowSectionInfo()
        {
            Console.WriteLine("Section Name : " + sectionName);

        }
    }
}