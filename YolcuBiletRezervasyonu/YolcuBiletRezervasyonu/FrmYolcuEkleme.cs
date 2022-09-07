using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace YolcuBiletRezervasyonu
{
    public partial class FrmYolcuEkleme : Form
    {
        public FrmYolcuEkleme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AGQ4V6UP;Initial Catalog=YolcuBiletRezervasyonu;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLYOLCUBILGI", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTelefon.Text = "";
            MskTC.Text = "";
            TxtMail.Text = "";
            CmbCinsiyet.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Yolcu Eklenmiştir");
            listele();
            temizle();
        }

        private void FrmYolcuEkleme_Load(object sender, EventArgs e)
        {
            
            listele();
        }
    }
}
