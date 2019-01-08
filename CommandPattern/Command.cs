using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Command
    {
        protected Reciver receiver;

        public Command(Reciver receiver)
        {
            this.receiver = receiver;
        }

        // 执行命令
        abstract public void ExcuteCommand();

    }
}
