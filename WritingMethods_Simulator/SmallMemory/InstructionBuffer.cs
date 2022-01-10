using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingMethods_Simulator.BigMemory;

namespace WritingMethods_Simulator.SmallMemory
{
    class InstructionBuffer:Queue<Instruction>
    {
        int size;
        int lastTarget = 0;
        int ALUInstrToSend = 0;
        int PC_crt;

        public InstructionBuffer(int size)
        {
            this.size = size;
        }

        public Instruction GetNextInstruction(BinaryReader reader)
        {
            char c = reader.ReadChar();
            while (!Char.IsLetterOrDigit(c))
            {
                if (reader.BaseStream.Position != reader.BaseStream.Length)
                    c = reader.ReadChar();
                else
                    return null;
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
            while (ch != ' ' && reader.BaseStream.Position != reader.BaseStream.Length)
            {
                di += ch;
                ch = reader.ReadChar();
            }
            di += ch;

            if (pc.Contains(" "))
                pc = pc.Substring(0, pc.Length - 1);
            if (di.Contains(" "))
                di = di.Substring(0, di.Length - 1);

            return new Instruction(c, Int32.Parse(pc), Int32.Parse(di));
        }

        public void Read(int quantity, BinaryReader reader)
        {
            for (int i = 0; i < quantity; i++)
                if (this.Count() < size && reader.BaseStream.Position != reader.BaseStream.Length)
                    this.Enqueue(GetNextInstruction(reader));
        }

        Instruction ALUInstruction()
        {
            PC_crt++;
            ALUInstrToSend--;
            Program.instructions++;
            lastTarget = PC_crt + 1;
            return new Instruction('A', PC_crt, lastTarget);
        }

        public Instruction Take()
        {
            if (ALUInstrToSend == 0) 
            {
                Instruction instruction = this.Peek();
                InstructionCache.Add(instruction);
                if (instruction.PC_crt - lastTarget > 0)
                {
                    PC_crt = lastTarget - 1;
                    ALUInstrToSend = instruction.PC_crt - lastTarget;
                    return ALUInstruction();
                }
                else
                {
                    this.Dequeue();
                    PC_crt = instruction.PC_crt;
                    Program.instructions++;
                    if (instruction == null)
                        return null;
                    if (instruction.opcode == 'B')
                        lastTarget = instruction.date_instr;
                    else
                        lastTarget = instruction.PC_crt + 1;
                    return instruction;
                }
            }
            else
            {
                return ALUInstruction();
            }
        }
    }
}
