
namespace YolcuBiletRezervasyonu
{
    partial class FrmSeferEkle
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSeferNumara = new System.Windows.Forms.TextBox();
            this.TxtKalkis = new System.Windows.Forms.TextBox();
            this.TxtVaris = new System.Windows.Forms.TextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.Msksaat = new System.Windows.Forms.MaskedTextBox();
            this.Mskkaptan = new System.Windows.Forms.MaskedTextBox();
            this.MskFiyat = new System.Windows.Forms.TextBox();
            this.BtnSeferOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kaptan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Varış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kalkış:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sefer No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fiyat:";
            // 
            // TxtSeferNumara
            // 
            this.TxtSeferNumara.Enabled = false;
            this.TxtSeferNumara.Location = new System.Drawing.Point(152, 53);
            this.TxtSeferNumara.Name = "TxtSeferNumara";
            this.TxtSeferNumara.Size = new System.Drawing.Size(202, 34);
            this.TxtSeferNumara.TabIndex = 26;
            // 
            // TxtKalkis
            // 
            this.TxtKalkis.Location = new System.Drawing.Point(152, 102);
            this.TxtKalkis.Name = "TxtKalkis";
            this.TxtKalkis.Size = new System.Drawing.Size(202, 34);
            this.TxtKalkis.TabIndex = 27;
            // 
            // TxtVaris
            // 
            this.TxtVaris.Location = new System.Drawing.Point(152, 149);
            this.TxtVaris.Name = "TxtVaris";
            this.TxtVaris.Size = new System.Drawing.Size(202, 34);
            this.TxtVaris.TabIndex = 28;
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(152, 198);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(201, 34);
            this.MskTarih.TabIndex = 29;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Msksaat
            // 
            this.Msksaat.Location = new System.Drawing.Point(152, 244);
            this.Msksaat.Mask = "00:00";
            this.Msksaat.Name = "Msksaat";
            this.Msksaat.Size = new System.Drawing.Size(201, 34);
            this.Msksaat.TabIndex = 30;
            this.Msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // Mskkaptan
            // 
            this.Mskkaptan.Location = new System.Drawing.Point(152, 290);
            this.Mskkaptan.Mask = "0000";
            this.Mskkaptan.Name = "Mskkaptan";
            this.Mskkaptan.Size = new System.Drawing.Size(201, 34);
            this.Mskkaptan.TabIndex = 31;
            this.Mskkaptan.ValidatingType = typeof(int);
            // 
            // MskFiyat
            // 
            this.MskFiyat.Location = new System.Drawing.Point(151, 341);
            this.MskFiyat.Name = "MskFiyat";
            this.MskFiyat.Size = new System.Drawing.Size(202, 34);
            this.MskFiyat.TabIndex = 32;
            // 
            // BtnSeferOlustur
            // 
            this.BtnSeferOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSeferOlustur.ForeColor = System.Drawing.Color.Black;
            this.BtnSeferOlustur.Location = new System.Drawing.Point(152, 381);
            this.BtnSeferOlustur.Name = "BtnSeferOlustur";
            this.BtnSeferOlustur.Size = new System.Drawing.Size(202, 40);
            this.BtnSeferOlustur.TabIndex = 33;
            this.BtnSeferOlustur.Text = "Sefer Oluştur";
            this.BtnSeferOlustur.UseVisualStyleBackColor = false;
            this.BtnSeferOlustur.Click += new System.EventHandler(this.BtnSeferOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(403, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 427);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmSeferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1295, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSeferOlustur);
            this.Controls.Add(this.MskFiyat);
            this.Controls.Add(this.Mskkaptan);
            this.Controls.Add(this.Msksaat);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.TxtVaris);
            this.Controls.Add(this.TxtKalkis);
            this.Controls.Add(this.TxtSeferNumara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSeferEkle";
            this.Text = "SEFER";
            this.Load += new System.EventHandler(this.FrmSeferEkle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSeferNumara;
        private System.Windows.Forms.TextBox TxtKalkis;
        private System.Windows.Forms.TextBox TxtVaris;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.MaskedTextBox Msksaat;
        private System.Windows.Forms.MaskedTextBox Mskkaptan;
        private System.Windows.Forms.TextBox MskFiyat;
        private System.Windows.Forms.Button BtnSeferOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}