namespace KatmanliMimari_PersonelEkleme2_WinUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPersonelKayit = new GroupBox();
            cmbBirimler = new ComboBox();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            dtpDogumTarihi = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtTcKimlikNo = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            label1 = new Label();
            txtAd = new TextBox();
            btnTemizle = new Button();
            btnKaydet = new Button();
            btnIletisimBilgiGor = new Button();
            grpPersonelKayit.SuspendLayout();
            SuspendLayout();
            // 
            // grpPersonelKayit
            // 
            grpPersonelKayit.Controls.Add(cmbBirimler);
            grpPersonelKayit.Controls.Add(rbKadin);
            grpPersonelKayit.Controls.Add(rbErkek);
            grpPersonelKayit.Controls.Add(dtpDogumTarihi);
            grpPersonelKayit.Controls.Add(label6);
            grpPersonelKayit.Controls.Add(label5);
            grpPersonelKayit.Controls.Add(label4);
            grpPersonelKayit.Controls.Add(label3);
            grpPersonelKayit.Controls.Add(txtTcKimlikNo);
            grpPersonelKayit.Controls.Add(label2);
            grpPersonelKayit.Controls.Add(txtSoyad);
            grpPersonelKayit.Controls.Add(label1);
            grpPersonelKayit.Controls.Add(txtAd);
            grpPersonelKayit.Location = new Point(24, 24);
            grpPersonelKayit.Name = "grpPersonelKayit";
            grpPersonelKayit.Size = new Size(313, 325);
            grpPersonelKayit.TabIndex = 0;
            grpPersonelKayit.TabStop = false;
            grpPersonelKayit.Text = "Personel Kayıt Ekranı";
            // 
            // cmbBirimler
            // 
            cmbBirimler.FormattingEnabled = true;
            cmbBirimler.Items.AddRange(new object[] { "Yazılım", "Muhasebe", "ERP", "Yönetim", "İnsan Kaynakları", "IT", "Pazarlama", "Satış" });
            cmbBirimler.Location = new Point(124, 249);
            cmbBirimler.Name = "cmbBirimler";
            cmbBirimler.Size = new Size(183, 23);
            cmbBirimler.TabIndex = 14;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(213, 212);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(55, 19);
            rbKadin.TabIndex = 13;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(124, 212);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(53, 19);
            rbErkek.TabIndex = 12;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(124, 172);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(183, 23);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 257);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 10;
            label6.Text = "Birimler:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 214);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 178);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 7;
            label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 139);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "TC Kimlik No:";
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Location = new Point(124, 131);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(183, 23);
            txtTcKimlikNo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 96);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyadı:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(124, 88);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(183, 23);
            txtSoyad.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 52);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(124, 44);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(183, 23);
            txtAd.TabIndex = 2;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(148, 355);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(262, 355);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIletisimBilgiGor
            // 
            btnIletisimBilgiGor.Enabled = false;
            btnIletisimBilgiGor.Location = new Point(148, 384);
            btnIletisimBilgiGor.Name = "btnIletisimBilgiGor";
            btnIletisimBilgiGor.Size = new Size(189, 23);
            btnIletisimBilgiGor.TabIndex = 17;
            btnIletisimBilgiGor.Text = "İletişim Bilgilerini Gör";
            btnIletisimBilgiGor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(btnIletisimBilgiGor);
            Controls.Add(btnTemizle);
            Controls.Add(btnKaydet);
            Controls.Add(grpPersonelKayit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpPersonelKayit.ResumeLayout(false);
            grpPersonelKayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonelKayit;
        private Label label1;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtTcKimlikNo;
        private Label label2;
        private TextBox txtSoyad;
        private ComboBox cmbBirimler;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private DateTimePicker dtpDogumTarihi;
        private Button btnTemizle;
        private Button btnKaydet;
        private Button btnIletisimBilgiGor;
    }
}