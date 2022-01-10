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
            if (FRcombobox.SelectedIndex == 0)
            {
                IBScombobox.Items.Clear();
                IBScombobox.Items.AddRange(new object[]
                    {
                    "4",
                    "8",
                    "16",
                    "32"
                    });
                IBScombobox.Refresh();

                IRcombobox.Items.Clear();
                IRcombobox.Items.AddRange(new object[]
                { "2",
                  "4",
                  });
                IRcombobox.Refresh();
            }

            if (FRcombobox.SelectedIndex == 1)
            {
                IBScombobox.Items.Clear();
                IBScombobox.Items.AddRange(new object[]
               {  "8",
                  "16",
                  "32"
                 });
                IBScombobox.Refresh();


                IRcombobox.Items.Clear();
                IRcombobox.Items.AddRange(new object[]
               { "2",
                  "4",
                  "8"
                 });
                IRcombobox.Refresh();
            }

            if (FRcombobox.SelectedIndex == 2)
            {
                IBScombobox.Items.Clear();
                IBScombobox.Items.AddRange(new object[]
               { "16",
                  "32"
                 });
                IBScombobox.Refresh();


                IRcombobox.Items.Clear();
                IRcombobox.Items.AddRange(new object[]
               { "2",
                  "4",
                  "8",
                  "16"
                 });
               IRcombobox.Refresh();
            }

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
            string File = FileTextBox.Text;
            int IR = Int32.Parse(IRcombobox.Text);
            int IBS = Int32.Parse(IBScombobox.Text);
            int FR = Int32.Parse(FRcombobox.Text);
            int sizeIC = Int32.Parse(SizeICcombobox.Text);
            int sizeDC = Int32.Parse(SizeDCcombobox.Text);
            string strategy = Strategycombobox.Text;
            int MMLatency = Int32.Parse(MMcombobox.Text);
            Program.Simulate(File, IR, IBS, FR, sizeIC, sizeDC, MMLatency, strategy, ResultTextBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\User\Fac\IV.1\Sim_optim_arh_calc\WritingMethods_Simulator\WritingMethods_Simulator\bin\Debug",
                //@"C:\Desktop\Proiect_SOAC-variante\WritingMethods_Simulator\WritingMethods_Simulator\bin\Debug",
                Title = "Browse Trace",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "trc",
                Filter = "trc files (*.trc)|*.trc",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IRcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
