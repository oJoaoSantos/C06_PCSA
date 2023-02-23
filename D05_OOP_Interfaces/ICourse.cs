using System;


namespace D05_OOP_Interfaces
{
    internal interface ICourse
    {
        #region Properties
        int CourseId { get; }
        string CourseName { get; }
        string Area { get; }
        #endregion

        #region Methods
        // ReedCourse
        void ReadCourse();

        // ListCourse
        void ListCourse();

        // CourseId e CourseName
        void ListCourse(int courseId, string courseName);
        #endregion
    }
}
