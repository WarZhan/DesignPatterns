using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 文件日志
    /// </summary>
    public class FileLog : Log
    {
        public override void WriteLog()
        {
            Console.WriteLine("FileLog : WriteLog()");
        }
    }

}
