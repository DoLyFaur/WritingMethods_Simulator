using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingMethods_Simulator.BigMemory;

namespace WritingMethods_Simulator.Units
{
    public class StoreUnit : ExecutionUnit
    {
        public override void Execute(Instruction instruction, int cycleCalled)
        {
            occupied = true;

            int tag = instruction.date_instr / DataCache.sizeDC;
            int blOff = instruction.date_instr % DataCache.sizeDC;
            DataCache.DataStructs[blOff].tagC = tag;
            DataCache.DataStructs[blOff].data = instruction.date_instr;
            DataCache.DataStructs[blOff].V = true;
            DataCache.DataStructs[blOff].D = true;

            Program.cycles++;

            occupied = false;
        }
    }
}
