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
    public partial class FrmKaptan : Form
    {
        public FrmKaptan()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AGQ4V6UP;Initial Catalog=YolcuBiletRezervasyonu;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKAPTAN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
        }
        void temizle()
        {
            TxtAdSoyad.Text = "";
            Mskkaptan.Text = "";
            MskTelefon.Text = "";
            
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)", conn);
            komut.Parameters.AddWithValue("@p1", Mskkaptan.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kaptan Sisteme Eklendi");
            listele();
            temizle();
        }

        private void FrmKaptan_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
