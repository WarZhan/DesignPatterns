using System;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// US 工厂生产的 Milk
    /// </summary>
    public class MilkUS : AbstractProductMilk
    {
        public override void Drink()
        {
            Console.WriteLine("Call MilkUS.Drink()");
        }
    }
}
