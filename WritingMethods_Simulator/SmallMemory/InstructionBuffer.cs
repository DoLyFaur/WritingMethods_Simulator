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
        int lastBranchTarget = 0;

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
                if (this.Count() < size && reader.BaseStream.Position != reader.BaseStream.Length)
                    this.Enqueue(GetNextInstruction(reader));
        }

        public Instruction Take()
        {
            Instruction instruction = this.Peek();
            this.Dequeue();
            if (lastBranchTarget != 0)
            {
                Program.cycles += instruction.PC_crt - lastBranchTarget;
                Program.instructions += instruction.PC_crt - lastBranchTarget;
                lastBranchTarget = 0;
            }
            if (instruction.opcode == 'B')
                lastBranchTarget = instruction.date_instr;
            return instruction;
        }
    }
}
