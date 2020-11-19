using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class faculty
    {
        public string FacultyName { get; set; }
        public string FacultyId { get; set; }
        Thour[] teaching_Hours;
        public int CreditCount { get; set; }
        public faculty()
        {
            teaching_Hours = new Thour[100];
        }
        public departments Departments { get; set; }

        public faculty(string facultyName, string facultyId)
        {
            this.FacultyName = facultyName;
            this.FacultyId = facultyId;
            teaching_Hours = new Thour[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FacultyName);
            Console.WriteLine("Id: " + FacultyId);
        }
        public void AddCredit(params Thour[] teaching_Hour)
        {
            foreach (var a in teaching_Hour)
            {
                if (CreditCount < 7)
                {
                    this.teaching_Hours[CreditCount++] = a;

                }
                else
                {
                    Console.WriteLine("Cannot take any more course credit : " + a.CreditCount);
                }

            }
            Console.WriteLine("***||You Can Take Maximum 21 Credits||***");

        }
        public void ShowAllCredits()
        {
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < CreditCount; i++)
            {
                teaching_Hours[i].ShowInfo();
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
