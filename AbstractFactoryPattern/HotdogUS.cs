using System;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// US 工厂生产的 Hotdog
    /// </summary>
    public class HotdogUS : AbstractProductHotdog
    {
        public override void Eat()
        {
            Console.WriteLine("Call HotdogUS.Eat()");
        }
    }
}
