using System;

namespace FactoryPattern
{
    /// <summary>
    /// 除法
    /// </summary>
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为 0。");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
