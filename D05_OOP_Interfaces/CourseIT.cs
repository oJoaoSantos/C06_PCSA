using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class CourseIT : Course, ICourseIT
    {
        #region Properties
        public bool Exam { get; set; }
        #endregion

        #region Constructors

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
        #endregion

    }
}
