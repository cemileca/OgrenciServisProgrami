namespace OgrenciServis.WinForm.Forms
{
    partial class AnaSayfaFrm
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblKodu = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            lblAktif = new Label();
            tabPage1 = new TabPage();
            tbCrlOgrenciKayit = new TabControl();
            tabPage2 = new TabPage();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tbCrlOgrenciKayit.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbCrlOgrenciKayit);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 597);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblAktif);
            panel2.Controls.Add(lblKodu);
            panel2.Location = new Point(3, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 41);
            panel2.TabIndex = 0;
            // 
            // lblKodu
            // 
            lblKodu.AutoSize = true;
            lblKodu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKodu.Location = new Point(9, 14);
            lblKodu.Name = "lblKodu";
            lblKodu.Size = new Size(36, 15);
            lblKodu.TabIndex = 0;
            lblKodu.Text = "Kodu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightSalmon;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(102, 23);
            comboBox1.TabIndex = 2;
            // 
            // lblAktif
            // 
            lblAktif.AutoSize = true;
            lblAktif.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAktif.Location = new Point(349, 14);
            lblAktif.Name = "lblAktif";
            lblAktif.Size = new Size(35, 15);
            lblAktif.TabIndex = 0;
            lblAktif.Text = "Aktif";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightCyan;
            tabPage1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(943, 507);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kişisel Bilgiler";
            // 
            // tbCrlOgrenciKayit
            // 
            tbCrlOgrenciKayit.Controls.Add(tabPage1);
            tbCrlOgrenciKayit.Controls.Add(tabPage2);
            tbCrlOgrenciKayit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbCrlOgrenciKayit.Location = new Point(3, 59);
            tbCrlOgrenciKayit.Name = "tbCrlOgrenciKayit";
            tbCrlOgrenciKayit.SelectedIndex = 0;
            tbCrlOgrenciKayit.Size = new Size(951, 535);
            tbCrlOgrenciKayit.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightCyan;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(943, 507);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detay Bilgiler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Kimlik No";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(261, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AnaSayfaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 596);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AnaSayfaFrm";
            Text = "Öğrenci Kayıt Formu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbCrlOgrenciKayit.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblKodu;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label lblAktif;
        private TabControl tbCrlOgrenciKayit;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
    }
}