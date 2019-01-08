using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        // 执行命令
        abstract public void ExcuteCommand();

        public override string ToString()
        {
            return "Command";
        }
    }
}
