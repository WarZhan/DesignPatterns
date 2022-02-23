namespace EventListenerPattern
{
    public delegate void EventListener(params object[] args);

    /// <summary>
    /// 事件
    /// </summary>
    public class Event
    {
        private object _context;
        public object Context
        {
            get { return _context; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
        }

        private object[] _data;
        public object[] Data
        {
            get { return _data; }
        }

        public Event(object context, string name, object[] data = null)
        {
            _context = context;
            _name = name;
            _data = data;
        }
    }
}
