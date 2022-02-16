using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 数据库日志
    /// </summary>
    public class DatabaseLog : Log
    {
        public override void WriteLog()
        {
            Console.WriteLine("DatabaseLog : WriteLog()");
        }
    }

}
