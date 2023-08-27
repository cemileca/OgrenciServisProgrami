namespace OgrenciServis.WinForm.Forms
{
    partial class KisiEkleFrm
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            cmbBxIlce = new ComboBox();
            label7 = new Label();
            cmbBxSehir = new ComboBox();
            cmbBxUlke = new ComboBox();
            txtPersonalAcikAdres = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            btnPersonalResimSil = new Button();
            btnPersonalResimEkle = new Button();
            pcBxPersonalResim = new PictureBox();
            dtpPersonalDogumTarihi = new DateTimePicker();
            txtPersonalTelefon2 = new TextBox();
            txtPersonalTelefon1 = new TextBox();
            label6 = new Label();
            txtPersonalSoyadi = new TextBox();
            label5 = new Label();
            txtPersonalAdi = new TextBox();
            label4 = new Label();
            txtKimlikNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            btnPersonalYenikayit = new Button();
            dgvPersonalListesi = new DataGridView();
            clmnKimlikNo = new DataGridViewTextBoxColumn();
            clmnPersonalAdi = new DataGridViewTextBoxColumn();
            clmnPersonalSoyadi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBxPersonalResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonalListesi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(dtpPersonalDogumTarihi);
            groupBox1.Controls.Add(txtPersonalTelefon2);
            groupBox1.Controls.Add(txtPersonalTelefon1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPersonalSoyadi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPersonalAdi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKimlikNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1233, 693);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(cmbBxIlce);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cmbBxSehir);
            groupBox3.Controls.Add(cmbBxUlke);
            groupBox3.Controls.Add(txtPersonalAcikAdres);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(6, 335);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(802, 341);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Adres Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 138);
            label9.Name = "label9";
            label9.Size = new Size(44, 32);
            label9.TabIndex = 0;
            label9.Text = "lçe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 90);
            label8.Name = "label8";
            label8.Size = new Size(68, 32);
            label8.TabIndex = 0;
            label8.Text = "Şehir";
            // 
            // cmbBxIlce
            // 
            cmbBxIlce.FormattingEnabled = true;
            cmbBxIlce.Location = new Point(172, 135);
            cmbBxIlce.Name = "cmbBxIlce";
            cmbBxIlce.Size = new Size(374, 40);
            cmbBxIlce.TabIndex = 8;
            cmbBxIlce.SelectedIndexChanged += cmbBxIlce_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 44);
            label7.Name = "label7";
            label7.Size = new Size(61, 32);
            label7.TabIndex = 0;
            label7.Text = "Ülke";
            // 
            // cmbBxSehir
            // 
            cmbBxSehir.FormattingEnabled = true;
            cmbBxSehir.Location = new Point(172, 87);
            cmbBxSehir.Name = "cmbBxSehir";
            cmbBxSehir.Size = new Size(374, 40);
            cmbBxSehir.TabIndex = 7;
            cmbBxSehir.SelectedIndexChanged += cmbBxSehir_SelectedIndexChanged;
            // 
            // cmbBxUlke
            // 
            cmbBxUlke.FormattingEnabled = true;
            cmbBxUlke.Location = new Point(172, 41);
            cmbBxUlke.Name = "cmbBxUlke";
            cmbBxUlke.Size = new Size(374, 40);
            cmbBxUlke.TabIndex = 6;
            cmbBxUlke.SelectedIndexChanged += cmbBxUlke_SelectedIndexChanged;
            // 
            // txtPersonalAcikAdres
            // 
            txtPersonalAcikAdres.Location = new Point(172, 184);
            txtPersonalAcikAdres.Multiline = true;
            txtPersonalAcikAdres.Name = "txtPersonalAcikAdres";
            txtPersonalAcikAdres.Size = new Size(610, 151);
            txtPersonalAcikAdres.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 184);
            label10.Name = "label10";
            label10.Size = new Size(125, 32);
            label10.TabIndex = 0;
            label10.Text = "Açık Adres";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPersonalResimSil);
            groupBox2.Controls.Add(btnPersonalResimEkle);
            groupBox2.Controls.Add(pcBxPersonalResim);
            groupBox2.Location = new Point(814, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 530);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kişi Resmi";
            // 
            // btnPersonalResimSil
            // 
            btnPersonalResimSil.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonalResimSil.Location = new Point(201, 457);
            btnPersonalResimSil.Margin = new Padding(1);
            btnPersonalResimSil.Name = "btnPersonalResimSil";
            btnPersonalResimSil.Size = new Size(195, 72);
            btnPersonalResimSil.TabIndex = 12;
            btnPersonalResimSil.Text = "-";
            btnPersonalResimSil.UseVisualStyleBackColor = true;
            // 
            // btnPersonalResimEkle
            // 
            btnPersonalResimEkle.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonalResimEkle.Location = new Point(-2, 457);
            btnPersonalResimEkle.Margin = new Padding(1);
            btnPersonalResimEkle.Name = "btnPersonalResimEkle";
            btnPersonalResimEkle.Size = new Size(211, 72);
            btnPersonalResimEkle.TabIndex = 11;
            btnPersonalResimEkle.Text = "+";
            btnPersonalResimEkle.UseVisualStyleBackColor = true;
            // 
            // pcBxPersonalResim
            // 
            pcBxPersonalResim.Location = new Point(0, 38);
            pcBxPersonalResim.Name = "pcBxPersonalResim";
            pcBxPersonalResim.Size = new Size(394, 423);
            pcBxPersonalResim.TabIndex = 2;
            pcBxPersonalResim.TabStop = false;
            // 
            // dtpPersonalDogumTarihi
            // 
            dtpPersonalDogumTarihi.Location = new Point(179, 195);
            dtpPersonalDogumTarihi.Name = "dtpPersonalDogumTarihi";
            dtpPersonalDogumTarihi.Size = new Size(373, 39);
            dtpPersonalDogumTarihi.TabIndex = 3;
            // 
            // txtPersonalTelefon2
            // 
            txtPersonalTelefon2.Location = new Point(178, 290);
            txtPersonalTelefon2.Name = "txtPersonalTelefon2";
            txtPersonalTelefon2.Size = new Size(374, 39);
            txtPersonalTelefon2.TabIndex = 5;
            // 
            // txtPersonalTelefon1
            // 
            txtPersonalTelefon1.Location = new Point(178, 245);
            txtPersonalTelefon1.Name = "txtPersonalTelefon1";
            txtPersonalTelefon1.Size = new Size(374, 39);
            txtPersonalTelefon1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 290);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 0;
            label6.Text = "Telefon No:2";
            // 
            // txtPersonalSoyadi
            // 
            txtPersonalSoyadi.Location = new Point(178, 141);
            txtPersonalSoyadi.Name = "txtPersonalSoyadi";
            txtPersonalSoyadi.Size = new Size(374, 39);
            txtPersonalSoyadi.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 245);
            label5.Name = "label5";
            label5.Size = new Size(150, 32);
            label5.TabIndex = 0;
            label5.Text = "Telefon No:1";
            // 
            // txtPersonalAdi
            // 
            txtPersonalAdi.Location = new Point(178, 96);
            txtPersonalAdi.Name = "txtPersonalAdi";
            txtPersonalAdi.Size = new Size(374, 39);
            txtPersonalAdi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 141);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 0;
            label4.Text = "Soyadı:";
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(178, 51);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(374, 39);
            txtKimlikNo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 96);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 0;
            label3.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 200);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 0;
            label2.Text = "Doğum Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 51);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Kimlik No:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1264, 136);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(278, 110);
            button3.TabIndex = 15;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1264, 19);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(278, 110);
            button4.TabIndex = 14;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnPersonalYenikayit
            // 
            btnPersonalYenikayit.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonalYenikayit.Location = new Point(1264, 558);
            btnPersonalYenikayit.Margin = new Padding(1);
            btnPersonalYenikayit.Name = "btnPersonalYenikayit";
            btnPersonalYenikayit.Size = new Size(268, 130);
            btnPersonalYenikayit.TabIndex = 13;
            btnPersonalYenikayit.Text = "Ekle";
            btnPersonalYenikayit.UseVisualStyleBackColor = true;
            btnPersonalYenikayit.Click += btnPersonalYenikayit_Click_1;
            // 
            // dgvPersonalListesi
            // 
            dgvPersonalListesi.AllowUserToDeleteRows = false;
            dgvPersonalListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvPersonalListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonalListesi.Columns.AddRange(new DataGridViewColumn[] { clmnKimlikNo, clmnPersonalAdi, clmnPersonalSoyadi });
            dgvPersonalListesi.Location = new Point(2, 711);
            dgvPersonalListesi.Name = "dgvPersonalListesi";
            dgvPersonalListesi.ReadOnly = true;
            dgvPersonalListesi.RowHeadersWidth = 82;
            dgvPersonalListesi.RowTemplate.Height = 41;
            dgvPersonalListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonalListesi.Size = new Size(1554, 485);
            dgvPersonalListesi.TabIndex = 4;
            // 
            // clmnKimlikNo
            // 
            clmnKimlikNo.HeaderText = "Kimlik No:";
            clmnKimlikNo.MinimumWidth = 10;
            clmnKimlikNo.Name = "clmnKimlikNo";
            clmnKimlikNo.ReadOnly = true;
            clmnKimlikNo.Width = 200;
            // 
            // clmnPersonalAdi
            // 
            clmnPersonalAdi.HeaderText = "Adı";
            clmnPersonalAdi.MinimumWidth = 10;
            clmnPersonalAdi.Name = "clmnPersonalAdi";
            clmnPersonalAdi.ReadOnly = true;
            clmnPersonalAdi.Width = 400;
            // 
            // clmnPersonalSoyadi
            // 
            clmnPersonalSoyadi.HeaderText = "Soyadı";
            clmnPersonalSoyadi.MinimumWidth = 10;
            clmnPersonalSoyadi.Name = "clmnPersonalSoyadi";
            clmnPersonalSoyadi.ReadOnly = true;
            clmnPersonalSoyadi.Width = 400;
            // 
            // KisiEkleFrm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 1226);
            Controls.Add(dgvPersonalListesi);
            Controls.Add(groupBox1);
            Controls.Add(btnPersonalYenikayit);
            Controls.Add(button3);
            Controls.Add(button4);
            Name = "KisiEkleFrm";
            Text = "Kişi Ekle";
            Load += KisiEkleFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcBxPersonalResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonalListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnPersonalResimSil;
        private Button btnPersonalResimEkle;
        private PictureBox pcBxPersonalResim;
        private DateTimePicker dtpPersonalDogumTarihi;
        private TextBox txtKimlikNo;
        private Label label2;
        private Label label1;
        private TextBox txtPersonalSoyadi;
        private TextBox txtPersonalAdi;
        private Label label4;
        private Label label3;
        private TextBox txtPersonalTelefon2;
        private TextBox txtPersonalTelefon1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private ComboBox cmbBxUlke;
        private Label label7;
        private Label label9;
        private Label label8;
        private ComboBox cmbBxIlce;
        private ComboBox cmbBxSehir;
        private TextBox txtPersonalAcikAdres;
        private Label label10;
        private Button btnPersonalYenikayit;
        private Button button4;
        private Button button3;
        private DataGridView dgvPersonalListesi;
        private DataGridViewTextBoxColumn clmnKimlikNo;
        private DataGridViewTextBoxColumn clmnPersonalAdi;
        private DataGridViewTextBoxColumn clmnPersonalSoyadi;
    }
}