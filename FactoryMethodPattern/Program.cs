using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //如需修改为 FileLog 只需修改这里为 new FileLogFactory()
            ILogFactory factory = new DatabaseLogFactory();

            Log log = factory.CreateLog();
            log.WriteLog();

            Console.ReadKey();
        }
    }

}
