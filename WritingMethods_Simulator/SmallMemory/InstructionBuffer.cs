using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.SmallMemory
{
    class InstructionBuffer:Queue<Instruction>
    {
        int size;
        public InstructionBuffer(int size)
        {
            this.size = size;
        }

        public void Read(int quantity, )
    }
}
