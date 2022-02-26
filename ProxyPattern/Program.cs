using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("Test.png");

            // 图像将从磁盘加载
            image.Display();
            Console.WriteLine();

            // 图像不需要从磁盘加载
            image.Display();

            Console.ReadKey();
        }
    }
}
