namespace ObserverPattern
{
    /// <summary>
    /// 具体主题/被观察者
    /// </summary>
    public class ConcreteSubject : Subject
    {
        // 具体被观察者（主题）的状态
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }

    }
}
