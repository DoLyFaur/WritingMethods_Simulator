using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingMethods_Simulator.BigMemory;

namespace WritingMethods_Simulator.Units
{
    public class LoadUnit : ExecutionUnit
    {
        public override void Execute(Instruction instruction, int cycleCalled)
        {
            occupied = true;

            int tag = instruction.date_instr / DataCache.sizeDC;
            int blOff = instruction.date_instr % DataCache.sizeDC;
            int hit = 0;
            if (DataCache.DataStructs[blOff].V == true && DataCache.DataStructs[blOff].tagC == tag)
            {
                hit = 1;
                Program.DCHits++;
            }
            Program.DCAccesses++;

            if (Program.strategy != "Default")
            {
                if (hit == 1)
                {
                    if (Program.strategy == "Write Back")
                        Program.cycles++;
                    else
                        Program.cycles += Program.MMLatency;
                }
                else
                {
                    Program.cycles += Program.MMLatency;
                    if (Program.strategy == "Write Back")
                    {
                        Program.cycles++;
                        DataCache.DataStructs[blOff].D = true;
                        DataCache.DataStructs[blOff].V = true;
                    }
                }
            }
               
            occupied = false;
        }
    }
}
