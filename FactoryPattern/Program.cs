using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数字 A：");
            string strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号(+、-、*、/)：");
            string strOperate = Console.ReadLine();
            Console.Write("请输入数字 B：");
            string strNumberB = Console.ReadLine();
            string strResult = "";

            Operation oper;
            oper = OperationFactory.CreateOperation(strOperate);
            oper.NumberA = Convert.ToDouble(strNumberA);
            oper.NumberB = Convert.ToDouble(strNumberB);
            strResult = oper.GetResult().ToString();

            Console.WriteLine("结果是：" + strResult);

            Console.ReadLine();
        }
    }
}
