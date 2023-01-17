namespace _03_UI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.btnGirisVeyaGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTumKayitlar = new System.Windows.Forms.Button();
            this.btnYeniPersonel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "İletişim Bilgilerini Tamamlamak için bir Personel seçiniz";
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(35, 68);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(600, 38);
            this.cmbPersoneller.TabIndex = 1;
            this.cmbPersoneller.SelectedIndexChanged += new System.EventHandler(this.cmbPersoneller_SelectedIndexChanged);
            // 
            // btnGirisVeyaGuncelle
            // 
            this.btnGirisVeyaGuncelle.Location = new System.Drawing.Point(35, 137);
            this.btnGirisVeyaGuncelle.Name = "btnGirisVeyaGuncelle";
            this.btnGirisVeyaGuncelle.Size = new System.Drawing.Size(600, 66);
            this.btnGirisVeyaGuncelle.TabIndex = 2;
            this.btnGirisVeyaGuncelle.Text = "Giriş veya Güncelleme Yap\r\n";
            this.btnGirisVeyaGuncelle.UseVisualStyleBackColor = true;
            this.btnGirisVeyaGuncelle.Click += new System.EventHandler(this.btnGirisVeyaGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 429);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İletişim Bilgisi Giriş Ekranı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(427, 359);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 55);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(262, 202);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(306, 140);
            this.txtAdres.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ev Adresi :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(262, 129);
            this.txtTel.Name = "txtTel";
            this.txtTel.PlaceholderText = "(___)___-___";
            this.txtTel.Size = new System.Drawing.Size(306, 35);
            this.txtTel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonu :";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(262, 58);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(306, 35);
            this.txtEposta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Posta Adresi :";
            // 
            // btnTumKayitlar
            // 
            this.btnTumKayitlar.Location = new System.Drawing.Point(376, 701);
            this.btnTumKayitlar.Name = "btnTumKayitlar";
            this.btnTumKayitlar.Size = new System.Drawing.Size(259, 65);
            this.btnTumKayitlar.TabIndex = 7;
            this.btnTumKayitlar.Text = "TÜM KAYITLAR";
            this.btnTumKayitlar.UseVisualStyleBackColor = true;
            // 
            // btnYeniPersonel
            // 
            this.btnYeniPersonel.Location = new System.Drawing.Point(35, 701);
            this.btnYeniPersonel.Name = "btnYeniPersonel";
            this.btnYeniPersonel.Size = new System.Drawing.Size(259, 65);
            this.btnYeniPersonel.TabIndex = 8;
            this.btnYeniPersonel.Text = "YENİ PERSONEL";
            this.btnYeniPersonel.UseVisualStyleBackColor = true;
            this.btnYeniPersonel.Click += new System.EventHandler(this.btnYeniPersonel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 793);
            this.Controls.Add(this.btnYeniPersonel);
            this.Controls.Add(this.btnTumKayitlar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGirisVeyaGuncelle);
            this.Controls.Add(this.cmbPersoneller);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbPersoneller;
        private Button btnGirisVeyaGuncelle;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private TextBox txtAdres;
        private Label label4;
        private TextBox txtTel;
        private Label label3;
        private TextBox txtEposta;
        private Label label2;
        private Button btnTumKayitlar;
        private Button btnYeniPersonel;
    }
}