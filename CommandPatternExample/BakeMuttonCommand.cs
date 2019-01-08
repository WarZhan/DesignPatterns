using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }

        public override string ToString()
        {
            return "烤羊肉串";
        }
    }
}
