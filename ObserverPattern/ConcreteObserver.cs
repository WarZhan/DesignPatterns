using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private Subject _subject = null;

        public ConcreteObserver(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("观察者 {0} 关注的 Subject 新状态为 {1}", _name, _observerState);
        }
    }
}
