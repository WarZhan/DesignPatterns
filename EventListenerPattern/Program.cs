using System;
using System.Threading;

namespace EventListenerPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化管理器
            EventManager.Instance.Init(); // 事件管理器
            CreaterManager.Instance.Init(); // 生产者
            PackagerManager.Instance.Init(); // 打包者

            // 启动线程
            Timer timer = new Timer(); // 生成一个定时刷新器
            Thread thread = new Thread(new ThreadStart(timer.EventManagerUpdate));
            thread.Start();

            CreaterManager.Instance.CreateProduct(); // 开始生产

            Console.ReadKey();
        }
    }
}
