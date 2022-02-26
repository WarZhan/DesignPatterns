using System;

namespace ProxyPattern
{
    /// <summary>
    /// 真实访问对象
    /// </summary>
    public class RealImage : Image
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            _LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + _fileName);
        }

        private void _LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}
