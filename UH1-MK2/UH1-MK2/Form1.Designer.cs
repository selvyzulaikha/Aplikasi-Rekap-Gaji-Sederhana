namespace UH1_MK2
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
            judul = new Label();
            txtnama = new Label();
            txtbnama = new TextBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            txtjabatan = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnsubmit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judul.ForeColor = Color.PaleVioletRed;
            judul.Location = new Point(320, 24);
            judul.Name = "judul";
            judul.Size = new Size(199, 39);
            judul.TabIndex = 0;
            judul.Text = "INPUT DATA";
            // 
            // txtnama
            // 
            txtnama.AutoSize = true;
            txtnama.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnama.ForeColor = Color.PaleVioletRed;
            txtnama.Location = new Point(21, 42);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(68, 26);
            txtnama.TabIndex = 1;
            txtnama.Text = "Nama";
            // 
            // txtbnama
            // 
            txtbnama.Location = new Point(117, 40);
            txtbnama.Multiline = true;
            txtbnama.Name = "txtbnama";
            txtbnama.Size = new Size(177, 33);
            txtbnama.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtjabatan);
            groupBox1.Controls.Add(txtnama);
            groupBox1.Controls.Add(txtbnama);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.PaleVioletRed;
            groupBox1.Location = new Point(63, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 166);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Isi Identitas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 4;
            // 
            // txtjabatan
            // 
            txtjabatan.AutoSize = true;
            txtjabatan.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtjabatan.ForeColor = Color.PaleVioletRed;
            txtjabatan.Location = new Point(20, 99);
            txtjabatan.Name = "txtjabatan";
            txtjabatan.Size = new Size(86, 26);
            txtjabatan.TabIndex = 3;
            txtjabatan.Text = "Jabatan";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.PaleVioletRed;
            groupBox2.Location = new Point(418, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 166);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rincian Singkat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 101);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(176, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(176, 29);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 102);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 1;
            label2.Text = "Tunjangan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 26);
            label1.TabIndex = 0;
            label1.Text = "Gaji";
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.PaleVioletRed;
            btnsubmit.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(608, 374);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(136, 37);
            btnsubmit.TabIndex = 5;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsubmit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(judul);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label judul;
        private Label txtnama;
        private TextBox txtbnama;
        private GroupBox groupBox1;
        private Label txtjabatan;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnsubmit;
    }
}
