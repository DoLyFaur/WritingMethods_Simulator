﻿using System;
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

        public static int cycles = 0;
        public static int instructions = 0;
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
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public void Simulate(int ir, int ibs, int fr)
        {
            IR=ir;
            IBS = ibs;
            FR = fr;
            DEC = new DecodingUnit[FR];
            ALU = new ArithmeticLogicUnit[IR];
            BR = new BranchUnit[IR];
            ST = new StoreUnit[IR];
            LD = new LoadUnit[IR];

            InstructionBuffer instructionBuffer = new InstructionBuffer(IBS);
            BinaryReader binary_reader = new BinaryReader(File.Open("@", FileMode.Open));
            while (binary_reader.BaseStream.Position != binary_reader.BaseStream.Length)
            {
                //cycles++;
                instructionBuffer.Read(FR, binary_reader);
                for (int i = 0; i < FR; i++)
                {
                    if (!DEC[i].occupied)
                    {
                        DEC[i].occupied = true;
                        DEC[i].Decode(instructionBuffer.Take());
                    }
                }
            }
        }
    }
}
