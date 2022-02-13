namespace FactoryPattern
{
    /// <summary>
    /// 加法
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = NumberA + NumberB;
            return result;
        }
    }
}
