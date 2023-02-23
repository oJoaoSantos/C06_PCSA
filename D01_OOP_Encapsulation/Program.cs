using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            Course course01 = new Course();

            course01.ReadCourse();
            course01.ListCourse();

            Utility.TerminateConsole();
        }
    }
}
