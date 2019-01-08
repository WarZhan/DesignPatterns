using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Reciver receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            Console.WriteLine("ExcuteCommand ConcreteCommand !");
        }
    }
}
