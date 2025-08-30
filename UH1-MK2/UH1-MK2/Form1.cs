using System;
using System.Windows.Forms;

namespace UH1_MK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);

            // isi pilihan jabatan
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("Supervisor");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Magang");

            // event handler kalau jabatan dipilih
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // otomatis isi gaji & tunjangan sesuai jabatan
            switch (comboBox1.Text)
            {
                case "Manager":
                    textBox1.Text = "10000000";  // Gaji Pokok
                    textBox2.Text = "2000000";   // Tunjangan
                    break;
                case "Supervisor":
                    textBox1.Text = "7000000";
                    textBox2.Text = "1500000";
                    break;
                case "Staff":
                    textBox1.Text = "5000000";
                    textBox2.Text = "1000000";
                    break;
                case "Magang":
                    textBox1.Text = "2000000";
                    textBox2.Text = "500000";
                    break;
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = txtbnama.Text;
                string jabatan = comboBox1.Text;

                double gaji = Convert.ToDouble(textBox1.Text);
                double tunjangan = Convert.ToDouble(textBox2.Text);

                // kirim data ke Form2
                Form2 form2 = new Form2(nama, jabatan, gaji, tunjangan);
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input tidak valid: " + ex.Message);
            }
        }
    }
}
