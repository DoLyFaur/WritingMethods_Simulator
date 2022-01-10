using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingMethods_Simulator.BigMemory;

namespace WritingMethods_Simulator.Units
{
    public class BranchUnit : ExecutionUnit
    {
        public override void Execute(Instruction instruction, int cycleCalled)
        {
            occupied = true;

            int tag = instruction.PC_crt / InstructionCache.sizeIC;
            int blOff = instruction.PC_crt % InstructionCache.sizeIC;
            int hit = 0;
            if (InstructionCache.InstructionStructs[blOff].V == true && InstructionCache.InstructionStructs[blOff].tagC == tag)
            {
                hit = 1;
                Program.ICHits++;
            }
            Program.ICAccesses++;

            if (hit == 1)
                Program.cycles++;
            else
                Program.cycles += Program.MMLatency;
            
            occupied = false;
        }
    }
}
