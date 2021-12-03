using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.BigMemory
{
    class InstructionCache
    {
        private static int sizeIC;
        public struct InstructionStruct
        {
            public Instruction instruction;
            public int tagC;
            public bool V;
        }

        InstructionStruct[] DataStructs = new InstructionStruct[sizeIC];

        public InstructionCache(int size_IC)
        {
            sizeIC = size_IC;
            for (int i = 0; i < sizeIC; i++)
            {
                DataStructs[i] = new InstructionStruct();
                DataStructs[i].V = false;
            }
        }
    }
}
