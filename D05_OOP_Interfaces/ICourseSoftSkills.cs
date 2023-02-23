using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal interface ICourseSoftSkills : ICourse
    {
        #region Properties
        string Subarea { get; }
        #endregion
    }
}
