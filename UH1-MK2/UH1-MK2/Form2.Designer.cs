namespace UH1_MK2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grpbdatadiri = new GroupBox();
            lbljabatan = new Label();
            lblnama = new Label();
            grpbrincian = new GroupBox();
            lblpajak = new Label();
            lbltunjangan = new Label();
            lblgajipokok = new Label();
            lblgajibersih = new Label();
            txtboxgaji = new TextBox();
            btnback = new Button();
            grpbdatadiri.SuspendLayout();
            grpbrincian.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(308, 36);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "REKAP GAJI";
            // 
            // grpbdatadiri
            // 
            grpbdatadiri.Controls.Add(lbljabatan);
            grpbdatadiri.Controls.Add(lblnama);
            grpbdatadiri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbdatadiri.ForeColor = Color.PaleVioletRed;
            grpbdatadiri.Location = new Point(61, 99);
            grpbdatadiri.Name = "grpbdatadiri";
            grpbdatadiri.Size = new Size(283, 140);
            grpbdatadiri.TabIndex = 1;
            grpbdatadiri.TabStop = false;
            grpbdatadiri.Text = "Data Diri";
            // 
            // lbljabatan
            // 
            lbljabatan.AutoSize = true;
            lbljabatan.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljabatan.Location = new Point(24, 83);
            lbljabatan.Name = "lbljabatan";
            lbljabatan.Size = new Size(97, 26);
            lbljabatan.TabIndex = 1;
            lbljabatan.Text = "Jabatan :";
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.Location = new Point(24, 39);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(85, 26);
            lblnama.TabIndex = 0;
            lblnama.Text = "Nama : ";
            // 
            // grpbrincian
            // 
            grpbrincian.Controls.Add(lblpajak);
            grpbrincian.Controls.Add(lbltunjangan);
            grpbrincian.Controls.Add(lblgajipokok);
            grpbrincian.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbrincian.ForeColor = Color.PaleVioletRed;
            grpbrincian.Location = new Point(411, 99);
            grpbrincian.Name = "grpbrincian";
            grpbrincian.Size = new Size(343, 166);
            grpbrincian.TabIndex = 2;
            grpbrincian.TabStop = false;
            grpbrincian.Text = "Rincian Gaji";
            // 
            // lblpajak
            // 
            lblpajak.AutoSize = true;
            lblpajak.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpajak.Location = new Point(19, 113);
            lblpajak.Name = "lblpajak";
            lblpajak.Size = new Size(80, 26);
            lblpajak.TabIndex = 2;
            lblpajak.Text = "Pajak : ";
            // 
            // lbltunjangan
            // 
            lbltunjangan.AutoSize = true;
            lbltunjangan.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltunjangan.Location = new Point(19, 77);
            lbltunjangan.Name = "lbltunjangan";
            lbltunjangan.Size = new Size(129, 26);
            lbltunjangan.TabIndex = 1;
            lbltunjangan.Text = "Tunjangan : ";
            // 
            // lblgajipokok
            // 
            lblgajipokok.AutoSize = true;
            lblgajipokok.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgajipokok.Location = new Point(19, 39);
            lblgajipokok.Name = "lblgajipokok";
            lblgajipokok.Size = new Size(130, 26);
            lblgajipokok.TabIndex = 0;
            lblgajipokok.Text = "Gaji Pokok : ";
            // 
            // lblgajibersih
            // 
            lblgajibersih.AutoSize = true;
            lblgajibersih.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgajibersih.ForeColor = Color.PaleVioletRed;
            lblgajibersih.Location = new Point(423, 299);
            lblgajibersih.Name = "lblgajibersih";
            lblgajibersih.Size = new Size(131, 26);
            lblgajibersih.TabIndex = 3;
            lblgajibersih.Text = "Gaji Bersih : ";
            // 
            // txtboxgaji
            // 
            txtboxgaji.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtboxgaji.Location = new Point(560, 300);
            txtboxgaji.Multiline = true;
            txtboxgaji.Name = "txtboxgaji";
            txtboxgaji.ReadOnly = true;
            txtboxgaji.Size = new Size(170, 34);
            txtboxgaji.TabIndex = 4;
            // 
            // btnback
            // 
            btnback.BackColor = Color.PaleVioletRed;
            btnback.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(83, 384);
            btnback.Name = "btnback";
            btnback.Size = new Size(121, 35);
            btnback.TabIndex = 5;
            btnback.Text = "Log Out";
            btnback.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(btnback);
            Controls.Add(txtboxgaji);
            Controls.Add(lblgajibersih);
            Controls.Add(grpbrincian);
            Controls.Add(grpbdatadiri);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            grpbdatadiri.ResumeLayout(false);
            grpbdatadiri.PerformLayout();
            grpbrincian.ResumeLayout(false);
            grpbrincian.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpbdatadiri;
        private Label lbljabatan;
        private Label lblnama;
        private GroupBox grpbrincian;
        private Label lblgajibersih;
        private Label lblpajak;
        private Label lbltunjangan;
        private Label lblgajipokok;
        private TextBox txtboxgaji;
        private Button btnback;
    }
}