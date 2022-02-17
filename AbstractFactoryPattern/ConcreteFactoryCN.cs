namespace AbstractFactoryPattern
{
    /// <summary>
    /// 具体工厂CN
    /// </summary>
    public class ConcreteFactoryCN : AbstractFactory
    {
        public override AbstractProductHotdog CreateProductHogdog()
        {
            return new HotdogCN();
        }

        public override AbstractProductMilk CreateProductMilk()
        {
            return new MilkCN();
        }
    }
}
