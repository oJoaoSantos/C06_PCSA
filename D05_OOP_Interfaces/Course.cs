using System;


namespace D05_OOP_Interfaces
{
    internal class Course : ICourse
    {
        #region Properties
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Area { get; set; }
        #endregion

        #region Constructors
        public Course()
        {
            CourseId = 0;
            CourseName = string.Empty;
            Area = string.Empty;
        }
        public Course(int courseId, string courseName, string area)
        {
            CourseId = courseId;
            CourseName = courseName;
            Area = area;
        }
        #endregion

        #region Methods
        public virtual void ReadCourse()
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
