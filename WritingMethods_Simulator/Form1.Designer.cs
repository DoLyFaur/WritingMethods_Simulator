
namespace WritingMethods_Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FRcombobox = new System.Windows.Forms.ComboBox();
            this.IBScombobox = new System.Windows.Forms.ComboBox();
            this.IRcombobox = new System.Windows.Forms.ComboBox();
            this.MMcombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SizeICcombobox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SizeDCcombobox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Strategycombobox = new System.Windows.Forms.ComboBox();
            this.SimulateButton = new System.Windows.Forms.Button();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.SelectTraceButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Architecture Parameters";
            this.label1.FontChanged += new System.EventHandler(this.label1_FontChanged);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fetch Rate (FR):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instruction Buffer Size:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Issue Rate Max (IRmax):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Main Memory latency:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FRcombobox
            // 
            this.FRcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FRcombobox.FormattingEnabled = true;
            this.FRcombobox.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.FRcombobox.Location = new System.Drawing.Point(174, 35);
            this.FRcombobox.Name = "FRcombobox";
            this.FRcombobox.Size = new System.Drawing.Size(65, 28);
            this.FRcombobox.TabIndex = 2;
            this.FRcombobox.SelectedIndexChanged += new System.EventHandler(this.FRcombobox_SelectedIndexChanged);
            // 
            // IBScombobox
            // 
            this.IBScombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IBScombobox.FormattingEnabled = true;
            this.IBScombobox.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.IBScombobox.Location = new System.Drawing.Point(174, 69);
            this.IBScombobox.Name = "IBScombobox";
            this.IBScombobox.Size = new System.Drawing.Size(65, 28);
            this.IBScombobox.TabIndex = 3;
            this.IBScombobox.SelectedIndexChanged += new System.EventHandler(this.IBScombobox_SelectedIndexChanged);
            // 
            // IRcombobox
            // 
            this.IRcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IRcombobox.FormattingEnabled = true;
            this.IRcombobox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.IRcombobox.Location = new System.Drawing.Point(174, 106);
            this.IRcombobox.Name = "IRcombobox";
            this.IRcombobox.Size = new System.Drawing.Size(65, 28);
            this.IRcombobox.TabIndex = 2;
            // 
            // MMcombobox
            // 
            this.MMcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MMcombobox.FormattingEnabled = true;
            this.MMcombobox.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.MMcombobox.Location = new System.Drawing.Point(174, 140);
            this.MMcombobox.Name = "MMcombobox";
            this.MMcombobox.Size = new System.Drawing.Size(65, 28);
            this.MMcombobox.TabIndex = 2;
            this.MMcombobox.SelectedIndexChanged += new System.EventHandler(this.MMcombobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(273, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cache Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(287, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Instruction Cache (direct mapped)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(287, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "SIZE_IC:";
            // 
            // SizeICcombobox
            // 
            this.SizeICcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeICcombobox.FormattingEnabled = true;
            this.SizeICcombobox.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4092",
            "8192"});
            this.SizeICcombobox.Location = new System.Drawing.Point(353, 69);
            this.SizeICcombobox.Name = "SizeICcombobox";
            this.SizeICcombobox.Size = new System.Drawing.Size(74, 28);
            this.SizeICcombobox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(542, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Data Cache (direct mapped)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(547, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "SIZE_DC:";
            // 
            // SizeDCcombobox
            // 
            this.SizeDCcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeDCcombobox.FormattingEnabled = true;
            this.SizeDCcombobox.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.SizeDCcombobox.Location = new System.Drawing.Point(625, 74);
            this.SizeDCcombobox.Name = "SizeDCcombobox";
            this.SizeDCcombobox.Size = new System.Drawing.Size(74, 28);
            this.SizeDCcombobox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(547, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Strategy:";
            // 
            // Strategycombobox
            // 
            this.Strategycombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Strategycombobox.FormattingEnabled = true;
            this.Strategycombobox.Items.AddRange(new object[] {
            "Default",
            "Write Back",
            "Write Through"});
            this.Strategycombobox.Location = new System.Drawing.Point(620, 114);
            this.Strategycombobox.Name = "Strategycombobox";
            this.Strategycombobox.Size = new System.Drawing.Size(137, 28);
            this.Strategycombobox.TabIndex = 17;
            // 
            // SimulateButton
            // 
            this.SimulateButton.Location = new System.Drawing.Point(620, 183);
            this.SimulateButton.Name = "SimulateButton";
            this.SimulateButton.Size = new System.Drawing.Size(137, 30);
            this.SimulateButton.TabIndex = 18;
            this.SimulateButton.Text = "Simulate";
            this.SimulateButton.UseVisualStyleBackColor = true;
            this.SimulateButton.Click += new System.EventHandler(this.SimulateButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(12, 183);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(478, 27);
            this.FileTextBox.TabIndex = 19;
            this.FileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SelectTraceButton
            // 
            this.SelectTraceButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTraceButton.Location = new System.Drawing.Point(496, 183);
            this.SelectTraceButton.Name = "SelectTraceButton";
            this.SelectTraceButton.Size = new System.Drawing.Size(118, 27);
            this.SelectTraceButton.TabIndex = 20;
            this.SelectTraceButton.Text = "Select Trace";
            this.SelectTraceButton.UseVisualStyleBackColor = true;
            this.SelectTraceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Indigo;
            this.label15.Location = new System.Drawing.Point(12, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Results";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 247);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(745, 173);
            this.ResultTextBox.TabIndex = 22;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SelectTraceButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.SimulateButton);
            this.Controls.Add(this.Strategycombobox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SizeDCcombobox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SizeICcombobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MMcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IRcombobox);
            this.Controls.Add(this.IBScombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FRcombobox);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "Form1";
            this.Text = "Writing Methods - Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FRcombobox;
        private System.Windows.Forms.ComboBox IBScombobox;
        private System.Windows.Forms.ComboBox IRcombobox;
        private System.Windows.Forms.ComboBox MMcombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SizeICcombobox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox SizeDCcombobox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Strategycombobox;
        private System.Windows.Forms.Button SimulateButton;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button SelectTraceButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

