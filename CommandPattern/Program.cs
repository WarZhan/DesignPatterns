using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Reciver reciver = new Reciver();
            Invoker invoker = new Invoker();
            ConcreteCommand concreteCommand = new ConcreteCommand(reciver);

            invoker.SetCommand(concreteCommand);
            invoker.ExcuteCommand();

            Console.Read();

        }
    }
}
