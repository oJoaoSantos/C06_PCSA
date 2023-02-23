using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D02_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Course
            Course course01 = new Course();

            course01.ReadCourse();
            course01.ListCourse();
            #endregion

            Utility.TerminateConsole();

            #region CourseIT
            CourseIT courseIT01 = new CourseIT();

            courseIT01.ReadCourse();
            courseIT01.ListCourse();
            #endregion

            Utility.TerminateConsole();

            #region CourseSoftSkills
            CourseSoftSkills courseSoftSkills01 = new CourseSoftSkills();

            courseSoftSkills01.ReadCourse();
            courseSoftSkills01.ListCourse();
            #endregion

            Utility.TerminateConsole();

        }
    }
}
