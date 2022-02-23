using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventListenerPattern
{
    /// <summary>
    /// 打包者
    /// </summary>
    public class PackagerManager
    {
        private static readonly Lazy<PackagerManager> _instance =
            new Lazy<PackagerManager>(() => new PackagerManager());

        public static PackagerManager Instance
        {
            get { return _instance.Value; }
        }

        private PackagerManager() { }

        public void Init()
        {
            EventManager.Instance.AddEventListener(
                CreaterManager.Instance,
                EventName.CREATE_PRODUCT_FINISH,
                _CreateProductFinish
                );
        }

        public void PackageProduct()
        {
            Console.WriteLine("PackagerManager 开始打包产品");
            Console.WriteLine("PackagerManager 打包完成");
            Event newEvent = new Event(_instance, EventName.PACKAGE_PRODUCT_FINISH);
            EventManager.Instance.SendMessage(newEvent);
        }

        private void _CreateProductFinish(object[] args)
        {
            Console.WriteLine("PackagerManager 收到来之 CreaterManager 的 "
                + EventName.CREATE_PRODUCT_FINISH + "消息");

            PackageProduct();
        }
    }

}
