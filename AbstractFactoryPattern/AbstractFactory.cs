namespace AbstractFactoryPattern
{
    /// <summary>
    /// 抽象工厂基类
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductMilk CreateProductMilk();

        public abstract AbstractProductHotdog CreateProductHogdog();
    }
}
