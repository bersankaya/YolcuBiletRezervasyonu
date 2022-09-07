
namespace YolcuBiletRezervasyonu
{
    partial class FrmSeferRezervasyonu
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
            this.components = new System.ComponentModel.Container();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtKoltukNo = new System.Windows.Forms.TextBox();
            this.TxtSeferNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yolcuBiletRezervasyonuDataSet = new YolcuBiletRezervasyonu.YolcuBiletRezervasyonuDataSet();
            this.tBLSEFERDETAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLSEFERDETAYTableAdapter = new YolcuBiletRezervasyonu.YolcuBiletRezervasyonuDataSetTableAdapters.TBLSEFERDETAYTableAdapter();
            this.yOLCULUKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEFERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yOLCUTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOLTUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBiletRezervasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSEFERDETAYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(162, 204);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(178, 39);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(162, 105);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(178, 34);
            this.MskTC.TabIndex = 20;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtKoltukNo
            // 
            this.TxtKoltukNo.Location = new System.Drawing.Point(162, 154);
            this.TxtKoltukNo.Name = "TxtKoltukNo";
            this.TxtKoltukNo.Size = new System.Drawing.Size(178, 34);
            this.TxtKoltukNo.TabIndex = 19;
            // 
            // TxtSeferNo
            // 
            this.TxtSeferNo.Location = new System.Drawing.Point(162, 55);
            this.TxtSeferNo.Name = "TxtSeferNo";
            this.TxtSeferNo.Size = new System.Drawing.Size(178, 34);
            this.TxtSeferNo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Koltuk No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sefer No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(346, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 295);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yOLCULUKIDDataGridViewTextBoxColumn,
            this.sEFERNODataGridViewTextBoxColumn,
            this.yOLCUTCDataGridViewTextBoxColumn,
            this.kOLTUKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLSEFERDETAYBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 262);
            this.dataGridView1.TabIndex = 23;
            // 
            // yolcuBiletRezervasyonuDataSet
            // 
            this.yolcuBiletRezervasyonuDataSet.DataSetName = "YolcuBiletRezervasyonuDataSet";
            this.yolcuBiletRezervasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSEFERDETAYBindingSource
            // 
            this.tBLSEFERDETAYBindingSource.DataMember = "TBLSEFERDETAY";
            this.tBLSEFERDETAYBindingSource.DataSource = this.yolcuBiletRezervasyonuDataSet;
            // 
            // tBLSEFERDETAYTableAdapter
            // 
            this.tBLSEFERDETAYTableAdapter.ClearBeforeFill = true;
            // 
            // yOLCULUKIDDataGridViewTextBoxColumn
            // 
            this.yOLCULUKIDDataGridViewTextBoxColumn.DataPropertyName = "YOLCULUKID";
            this.yOLCULUKIDDataGridViewTextBoxColumn.HeaderText = "YOLCULUKID";
            this.yOLCULUKIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yOLCULUKIDDataGridViewTextBoxColumn.Name = "yOLCULUKIDDataGridViewTextBoxColumn";
            this.yOLCULUKIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEFERNODataGridViewTextBoxColumn
            // 
            this.sEFERNODataGridViewTextBoxColumn.DataPropertyName = "SEFERNO";
            this.sEFERNODataGridViewTextBoxColumn.HeaderText = "SEFERNO";
            this.sEFERNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEFERNODataGridViewTextBoxColumn.Name = "sEFERNODataGridViewTextBoxColumn";
            // 
            // yOLCUTCDataGridViewTextBoxColumn
            // 
            this.yOLCUTCDataGridViewTextBoxColumn.DataPropertyName = "YOLCUTC";
            this.yOLCUTCDataGridViewTextBoxColumn.HeaderText = "YOLCUTC";
            this.yOLCUTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yOLCUTCDataGridViewTextBoxColumn.Name = "yOLCUTCDataGridViewTextBoxColumn";
            // 
            // kOLTUKDataGridViewTextBoxColumn
            // 
            this.kOLTUKDataGridViewTextBoxColumn.DataPropertyName = "KOLTUK";
            this.kOLTUKDataGridViewTextBoxColumn.HeaderText = "KOLTUK";
            this.kOLTUKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kOLTUKDataGridViewTextBoxColumn.Name = "kOLTUKDataGridViewTextBoxColumn";
            // 
            // FrmSeferRezervasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(990, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtKoltukNo);
            this.Controls.Add(this.TxtSeferNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmSeferRezervasyonu";
            this.Text = "SEFER REZERVASYONU";
            this.Load += new System.EventHandler(this.FrmSeferRezervasyonu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBiletRezervasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSEFERDETAYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtKoltukNo;
        private System.Windows.Forms.TextBox TxtSeferNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YolcuBiletRezervasyonuDataSet yolcuBiletRezervasyonuDataSet;
        private System.Windows.Forms.BindingSource tBLSEFERDETAYBindingSource;
        private YolcuBiletRezervasyonuDataSetTableAdapters.TBLSEFERDETAYTableAdapter tBLSEFERDETAYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yOLCULUKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEFERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yOLCUTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOLTUKDataGridViewTextBoxColumn;
    }
}