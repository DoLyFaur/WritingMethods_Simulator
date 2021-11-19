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
        int lastTarget = 0;

        public InstructionBuffer(int size)
        {
            this.size = size;
        }

        public Instruction GetNextInstruction(BinaryReader reader)
        {
            char c = reader.ReadChar();
            while(c==' ' || c=='\n')
            {
                c = reader.ReadChar();
            }

            string pc = "", di="";
            char ch;
            reader.ReadChar();
            ch = reader.ReadChar();
            do
            {           
                pc += ch;
                ch = reader.ReadChar();
            } while (ch != ' ');
            
            ch = reader.ReadChar();
            while (ch == ' ')
            {
                ch = reader.ReadChar();
            }
            do
            {
                di += ch;
                ch = reader.ReadChar();
            } while (ch != ' ');

            return new Instruction(c, Int32.Parse(pc), Int32.Parse(di));
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
            Program.cycles += instruction.PC_crt - lastTarget;
            Program.instructions += instruction.PC_crt - lastTarget;
            if (instruction.opcode == 'B')
                lastTarget = instruction.date_instr;
            else
                lastTarget = instruction.PC_crt + 1;
            return instruction;
        }
    }
}
