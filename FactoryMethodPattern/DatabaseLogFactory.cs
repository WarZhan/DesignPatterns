namespace FactoryMethodPattern
{
    /// <summary>
    /// 数据库日志工厂
    /// </summary>
    public class DatabaseLogFactory : ILogFactory
    {
        public Log CreateLog()
        {
            return new DatabaseLog();
        }
    }
}
