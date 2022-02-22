//-----------------------------------------------
// 观察者模式
//-----------------------------------------------
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 主题/被观察者
            ConcreteSubject subject = new ConcreteSubject();

            // 创建观察者
            Observer observerA = new ConcreteObserver("A", subject);
            Observer observerB = new ConcreteObserver("B", subject);
            Observer observerC = new ConcreteObserver("C", subject);

            // 添加观察者 A B C
            subject.Attach(observerA);
            subject.Attach(observerB);
            subject.Attach(observerC);

            subject.SubjectState = "Run";
            subject.Notify();

            Console.WriteLine("-------------------------------------");

            subject.Detach(observerB);
            subject.SubjectState = "Eat";
            subject.Notify();

            Console.ReadKey();

        }
    }

}
