using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// 主题/抽象通知者
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> _listObserver = new List<Observer>();

        // 通知者（主题）的状态
        protected string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }

        /// <summary>
        /// 增加 观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            _listObserver.Add(observer);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            _listObserver.Remove(observer);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify() 
        {
            _listObserver.ForEach(it => it.Update());
        }
    }
}
