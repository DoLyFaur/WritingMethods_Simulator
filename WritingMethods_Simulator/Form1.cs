using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WritingMethods_Simulator.SmallMemory;
using WritingMethods_Simulator.Units;

namespace WritingMethods_Simulator
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_FontChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FRcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IBScombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MMcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            IR = Int32.Parse(IRcombobox.Text);
            IBS = Int32.Parse(IBScombobox.Text);
            FR = Int32.Parse(FRcombobox.Text);
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
