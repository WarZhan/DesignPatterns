//-----------------------------------------------
// 单例模式
//-----------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass.Instance.ShowName();
            Console.ReadKey();
        }
    }
}
