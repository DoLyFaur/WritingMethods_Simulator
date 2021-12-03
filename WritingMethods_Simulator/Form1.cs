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
            int IR = Int32.Parse(IRcombobox.Text);
            int IBS = Int32.Parse(IBScombobox.Text);
            int FR = Int32.Parse(FRcombobox.Text);
            int sizeIC = Int32.Parse(SizeICcombobox.Text);
            int sizeDC = Int32.Parse(SizeDCcombobox.Text);
            string strategy = Strategycombobox.Text;
            int MMlatency = Int32.Parse(MMcombobox.Text);
            Program.Simulate(IR, IBS, FR, sizeIC, sizeDC, MMlatency, strategy);
        }
    }
}
