using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YolcuBiletRezervasyonu
{
    public partial class FrmSeferRezervasyonu : Form
    {
        public FrmSeferRezervasyonu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AGQ4V6UP;Initial Catalog=YolcuBiletRezervasyonu;Integrated Security=True");
        public string seferno;
        bool durum;
       void mukerrerkayit()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLYOLCUBILGI where TC=@p4", conn);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;

            }
            else
            {
                durum = true;
            }
            conn.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            mukerrerkayit();
            if (durum == false)
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values (@p1,@p2,@p3)", conn);
                kmt.Parameters.AddWithValue("@p1", TxtSeferNo.Text);
                kmt.Parameters.AddWithValue("@p2", MskTC.Text);
                kmt.Parameters.AddWithValue("@p3", TxtKoltukNo.Text);
                kmt.ExecuteNonQuery();
                conn.Close();
                this.tBLSEFERDETAYTableAdapter.Fill(this.yolcuBiletRezervasyonuDataSet.TBLSEFERDETAY);
                MessageBox.Show("REZERVASYON YAPILDI İYİ YOLCULUKLAR DİLERİZ ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("SİSTEMDE BÖYLE BİRİ YOK");
            }
        }

        private void FrmSeferRezervasyonu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yolcuBiletRezervasyonuDataSet.TBLSEFERDETAY' table. You can move, or remove it, as needed.
            this.tBLSEFERDETAYTableAdapter.Fill(this.yolcuBiletRezervasyonuDataSet.TBLSEFERDETAY);
            TxtSeferNo.Text = seferno;
        }

       
    }
}
