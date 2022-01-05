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
            var timeStart = DateTime.Now.Millisecond;
            int changed = 0;

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
                /*while (DateTime.Now.Millisecond - timeStart < 500)
                    if (Program.cycles - cycleCalled > 0)
                    {
                        changed = 1;
                        break;
                    }
                if (changed == 0)
                {*/
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
               /* else
                {
                    if (Program.strategy == "Write Through")
                    {
                        /*changed = 0;
                        while (DateTime.Now.Millisecond - timeStart < 1500)
                            if (Program.cycles - cycleCalled >= Program.MMLatency)
                            {
                                changed = 1;
                                break;
                            }
                        if (changed == 0)
                            Program.cycles += Program.MMLatency - (Program.cycles - cycleCalled);
                    }
                    else
                    {
                        if (hit == 0) 
                        {
                            DataCache.DataStructs[blOff].D = true;
                            DataCache.DataStructs[blOff].V = true;
                            /*changed = 0;
                            while (DateTime.Now.Millisecond - timeStart < 1500)
                                if (Program.cycles - cycleCalled >= Program.MMLatency + 1) 
                                {
                                    changed = 1;
                                    break;
                                }
                            if (changed == 0)
                                Program.cycles += Program.MMLatency + 1 - (Program.cycles - cycleCalled);
                        }
                    }
                }
            //}*/
            occupied = false;
        }
    }
}
