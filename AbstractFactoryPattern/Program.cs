//-----------------------------------------------
// 抽象工厂模式
//-----------------------------------------------
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请选择工厂地址( CN 或 US)：");
            string strAddress = Console.ReadLine();
            if (strAddress == "CN" || strAddress == "US")
            {
                string className = "AbstractFactoryPattern.ConcreteFactory" + strAddress;
                Type factoryType = Type.GetType(className);

                AbstractFactory factory = Activator.CreateInstance(factoryType) as AbstractFactory;

                //AbstractFactory factory = (AbstractFactory)Assembly.Load("AbstractFactoryPattern").CreateInstance("ConcreteFactory" + strAddress);
                AbstractProductHotdog hotdog = factory.CreateProductHogdog();
                hotdog.Eat();

                AbstractProductMilk milk = factory.CreateProductMilk();
                milk.Drink();
            }
            else
            {
                Console.WriteLine("请输入正确的地址!");
            }

            Console.ReadKey();
        }
    }
}
