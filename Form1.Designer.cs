
namespace Proiect_simulator
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BS1combobox = new System.Windows.Forms.ComboBox();
            this.SizeICcombobox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BS2combobox = new System.Windows.Forms.ComboBox();
            this.SizeDCcombobox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Strategycombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Issue Rate Max (IRmax):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Main Memory latecy:";
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
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(273, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cache Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(287, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Instruction Cache (direct mapped)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(269, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bloc Size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(427, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "= FR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(269, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "SIZE_IC:";
            // 
            // BS1combobox
            // 
            this.BS1combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BS1combobox.FormattingEnabled = true;
            this.BS1combobox.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.BS1combobox.Location = new System.Drawing.Point(347, 72);
            this.BS1combobox.Name = "BS1combobox";
            this.BS1combobox.Size = new System.Drawing.Size(74, 28);
            this.BS1combobox.TabIndex = 9;
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
            this.SizeICcombobox.Location = new System.Drawing.Point(347, 106);
            this.SizeICcombobox.Name = "SizeICcombobox";
            this.SizeICcombobox.Size = new System.Drawing.Size(74, 28);
            this.SizeICcombobox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(562, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Data Cache (direct mapped)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(542, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Bloc Size:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(547, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "SIZE_DC:";
            // 
            // BS2combobox
            // 
            this.BS2combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BS2combobox.FormattingEnabled = true;
            this.BS2combobox.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.BS2combobox.Location = new System.Drawing.Point(625, 72);
            this.BS2combobox.Name = "BS2combobox";
            this.BS2combobox.Size = new System.Drawing.Size(74, 28);
            this.BS2combobox.TabIndex = 14;
            this.BS2combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.SizeDCcombobox.Location = new System.Drawing.Point(625, 106);
            this.SizeDCcombobox.Name = "SizeDCcombobox";
            this.SizeDCcombobox.Size = new System.Drawing.Size(74, 28);
            this.SizeDCcombobox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(547, 143);
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
            this.Strategycombobox.Location = new System.Drawing.Point(625, 140);
            this.Strategycombobox.Name = "Strategycombobox";
            this.Strategycombobox.Size = new System.Drawing.Size(137, 28);
            this.Strategycombobox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Strategycombobox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SizeDCcombobox);
            this.Controls.Add(this.BS2combobox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SizeICcombobox);
            this.Controls.Add(this.BS1combobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Cache Parameters";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox BS1combobox;
        private System.Windows.Forms.ComboBox SizeICcombobox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox BS2combobox;
        private System.Windows.Forms.ComboBox SizeDCcombobox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Strategycombobox;
    }
}

