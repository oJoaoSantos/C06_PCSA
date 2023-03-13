using System;

namespace D13_Advanced_DelegateEvent
{

    // Subscriber (ou Listener)
    class ClassEventTest
    {

        public void TestEvent()
        {
            
            ClassEvent myLesson = new ClassEvent();

            // Subscreve o evento executando o método add do evento
            myLesson.MyLesson += MyTestEvent;

            // Remove o evento executando o método remove do evento
            myLesson.MyLesson -= MyTestEvent;

        }

        // Consome o delegate
        // (a assinatura tem de ser igual à do delegate)
        public void MyTestEvent(object sender, EventArgs e)
        {
            // ...
        }

    }

}
