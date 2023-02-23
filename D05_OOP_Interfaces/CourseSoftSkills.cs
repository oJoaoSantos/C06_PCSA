using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class CourseSoftSkills : ICourseSoftSkills
    {
        #region Properties
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Area { get; set; }
        public string Subarea { get; set; }
        #endregion

        #region Constuctors
        public CourseSoftSkills()
        {
            CourseId = 0;
            CourseName = string.Empty;
            Area = string.Empty;
            Subarea = string.Empty;
        }
        public CourseSoftSkills(int courseId, string courseName, string area, string subarea)
        {
            CourseId = courseId;
            CourseName = courseName;
            Area = area;
            Subarea = subarea;
        }
        #endregion

        #region Methods
      
        public void ReadCourse()
        {
            #region CourseID
            string valueReaded;
            int valueConverted;
            bool tryConvert;
            do
            {
                Console.Write("Course ID: ");
                valueReaded = Console.ReadLine();
                tryConvert = int.TryParse(valueReaded, out valueConverted);
            } while (tryConvert == false);
            CourseId = valueConverted;
            #endregion

            #region CourseName
            Console.Write("Course Name: ");
            CourseName = Console.ReadLine();
            #endregion

            #region Area
            Console.Write("Course Area: ");
            Area = Console.ReadLine();
            #endregion

            #region Subarea
            //acrescentar a Subarea
            Console.Write("Course Subarea: ");
            Subarea = Console.ReadLine(); // sem validação
            #endregion
        }

        public void ListCourse()
        {

        }

        public void ListCourse(int courseId, string courseName)
        {

        }
        #endregion
    }
}
