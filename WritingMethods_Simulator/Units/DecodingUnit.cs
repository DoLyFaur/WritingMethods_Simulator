using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.Units
{
    public class DecodingUnit
    {
        public bool occupied = false;
        public void Decode(Instruction instruction)
        {
            //Program.instructions++;
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
                            Form1.cycles++;
                            for (int i = 0; i < Form1.IR; i++)
                            {
                                if (Form1.ALU[i].instruction == null)
                                {
                                    Form1.ALU[i].instruction = instruction;
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
                            Form1.cycles++;
                            for (int i = 0; i < Form1.IR; i++)
                            {
                                if (Form1.ST[i].instruction == null)
                                {
                                    Form1.ST[i].instruction = instruction;
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
                            Form1.cycles++;
                            for (int i = 0; i < Form1.IR; i++)
                            {
                                if (Form1.LD[i].instruction == null)
                                {
                                    Form1.LD[i].instruction = instruction;
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
