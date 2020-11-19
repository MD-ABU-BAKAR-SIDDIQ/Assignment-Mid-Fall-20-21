using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid_Fall_20_21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("University Management System By Kuratoli Software Solutions");

            Console.WriteLine("\n Valid sections :- \n"); 

            course  crs1 = new course("oop2", 2, 3, 4.0, 5);
            section sec1 = new section("A", "OOP2",1,2,4.0);
            section sec2 = new section("B", "OOP2", 2, 3, 3.0);
            section sec3 = new section("C", "CN",2, 3, 4.0);
            section sec4 = new section("J", "OOAD",2, 3, 3.0);

            crs1.ShowInfo();
            sec1.ShowInfo();
            
            departments d1 = new departments("FST");
            departments d2 = new departments("FBA");
            departments d3 = new departments("FASS");

            d1.AddCourse(crs1);
            d1.ShowAllCourses();
     
            Console.WriteLine("\nAdding Courses\n");
            d1.AddCourse(sec1, sec2, sec3, sec4);
            d1.ShowAllCourses();
            
            Console.WriteLine("\nFaculty Name\n");
            faculty f1 = new faculty("A", "");
            faculty f2 = new faculty("B", "");
            faculty f3 = new faculty("C", "");
            faculty f4 = new faculty("D", "");
            
            
            Thour t1 = new Thour("OOAD", 3, d1);
            Thour t2 = new Thour("OOP1", 3, d1);
            Thour t3 = new Thour("00P2", 3, d1);
            

            f1.AddCredit(t1, t2, t3);
            f1.ShowAllCredits();

        }
    }
}
