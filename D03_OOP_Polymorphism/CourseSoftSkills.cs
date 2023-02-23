using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    public class CourseSoftSkills: Course
    {

        #region Properties
        public string Subarea { get; set; }
        public override string FullCcourse => $"Course {CourseId}: {Area}, ({Subarea}) - {CourseName}";
        #endregion

        #region Constructors
        public CourseSoftSkills() : base()
        {
            Subarea = string.Empty;
        }
        public CourseSoftSkills(int courseId, string courseName, string area, string subarea) : base(courseId, courseName, area)
        {
            Subarea = subarea;
        }
        #endregion

        #region Methods
        public override void ReadCourse()
        {
            //invocar o método da base class
            base.ReadCourse();

            #region Subarea
            //acrescentar o Exam
            Console.Write("Subarea: ");
            Subarea = Console.ReadLine();
            #endregion
        }

        public void ListCourse(string level)
        {
            // invocar um método polimórfico, com assinatura diferente.
            Console.WriteLine($"{FullCcourse} ({level})");
        }
        #endregion
    }
}
