//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch13.DelegateChains
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Notifier notifier = new Notifier();
//            EventListener listener1 = new EventListener("Listener1");
//            EventListener listener2 = new EventListener("Listener2");
//            EventListener listener3 = new EventListener("Listener3");

//            notifier.EventOccured += listener1.SomethingHappend;
//            notifier.EventOccured += listener2.SomethingHappend;
//            notifier.EventOccured += listener3.SomethingHappend;
//            notifier.EventOccured("You've got mail");

//            Console.WriteLine();

//            notifier.EventOccured -= listener2.SomethingHappend;
//            notifier.EventOccured("다운 완료");

//            Console.WriteLine();

//            notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
//            notifier.EventOccured("핵이 탐지되었습니다.");

//        }
//    }
//}
