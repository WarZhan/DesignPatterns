//-----------------------------------------------
// MVC 模式
//-----------------------------------------------
using System;

namespace MVCPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentModel model = new StudentModel();
            model.SetName("Student"); // 数据可以来自数据库或服务器，这里只是简单模拟

            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.Show();

            Console.ReadKey();
        }
    }
}
