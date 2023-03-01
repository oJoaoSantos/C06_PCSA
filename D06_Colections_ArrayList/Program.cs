using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace D06_Colections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            // ArrayList --> Permite qualquer tipo de dados

            #region ArrayList -> Multi-value
            // criar arrayList:
            ArrayList listaMultivalor = new ArrayList();

            // adicionar dados:
            listaMultivalor.Add("Collection ArrayList");
            listaMultivalor.Add(1.5);
            listaMultivalor.Add(true);
            listaMultivalor.Add(new DateTime(2023,02,28));
            // adicionar dados dinamicamente:
            for (int i = 4; i < 7; i++)
            {
                listaMultivalor.Add(i);
            }

            // listar arrayList:
            Utility.WriteTitle("ArrayList Multi-Value");
            foreach (var item in listaMultivalor)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region ArrayList -> Objects
            Course course01 = new Course(1, "Course 01", "Area 01");
            Course course02 = new Course(2, "Course 02", "Area 02");

            ArrayList listaCursos = new ArrayList();
            
            listaCursos.Add(course01);
            listaCursos.Add(course02);

            Utility.WriteTitle("ArrayList Courses");
            foreach (Course item in listaCursos)
            {
                Console.WriteLine($"Course: {item.CourseID} - {item.CourseName} - {item.Area}");
            }
            #endregion

            Utility.TerminateConsole();

        }
    }
}
