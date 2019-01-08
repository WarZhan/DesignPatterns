using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    // 烤肉者
    public class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串！");
        }

        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅！");
        }
    }
}
