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

            // 启动计时器 每 100 毫秒 更新一次
            Timer threadTimer = new Timer(_Update, null, 0, 100);

            CreaterManager.Instance.CreateProduct(); // 开始生产

            Console.ReadKey();
        }

        private static void _Update(object state)
        {
            EventManager.Instance.Update();
        }
    }
}
