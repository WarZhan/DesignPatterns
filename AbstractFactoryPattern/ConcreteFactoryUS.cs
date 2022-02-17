namespace AbstractFactoryPattern
{
    /// <summary>
    /// 具体工厂 US
    /// </summary>
    public class ConcreteFactoryUS : AbstractFactory
    {
        public override AbstractProductHotdog CreateProductHogdog()
        {
            return new HotdogUS();
        }

        public override AbstractProductMilk CreateProductMilk()
        {
            return new MilkUS();
        }
    }
}
