using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D07_CollectionsGeneric_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList --> Não permite qualquer tipo de dados, tem que se declarar

            Utility.SetUniCodeConsole();

            #region List -> Ints
            List<int> listIntegers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                listIntegers.Add(i);
            }
            listIntegers.Add(10);

            Utility.WriteTitle("List<int> listIntegers");
            foreach (int item in listIntegers)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region List -> Courses
            Course course01 = new Course(1, "Course 01", "Area 01");
            Course course02 = new Course(2, "Course 02", "Area 02");

            List<Course> listCourses = new List<Course>();

            listCourses.Add(course01);
            listCourses.Add(course02);

            Utility.WriteTitle("List<Courses> listCourses");
            foreach (Course item in listCourses)
            {
                Console.WriteLine($"Course: {item.CourseID} - {item.CourseName} - {item.Area}");
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}
