using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WritingMethods_Simulator.SmallMemory;
using WritingMethods_Simulator.Units;

namespace WritingMethods_Simulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static int cycles=0;
        public static int instructions = 0;
        public static int IR;//replace with value from form
        public static int IBS;//replace with value from form
        public static int FR;//replace with value from form
        public static DecodingUnit[] DEC = new DecodingUnit[FR];
        public static ArithmeticLogicUnit[] ALU = new ArithmeticLogicUnit[IR];
        public static BranchUnit[] BR = new BranchUnit[IR];
        public static StoreUnit[] ST = new StoreUnit[IR];
        public static LoadUnit[] LD = new LoadUnit[IR];

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            InstructionBuffer instructionBuffer = new InstructionBuffer(IBS);
            BinaryReader binary_reader = new BinaryReader(File.Open("@", FileMode.Open));
            while (binary_reader.BaseStream.Position != binary_reader.BaseStream.Length)
            {
                cycles++;
                instructionBuffer.Read(FR,binary_reader);
                for (int i = 0; i < FR; i++)
                {
                    if(!DEC[i].occupied)
                    {
                        DEC[i].occupied = true;
                        DEC[i].Decode(instructionBuffer.Take());
                    }
                }
            }
        }
    }
}
