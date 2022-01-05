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
            var timeStart = DateTime.Now.Millisecond;
            int changed = 0;

            int tag = instruction.PC_crt / InstructionCache.sizeIC;
            int blOff = instruction.PC_crt % InstructionCache.sizeIC;
            int hit = 0;
            if (InstructionCache.InstructionStructs[blOff].V == true && InstructionCache.InstructionStructs[blOff].tagC == tag)
            {
                hit = 1;
                Program.ICHits++;
            }
            Program.ICAccesses++;

            /*while (DateTime.Now.Millisecond - timeStart < 300)
                if (Program.cycles - cycleCalled > 0)
                {
                    changed = 1;
                    break;
                }
            if (changed == 0)
            {*/
                if (hit == 1)
                    Program.cycles++;
                else
                    Program.cycles += Program.MMLatency;
            /*}
            else
            {*/
               /* if (hit == 0)
                {
                    changed = 0;
                    while (DateTime.Now.Millisecond - timeStart < 1100)
                        if (Program.cycles - cycleCalled >= Program.MMLatency)
                        {
                            changed = 1;
                            break;
                        }
                    if (changed == 0)
                        Program.cycles += Program.MMLatency - (Program.cycles - cycleCalled);
                }
            //}*/
            occupied = false;
        }
    }
}
