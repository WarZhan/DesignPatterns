using System;

namespace EventListenerPattern
{
    /// <summary>
    /// 生成者
    /// </summary>
    public class CreaterManager
    {
        private static readonly Lazy<CreaterManager> _instance =
            new Lazy<CreaterManager>(() => new CreaterManager());

        public static CreaterManager Instance
        {
            get { return _instance.Value; }
        }

        private CreaterManager() { }

        public void Init()
        {
            EventManager.Instance.AddEventListener(
                PackagerManager.Instance,
                EventName.PACKAGE_PRODUCT_FINISH,
                _PackageProductFinish
                );
        }

        public void CreateProduct() 
        {
            Console.WriteLine("CreaterManager 开始生产产品");
            Console.WriteLine("CreaterManager 生产完成");
            Event newEvent = new Event(_instance, EventName.CREATE_PRODUCT_FINISH);
            EventManager.Instance.SendMessage(newEvent);
        }

        private void _PackageProductFinish(object[] args)
        {
            Console.WriteLine("CreaterManager 收到来之 PackagerManager 的 " 
                + EventName.PACKAGE_PRODUCT_FINISH + "消息");
            Console.WriteLine("CreaterManager 开始生产下一个产品");
        }
    }

}
