using System.Threading;

namespace EventListenerPattern
{
    public class Timer
    {
        public void EventManagerUpdate()
        {
            while (true)
            {
                // 每 100 毫秒 更新一次
                Thread.Sleep(100);
                EventManager.Instance.Update();
            }
        }
    }
}
