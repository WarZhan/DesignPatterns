namespace FactoryMethodPattern
{
    /// <summary>
    /// 文件日志工厂
    /// </summary>
    public class FileLogFactory : ILogFactory
    {
        public Log CreateLog()
        {
            return new FileLog();
        }
    }
}
