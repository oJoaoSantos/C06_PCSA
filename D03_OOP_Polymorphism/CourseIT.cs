using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    public class CourseIT: Course
    {

        #region Properties
        public bool Exam { get; set; }
        public DateTime AtualDate => DateTime.Now;
        //public new string FullCcourse => $"Course {CourseId}: {Area} - {CourseName}, Exam: {Exam}"; //--> Utilizando este método, não consegimos utilizar o método list da classe base.
        public override string FullCcourse => $"Course {CourseId}: {Area} - {CourseName}, Exam: {Exam}";
        #endregion

        #region Constructors
        public CourseIT() : base() 
        { 
            Exam = false;
        }
        public CourseIT(int courseId, string courseName, string area, bool exam) : base(courseId, courseName, area)
        {
            Exam = exam;
        }

        #endregion

        #region Methods
        public override void ReadCourse()
        { 
            //invocar o método da base class
            base.ReadCourse();

            #region Exam
            //acrescentar o Exam
            Console.Write("Course Exam (false / true): ");
            Exam = Convert.ToBoolean(Console.ReadLine()); // sem validação
            #endregion

        }

        public void ListCourse(DateTime dateNow)
        {
            // invocar um método polimórfico, com assinatura diferente.
            Console.WriteLine($"{FullCcourse} ({dateNow})");
        }

        #endregion
    }
}
