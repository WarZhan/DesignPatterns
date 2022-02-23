using System;
using System.Collections;
using System.Collections.Generic;

namespace EventListenerPattern
{
    public class EventManager
    {
        private static readonly Lazy<EventManager> _instance =
            new Lazy<EventManager>(() => new EventManager());

        public static EventManager Instance
        {
            get { return _instance.Value; }
        }

        private EventManager() { }

        private Hashtable _tableListener = null;
        private Queue<Event> _queueEvent = null;

        public void Init()
        {
            _tableListener = new Hashtable();
            _queueEvent = new Queue<Event>();
        }

        /// <summary>
        /// 添加监听事件
        /// </summary>
        /// <param name="context"></param>
        /// <param name="eventName"></param>
        /// <param name="listener"></param>
        public void AddEventListener(object context, string eventName, EventListener listener)
        {
            if (context == null || listener == null || string.IsNullOrEmpty(eventName))
            {
                Console.WriteLine("Event Manager: AddListener failed due to no listener or event name specified.");
            }
            else
            {
                List<EventListener> list = _GetEventListenerList(context, eventName, true);
                // 去重
                if (list.Exists(it => it == listener))
                {
                    Console.WriteLine("Event Manager: Listener: " + context + " - " + listener.GetType().ToString() + " is already in list for event: " + eventName);
                }
                else
                {
                    list.Add(listener);
                }
            }
        }

        public void RemoveEventListener(object context, string eventName, EventListener listener)
        {
            if (_tableListener.ContainsKey(context))
            {
                List<EventListener> list = _GetEventListenerList(context, eventName);
                if (null != list)
                {
                    list.Remove(listener);
                }
            }
        }

        /// <summary>
        /// 发送消息时 先保存到队列
        /// </summary>
        /// <param name="newEvent"></param>
        public void SendMessage(Event newEvent)
        {
            _queueEvent.Enqueue(newEvent);
        }

        private void _TriggerEvent(Event eventData)
        {
            List<EventListener> list = _GetEventListenerList(eventData.Context, eventData.Name);
            if (null != list)
            {
                list.ForEach(it => it(eventData.Data));
            }
        }

        public void Update()
        {
            while (_queueEvent.Count > 0)
            {
                Event item = _queueEvent.Dequeue();
                _TriggerEvent(item);
            }
        }

        private List<EventListener> _GetEventListenerList(object context, string eventName, bool createIfNotExist = false)
        {
            if (!_tableListener.ContainsKey(context))
            {
                if (createIfNotExist)
                {
                    _tableListener.Add(context, new Dictionary<string, List<EventListener>>());
                }
                else
                {
                    return null;
                }
            }

            Dictionary<string, List<EventListener>> dic = _tableListener[context] as Dictionary<string, List<EventListener>>;
            if (!dic.ContainsKey(eventName))
            {
                if (createIfNotExist)
                {
                    dic[eventName] = new List<EventListener>();
                    return dic[eventName];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return dic[eventName];
            }
        }
    }
}
