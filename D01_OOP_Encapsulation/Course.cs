/*
    Encapstulation:
    Public classe members: methods, properties
    Private class members: fields or attributes, variables
 */

using System;

namespace D01_OOP_Encapsulation
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
            get { return courseName; }      //read
            set { courseName = value; }     //write
        }

        // Bodied-expression
        public string Area
        {
            get => area;                    //read
            set => area = value;            //write
        }

        // Read-only
        public string FullCcourse => $"Course {CourseId}: {Area} - {CourseName}";
        #endregion

        #region Methods

        //Read all course values
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
        }

        // List course info
        public void ListCourse()
        {
            Console.WriteLine($"\n\n{FullCcourse}");
        }
        #endregion

    }
}
