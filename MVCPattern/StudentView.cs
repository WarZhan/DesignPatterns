using System;

namespace MVCPattern
{
    /// <summary>
    /// View
    /// </summary>
    public class StudentView
    {
        public void Show(string data)
        {
            Console.WriteLine("Call View.Show() ! Data is " + data + ".");
        }
    }
}
