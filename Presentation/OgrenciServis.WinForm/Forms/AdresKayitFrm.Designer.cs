namespace OgrenciServis.WinForm.Forms
{
    partial class AdresKayitFrm
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
            grpBxYeniAdresEkle = new GroupBox();
            txtYeniılceZipKodu = new TextBox();
            txtBxYeniSehirKodu = new TextBox();
            txtYeniUlkeKodu = new TextBox();
            txtAcikAdresEKle = new TextBox();
            txtYeniIlceEkle = new TextBox();
            txtYeniSehirEkle = new TextBox();
            txtAdresAdi = new TextBox();
            txtYeniUlkeEkle = new TextBox();
            btnIlceKayitBitir = new Button();
            btnSehirKayitBitir = new Button();
            btnUlkeKayitBitir = new Button();
            btnEkle = new Button();
            btnIptal = new Button();
            btnYeniIlceEkle = new Button();
            btnSehirEkle = new Button();
            btnUlkeEkle = new Button();
            cmbBxIlceAdlari = new ComboBox();
            cmbBxSehirAdlari = new ComboBox();
            lblAcikAdres = new Label();
            lblIlceAdi = new Label();
            lblSehirAdi = new Label();
            cmbBxUlkeAdlari = new ComboBox();
            lblAdresAdi = new Label();
            lblUlkeAdi = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnGuncelle = new Button();
            grpBxYeniAdresEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxYeniAdresEkle
            // 
            grpBxYeniAdresEkle.Controls.Add(textBox3);
            grpBxYeniAdresEkle.Controls.Add(textBox2);
            grpBxYeniAdresEkle.Controls.Add(txtYeniılceZipKodu);
            grpBxYeniAdresEkle.Controls.Add(textBox1);
            grpBxYeniAdresEkle.Controls.Add(txtBxYeniSehirKodu);
            grpBxYeniAdresEkle.Controls.Add(txtYeniUlkeKodu);
            grpBxYeniAdresEkle.Controls.Add(txtAcikAdresEKle);
            grpBxYeniAdresEkle.Controls.Add(txtYeniIlceEkle);
            grpBxYeniAdresEkle.Controls.Add(txtYeniSehirEkle);
            grpBxYeniAdresEkle.Controls.Add(txtAdresAdi);
            grpBxYeniAdresEkle.Controls.Add(txtYeniUlkeEkle);
            grpBxYeniAdresEkle.Controls.Add(btnIlceKayitBitir);
            grpBxYeniAdresEkle.Controls.Add(btnSehirKayitBitir);
            grpBxYeniAdresEkle.Controls.Add(btnUlkeKayitBitir);
            grpBxYeniAdresEkle.Controls.Add(btnGuncelle);
            grpBxYeniAdresEkle.Controls.Add(btnEkle);
            grpBxYeniAdresEkle.Controls.Add(btnIptal);
            grpBxYeniAdresEkle.Controls.Add(btnYeniIlceEkle);
            grpBxYeniAdresEkle.Controls.Add(btnSehirEkle);
            grpBxYeniAdresEkle.Controls.Add(btnUlkeEkle);
            grpBxYeniAdresEkle.Controls.Add(cmbBxIlceAdlari);
            grpBxYeniAdresEkle.Controls.Add(cmbBxSehirAdlari);
            grpBxYeniAdresEkle.Controls.Add(lblAcikAdres);
            grpBxYeniAdresEkle.Controls.Add(lblIlceAdi);
            grpBxYeniAdresEkle.Controls.Add(lblSehirAdi);
            grpBxYeniAdresEkle.Controls.Add(cmbBxUlkeAdlari);
            grpBxYeniAdresEkle.Controls.Add(lblAdresAdi);
            grpBxYeniAdresEkle.Controls.Add(lblUlkeAdi);
            grpBxYeniAdresEkle.Location = new Point(22, 26);
            grpBxYeniAdresEkle.Margin = new Padding(6);
            grpBxYeniAdresEkle.Name = "grpBxYeniAdresEkle";
            grpBxYeniAdresEkle.Padding = new Padding(6);
            grpBxYeniAdresEkle.Size = new Size(1695, 562);
            grpBxYeniAdresEkle.TabIndex = 0;
            grpBxYeniAdresEkle.TabStop = false;
            grpBxYeniAdresEkle.Text = "Yeni Adres Ekle";
            // 
            // txtYeniılceZipKodu
            // 
            txtYeniılceZipKodu.Enabled = false;
            txtYeniılceZipKodu.Location = new Point(877, 271);
            txtYeniılceZipKodu.Margin = new Padding(6);
            txtYeniılceZipKodu.Name = "txtYeniılceZipKodu";
            txtYeniılceZipKodu.PlaceholderText = "İlçe Zipkodu";
            txtYeniılceZipKodu.Size = new Size(145, 39);
            txtYeniılceZipKodu.TabIndex = 3;
            // 
            // txtBxYeniSehirKodu
            // 
            txtBxYeniSehirKodu.Enabled = false;
            txtBxYeniSehirKodu.Location = new Point(877, 187);
            txtBxYeniSehirKodu.Margin = new Padding(6);
            txtBxYeniSehirKodu.Name = "txtBxYeniSehirKodu";
            txtBxYeniSehirKodu.PlaceholderText = "Şehir Kodu";
            txtBxYeniSehirKodu.Size = new Size(145, 39);
            txtBxYeniSehirKodu.TabIndex = 3;
            // 
            // txtYeniUlkeKodu
            // 
            txtYeniUlkeKodu.Enabled = false;
            txtYeniUlkeKodu.Location = new Point(877, 100);
            txtYeniUlkeKodu.Margin = new Padding(6);
            txtYeniUlkeKodu.Name = "txtYeniUlkeKodu";
            txtYeniUlkeKodu.PlaceholderText = "Ülke Kodu";
            txtYeniUlkeKodu.Size = new Size(145, 39);
            txtYeniUlkeKodu.TabIndex = 3;
            // 
            // txtAcikAdresEKle
            // 
            txtAcikAdresEKle.Location = new Point(4, 390);
            txtAcikAdresEKle.Margin = new Padding(6);
            txtAcikAdresEKle.Multiline = true;
            txtAcikAdresEKle.Name = "txtAcikAdresEKle";
            txtAcikAdresEKle.Size = new Size(547, 126);
            txtAcikAdresEKle.TabIndex = 7;
            // 
            // txtYeniIlceEkle
            // 
            txtYeniIlceEkle.Enabled = false;
            txtYeniIlceEkle.Location = new Point(553, 271);
            txtYeniIlceEkle.Margin = new Padding(6);
            txtYeniIlceEkle.Name = "txtYeniIlceEkle";
            txtYeniIlceEkle.PlaceholderText = "Yeni İlçe Ekle";
            txtYeniIlceEkle.Size = new Size(316, 39);
            txtYeniIlceEkle.TabIndex = 3;
            // 
            // txtYeniSehirEkle
            // 
            txtYeniSehirEkle.Enabled = false;
            txtYeniSehirEkle.Location = new Point(553, 187);
            txtYeniSehirEkle.Margin = new Padding(6);
            txtYeniSehirEkle.Name = "txtYeniSehirEkle";
            txtYeniSehirEkle.PlaceholderText = "Yeni Şehir Ekle";
            txtYeniSehirEkle.Size = new Size(316, 39);
            txtYeniSehirEkle.TabIndex = 3;
            // 
            // txtAdresAdi
            // 
            txtAdresAdi.Location = new Point(113, 44);
            txtAdresAdi.Margin = new Padding(6);
            txtAdresAdi.Name = "txtAdresAdi";
            txtAdresAdi.PlaceholderText = "Ev Adresi..";
            txtAdresAdi.Size = new Size(389, 39);
            txtAdresAdi.TabIndex = 0;
            // 
            // txtYeniUlkeEkle
            // 
            txtYeniUlkeEkle.Enabled = false;
            txtYeniUlkeEkle.Location = new Point(553, 100);
            txtYeniUlkeEkle.Margin = new Padding(6);
            txtYeniUlkeEkle.Name = "txtYeniUlkeEkle";
            txtYeniUlkeEkle.PlaceholderText = "Yeni Ülke Ekle";
            txtYeniUlkeEkle.Size = new Size(316, 39);
            txtYeniUlkeEkle.TabIndex = 3;
            // 
            // btnIlceKayitBitir
            // 
            btnIlceKayitBitir.Enabled = false;
            btnIlceKayitBitir.Location = new Point(1608, 271);
            btnIlceKayitBitir.Margin = new Padding(6);
            btnIlceKayitBitir.Name = "btnIlceKayitBitir";
            btnIlceKayitBitir.Size = new Size(72, 39);
            btnIlceKayitBitir.TabIndex = 2;
            btnIlceKayitBitir.Text = "+";
            btnIlceKayitBitir.UseVisualStyleBackColor = true;
            btnIlceKayitBitir.Click += btnIlceKayitBitir_Click;
            // 
            // btnSehirKayitBitir
            // 
            btnSehirKayitBitir.Enabled = false;
            btnSehirKayitBitir.Location = new Point(1608, 187);
            btnSehirKayitBitir.Margin = new Padding(6);
            btnSehirKayitBitir.Name = "btnSehirKayitBitir";
            btnSehirKayitBitir.Size = new Size(72, 39);
            btnSehirKayitBitir.TabIndex = 2;
            btnSehirKayitBitir.Text = "+";
            btnSehirKayitBitir.UseVisualStyleBackColor = true;
            btnSehirKayitBitir.Click += btnSehirKayitBitir_Click;
            // 
            // btnUlkeKayitBitir
            // 
            btnUlkeKayitBitir.Enabled = false;
            btnUlkeKayitBitir.Location = new Point(1608, 100);
            btnUlkeKayitBitir.Margin = new Padding(6);
            btnUlkeKayitBitir.Name = "btnUlkeKayitBitir";
            btnUlkeKayitBitir.Size = new Size(72, 39);
            btnUlkeKayitBitir.TabIndex = 2;
            btnUlkeKayitBitir.Text = "+";
            btnUlkeKayitBitir.UseVisualStyleBackColor = true;
            btnUlkeKayitBitir.Click += btnUlkeKayitBitir_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(1326, 390);
            btnEkle.Margin = new Padding(6);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(354, 126);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(576, 390);
            btnIptal.Margin = new Padding(6);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(344, 126);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnYeniIlceEkle
            // 
            btnYeniIlceEkle.Location = new Point(501, 271);
            btnYeniIlceEkle.Margin = new Padding(6);
            btnYeniIlceEkle.Name = "btnYeniIlceEkle";
            btnYeniIlceEkle.Size = new Size(50, 39);
            btnYeniIlceEkle.TabIndex = 6;
            btnYeniIlceEkle.Text = "+";
            btnYeniIlceEkle.UseVisualStyleBackColor = true;
            btnYeniIlceEkle.Click += btnYeniIlceEkle_Click;
            // 
            // btnSehirEkle
            // 
            btnSehirEkle.Location = new Point(501, 187);
            btnSehirEkle.Margin = new Padding(6);
            btnSehirEkle.Name = "btnSehirEkle";
            btnSehirEkle.Size = new Size(50, 39);
            btnSehirEkle.TabIndex = 4;
            btnSehirEkle.Text = "+";
            btnSehirEkle.UseVisualStyleBackColor = true;
            btnSehirEkle.Click += btnSehirEkle_Click;
            // 
            // btnUlkeEkle
            // 
            btnUlkeEkle.Location = new Point(501, 100);
            btnUlkeEkle.Margin = new Padding(6);
            btnUlkeEkle.Name = "btnUlkeEkle";
            btnUlkeEkle.Size = new Size(50, 39);
            btnUlkeEkle.TabIndex = 2;
            btnUlkeEkle.Text = "+";
            btnUlkeEkle.UseVisualStyleBackColor = true;
            btnUlkeEkle.Click += btnUlkeEkle_Click;
            // 
            // cmbBxIlceAdlari
            // 
            cmbBxIlceAdlari.FormattingEnabled = true;
            cmbBxIlceAdlari.Location = new Point(113, 270);
            cmbBxIlceAdlari.Margin = new Padding(6);
            cmbBxIlceAdlari.Name = "cmbBxIlceAdlari";
            cmbBxIlceAdlari.Size = new Size(388, 40);
            cmbBxIlceAdlari.TabIndex = 5;
            // 
            // cmbBxSehirAdlari
            // 
            cmbBxSehirAdlari.FormattingEnabled = true;
            cmbBxSehirAdlari.Location = new Point(113, 186);
            cmbBxSehirAdlari.Margin = new Padding(6);
            cmbBxSehirAdlari.Name = "cmbBxSehirAdlari";
            cmbBxSehirAdlari.Size = new Size(388, 40);
            cmbBxSehirAdlari.TabIndex = 3;
            // 
            // lblAcikAdres
            // 
            lblAcikAdres.AutoSize = true;
            lblAcikAdres.Location = new Point(4, 345);
            lblAcikAdres.Margin = new Padding(6, 0, 6, 0);
            lblAcikAdres.Name = "lblAcikAdres";
            lblAcikAdres.Size = new Size(125, 32);
            lblAcikAdres.TabIndex = 0;
            lblAcikAdres.Text = "Açık Adres";
            // 
            // lblIlceAdi
            // 
            lblIlceAdi.AutoSize = true;
            lblIlceAdi.Location = new Point(4, 277);
            lblIlceAdi.Margin = new Padding(6, 0, 6, 0);
            lblIlceAdi.Name = "lblIlceAdi";
            lblIlceAdi.Size = new Size(92, 32);
            lblIlceAdi.TabIndex = 0;
            lblIlceAdi.Text = "İlçe Adı";
            // 
            // lblSehirAdi
            // 
            lblSehirAdi.AutoSize = true;
            lblSehirAdi.Location = new Point(4, 194);
            lblSehirAdi.Margin = new Padding(6, 0, 6, 0);
            lblSehirAdi.Name = "lblSehirAdi";
            lblSehirAdi.Size = new Size(110, 32);
            lblSehirAdi.TabIndex = 0;
            lblSehirAdi.Text = "Şehir Adı";
            // 
            // cmbBxUlkeAdlari
            // 
            cmbBxUlkeAdlari.FormattingEnabled = true;
            cmbBxUlkeAdlari.Location = new Point(113, 100);
            cmbBxUlkeAdlari.Margin = new Padding(6);
            cmbBxUlkeAdlari.Name = "cmbBxUlkeAdlari";
            cmbBxUlkeAdlari.Size = new Size(388, 40);
            cmbBxUlkeAdlari.TabIndex = 1;
            cmbBxUlkeAdlari.SelectedIndexChanged += cmbBxUlkeAdlari_SelectedIndexChanged;
            // 
            // lblAdresAdi
            // 
            lblAdresAdi.AutoSize = true;
            lblAdresAdi.Location = new Point(0, 44);
            lblAdresAdi.Margin = new Padding(6, 0, 6, 0);
            lblAdresAdi.Name = "lblAdresAdi";
            lblAdresAdi.Size = new Size(116, 32);
            lblAdresAdi.TabIndex = 0;
            lblAdresAdi.Text = "Adres Adı";
            // 
            // lblUlkeAdi
            // 
            lblUlkeAdi.AutoSize = true;
            lblUlkeAdi.Location = new Point(4, 106);
            lblUlkeAdi.Margin = new Padding(6, 0, 6, 0);
            lblUlkeAdi.Name = "lblUlkeAdi";
            lblUlkeAdi.Size = new Size(103, 32);
            lblUlkeAdi.TabIndex = 0;
            lblUlkeAdi.Text = "Ülke Adı";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(1032, 99);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ülke Açıklama";
            textBox1.Size = new Size(564, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(1032, 186);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Şehir Açıklama";
            textBox2.Size = new Size(564, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(1032, 270);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "İlçe Açıklama";
            textBox3.Size = new Size(564, 39);
            textBox3.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(948, 390);
            btnGuncelle.Margin = new Padding(6);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(354, 126);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnEkle_Click;
            // 
            // AdresKayitFrm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1758, 1174);
            Controls.Add(grpBxYeniAdresEkle);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AdresKayitFrm";
            Text = "Adres Kayıt Formu";
            FormClosed += AdresKayitFrm_FormClosed;
            Load += AdresKayitFrm_Load;
            grpBxYeniAdresEkle.ResumeLayout(false);
            grpBxYeniAdresEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBxYeniAdresEkle;
        private TextBox txtYeniUlkeKodu;
        private Button btnUlkeKayitBitir;
        private Button btnUlkeEkle;
        private ComboBox cmbBxUlkeAdlari;
        private Label lblUlkeAdi;
        private TextBox txtYeniUlkeEkle;
        private TextBox txtBxYeniSehirKodu;
        private TextBox txtYeniSehirEkle;
        private Button btnSehirKayitBitir;
        private Button btnSehirEkle;
        private ComboBox cmbBxSehirAdlari;
        private Label lblSehirAdi;
        private TextBox txtYeniılceZipKodu;
        private TextBox txtYeniIlceEkle;
        private Button btnIlceKayitBitir;
        private Button btnIptal;
        private ComboBox cmbBxIlceAdlari;
        private Label lblIlceAdi;
        private TextBox txtAcikAdresEKle;
        private Label lblAcikAdres;
        private Button btnEkle;
        private Button btnYeniIlceEkle;
        private TextBox txtAdresAdi;
        private Label lblAdresAdi;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnGuncelle;
    }
}