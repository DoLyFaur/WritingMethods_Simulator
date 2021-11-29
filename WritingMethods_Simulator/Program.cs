using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WritingMethods_Simulator.BigMemory;
using WritingMethods_Simulator.SmallMemory;
using WritingMethods_Simulator.Units;

namespace WritingMethods_Simulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static int cycles;
        public static int instructions;
        public static int IR;
        public static int IBS;
        public static int FR;
        public static DecodingUnit[] DEC;
        public static ArithmeticLogicUnit[] ALU;
        public static BranchUnit[] BR;
        public static StoreUnit[] ST;
        public static LoadUnit[] LD;

        [STAThread]
        static void Main()
        {
            cycles = 0;
            instructions = 0;

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public void Simulate(int ir, int ibs, int fr, int sizeIC, int sizeDC)
        {
            InstructionCache instructionCache = new InstructionCache(sizeIC);
            DataCache dataCache = new DataCache(sizeDC);

            IR = ir;
            IBS = ibs;
            FR = fr;
            DEC = new DecodingUnit[FR];
            for (int i = 0; i < FR; i++)
            {
                DEC[i] = new DecodingUnit();
            }
            //DecodingUnit[] DEC = new DecodingUnit[FR];
            ArithmeticLogicUnit[] ALU = new ArithmeticLogicUnit[IR];
            BranchUnit[] BR = new BranchUnit[IR];
            StoreUnit[] ST = new StoreUnit[IR];
            LoadUnit[] LD = new LoadUnit[IR];

            InstructionBuffer instructionBuffer = new InstructionBuffer(IBS);
            BinaryReader binary_reader = new BinaryReader(File.Open("FTOWER.TRC", FileMode.Open));
            int ind = 1;
            while (binary_reader.BaseStream.Position != binary_reader.BaseStream.Length)
            {
                //cycles++;
                instructionBuffer.Read(FR, binary_reader);
                for (int i = 0; i < FR; i++)
                {
                    if (!DEC[i].occupied && instructionBuffer.Count!=0)
                    {
                        //DEC[i].occupied = true;
                        //DEC[i].Decode(instructionBuffer.Take());*/
                        Instruction instruction = instructionBuffer.Take();
                        if (instruction == null)
                        {
                            ind = 0;
                            continue;
                        }
                        //DEC[i].Decode(instruction);
                    }
                }
            }
            if (ind == 1)
                instructions++;
            Console.WriteLine(instructions);
        }
    }
}
