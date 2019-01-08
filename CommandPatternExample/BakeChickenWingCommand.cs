using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }

        public override string ToString()
        {
            return "烤鸡翅";
        }
    }
}
