using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.BigMemory
{
    class InstructionCache
    {
        public static int sizeIC;
        public struct InstructionStruct
        {
            public Instruction instruction;
            public int tagC;
            public bool V;
        }

        public static InstructionStruct[] InstructionStructs = new InstructionStruct[sizeIC];

        public InstructionCache(int size_IC)
        {
            sizeIC = size_IC;
            for (int i = 0; i < sizeIC; i++)
            {
                InstructionStructs[i] = new InstructionStruct();
                InstructionStructs[i].V = false;
            }
        }

        internal static void Add(Instruction instruction)
        {
            int tag = instruction.PC_crt / sizeIC;
            int blOff = instruction.PC_crt % sizeIC;
            InstructionStructs[blOff].tagC = tag;
            InstructionStructs[blOff].instruction = instruction;
            InstructionStructs[blOff].V = true;
        }
    }
}
