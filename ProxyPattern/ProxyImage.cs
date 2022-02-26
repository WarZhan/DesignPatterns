namespace ProxyPattern
{
    /// <summary>
    /// 代理
    /// </summary>
    public class ProxyImage : Image
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (null == _realImage)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }

}
