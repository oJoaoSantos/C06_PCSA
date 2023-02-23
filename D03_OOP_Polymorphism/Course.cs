/*
    Encapstulation:
    Public classe members: methods, properties
    Private class members: fields or attributes, variables

    Inheritance:
    Base class
    Derived classes

    Polymorphism:
    The same method with different signatures
 */

using System;

namespace D03_OOP_Polymorphism
{
    public class Course
    {

        #region Fields
        private string courseName;      // suporte da propriedade clássica 
        private string area;            // suporte da propriedade bodied-expression (=>)
        #endregion

        #region Properties
        // Auto implemented
        public int CourseId { get; set; }

        // Classic Propertie
        public string CourseName
        {
            get { return courseName; }                //read
            set { courseName = value.ToUpper(); }     //write
        }

        // Bodied-expression
        public string Area
        {
            get => area;                              //read
            set => area = value.ToUpper();            //write
        }

        // Read-only
        //public string FullCcourse => $"Course {CourseId}: {Area} - {CourseName}";
        public virtual string FullCcourse => $"Course {CourseId}: {Area} - {CourseName}";
        #endregion

        #region Constructors
        public Course() 
        {
            CourseId = 0;
            CourseName= string.Empty;
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

        //Read all course values
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

        // List course info
        public virtual void ListCourse()
        {
            Console.WriteLine($"\n\n{FullCcourse}");
        }
        #endregion

    }
}
