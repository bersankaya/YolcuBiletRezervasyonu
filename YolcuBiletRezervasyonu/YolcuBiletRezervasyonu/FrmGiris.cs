using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YolcuBiletRezervasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKoltuk fr = new FrmKoltuk();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYolcuEkleme fr = new FrmYolcuEkleme();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSeferEkle fr = new FrmSeferEkle();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKaptan fr = new FrmKaptan();
            fr.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSeferRezervasyonu fr = new FrmSeferRezervasyonu();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
