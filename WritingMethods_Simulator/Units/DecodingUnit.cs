using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.Units
{
    class DecodingUnit
    {
        public bool occupied = false;
        public void Decode(Instruction instruction)
        {
            Program.instructions++;
            Dispatch(instruction);
        }

        public void Dispatch(Instruction instruction)
        {
            int dispatched = 0;
            switch(instruction.opcode)
            {
                case 'B':
                    {
                        while(dispatched==0)
                        {
                            Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.ALU[i].instruction == null)
                                {
                                    Program.ALU[i].instruction = instruction;
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        occupied = false;
                        break;
                    }
                case 'S':
                    {
                        while (dispatched == 0)
                        {
                            Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.ST[i].instruction == null)
                                {
                                    Program.ST[i].instruction = instruction;
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        occupied = false;
                        break;
                    }
                case 'L':
                    {
                        while (dispatched == 0)
                        {
                            Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.LD[i].instruction == null)
                                {
                                    Program.LD[i].instruction = instruction;
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        occupied = false;
                        break;
                    }
                default: throw new Exception("Unknown instruction");
            }
        }
    }
}
