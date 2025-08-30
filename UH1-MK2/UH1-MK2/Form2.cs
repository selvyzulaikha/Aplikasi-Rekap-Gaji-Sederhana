using System;
using System.Windows.Forms;

namespace UH1_MK2
{
    public partial class Form2 : Form
    {
        private string nama;
        private string jabatan;
        private double gaji;
        private double tunjangan;

        public Form2(string nama, string jabatan, double gaji, double tunjangan)
        {
            InitializeComponent();
            this.btnback.Click += new System.EventHandler(this.btnback_Click);

            this.nama = nama;
            this.jabatan = jabatan;
            this.gaji = gaji;
            this.tunjangan = tunjangan;

            // tampilkan data
            lblnama.Text = "Nama : " + nama;
            lbljabatan.Text = "Jabatan : " + jabatan;
            lblgajipokok.Text = "Gaji Pokok : Rp " + gaji.ToString("N0");
            lbltunjangan.Text = "Tunjangan : Rp " + tunjangan.ToString("N0");

            // hitung potongan (pajak 2,5%)
            double pajak = gaji * 0.025;
            lblpajak.Text = "Pajak (2,5%) : Rp " + pajak.ToString("N0");

            // hitung gaji bersih
            double gajiBersih = gaji + tunjangan - pajak;
            txtboxgaji.Text = "Rp " + gajiBersih.ToString("N0");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
