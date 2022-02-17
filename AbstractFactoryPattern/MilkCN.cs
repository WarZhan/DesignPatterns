using System;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// CN 工厂生产的 Milk
    /// </summary>
    public class MilkCN : AbstractProductMilk
    {
        public override void Drink()
        {
            Console.WriteLine("Call MilkCN.Drink()");
        }
    }
}
