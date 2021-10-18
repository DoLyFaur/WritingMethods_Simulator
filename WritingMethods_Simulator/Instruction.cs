using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator
{
    public class Instruction
    {
        public char opcode;
        public int PC_crt;
        public int date_instr;

        public Instruction(char opcode, int PC_crt, int date_instr)
        {
            this.opcode = opcode;
            this.PC_crt = PC_crt;
            this.date_instr = date_instr;
        }
    } 
}
