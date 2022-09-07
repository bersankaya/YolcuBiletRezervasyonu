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
    public partial class FrmSeferEkle : Form
    {
        public FrmSeferEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AGQ4V6UP;Initial Catalog=YolcuBiletRezervasyonu;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void BtnSeferOlustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", TxtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", TxtVaris.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", Msksaat.Text);
            komut.Parameters.AddWithValue("@p5", Mskkaptan.Text);
            komut.Parameters.AddWithValue("@p6", MskFiyat.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sefer Oluşturuldu");
            listele();
        }

        private void FrmSeferEkle_Load(object sender, EventArgs e)
        {
            listele();
            
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmSeferRezervasyonu fr = new FrmSeferRezervasyonu();
            fr.seferno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
           
            
        }
    }
}
