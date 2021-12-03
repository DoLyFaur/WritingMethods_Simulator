using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.Units
{
    public abstract class ExecutionUnit
    {
        public bool occupied = false;

        public abstract void Execute(Instruction instruction, int cycleCalled);
    }
}
