using System;

namespace D13_Advanced_DelegateEvent
{

    // Publisher
    class ClassEvent
    {

        #region 01. Declarar o delegate para o evento
        public delegate void MyEventHandler(object sender, EventArgs e);
        #endregion

        #region 02. Declarar o evento
        public event MyEventHandler MyLesson
        {

            // Início do evento
            add 
            {
                Console.WriteLine("Lesson is starting.");
            }

            // Fim do evento
            remove
            {
                Console.WriteLine("Lesson has finished.");
            }

        }
        #endregion

    }

}
