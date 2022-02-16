namespace FactoryMethodPattern
{
    /// <summary>
    /// 日志工厂接口
    /// </summary>
    public interface ILogFactory
    {
        Log CreateLog();
    }
}
