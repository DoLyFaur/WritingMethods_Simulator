using System;
using System.Collections.Generic;
using System.IO;
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

        public Instruction GetNextInstruction(BinaryReader reader)
        {
            return new Instruction(reader.ReadChar(), reader.ReadInt32(), reader.ReadInt32());
        }

        public void Read(int quantity, BinaryReader reader)
        {
            for (int i = 0; i < quantity; i++)
                if (this.Count() < size)
                    this.Enqueue(GetNextInstruction(reader));
        }

        public Instruction Take()
        {
            Instruction instruction = this.Peek();
            this.Dequeue();
            return instruction;
        }
    }
}
