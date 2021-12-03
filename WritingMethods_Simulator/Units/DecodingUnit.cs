using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.Units
{
    public class DecodingUnit
    {
        public bool occupied;
        /*public Task[] tsk = new Task[300];
        public int tskNo = -1;*/

        public DecodingUnit()
        {
            this.occupied = false;
        }

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
                case 'A':
                    {
                        while (dispatched == 0)
                        {
                            //Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.ALU[i].occupied == false)
                                {
                                    occupied = false;
                                    Program.ALU[i].Execute(instruction, Program.cycles);
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                case 'B':
                    {
                        while(dispatched==0)
                        {
                            //Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.BR[i].occupied == false)
                                {
                                    occupied = false;
                                    Program.BR[i].Execute(instruction, Program.cycles);
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                case 'S':
                    {
                        while (dispatched == 0)
                        {
                            //Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.ST[i].occupied == false)
                                {
                                    occupied = false;
                                    Program.ST[i].Execute(instruction, Program.cycles);
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                case 'L':
                    {
                        while (dispatched == 0)
                        {
                            //Program.cycles++;
                            for (int i = 0; i < Program.IR; i++)
                            {
                                if (Program.LD[i].occupied == false)
                                {
                                    occupied = false;
                                    Program.LD[i].Execute(instruction, Program.cycles);
                                    dispatched = 1;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                default: throw new Exception("Unknown instruction");
            }
        }
    }
}
