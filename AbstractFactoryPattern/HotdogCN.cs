using System;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// CN 工厂生产的 Hotdog
    /// </summary>
    public class HotdogCN : AbstractProductHotdog
    {
        public override void Eat()
        {
            Console.WriteLine("Call HotdogCN.Eat()");
        }
    }
}
