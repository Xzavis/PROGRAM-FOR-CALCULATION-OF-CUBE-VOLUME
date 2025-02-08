using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAM_FOR_CALCULATION_OF_CUBE_VOLUME
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // inisiasi variable
            // ketika di submit Hitung
            double Panjang = 0.0;
            double Lebar = 0.0;
            double Tinggi = 0.0;
            double Volume = 0.0;

            // input data dan menyimpan pada setiap input
            Panjang = Double.Parse(txtPanjang.Text);
            Lebar = Double.Parse(txtLebar.Text);
            Tinggi= Double.Parse(txtTinggi.Text);

            // rumus volume kubus
            Volume = Panjang * Lebar * Tinggi;

            // menampilkan hasil volume kubus
            txtVolume.Text = Volume.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPanjang.Text = "";
            txtLebar.Text = "";
            txtTinggi.Text = "";
            txtVolume.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
