namespace _03_UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtKadin = new System.Windows.Forms.RadioButton();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtErkek = new System.Windows.Forms.RadioButton();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIletisimBilgileriniGor = new System.Windows.Forms.Button();
            this.btnTemiz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtKadin);
            this.groupBox1.Controls.Add(this.txtTCKimlik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBirim);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.rbtErkek);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt Ekranı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birimi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cinsiyet :";
            // 
            // rbtKadin
            // 
            this.rbtKadin.AutoSize = true;
            this.rbtKadin.Location = new System.Drawing.Point(452, 276);
            this.rbtKadin.Name = "rbtKadin";
            this.rbtKadin.Size = new System.Drawing.Size(90, 34);
            this.rbtKadin.TabIndex = 5;
            this.rbtKadin.TabStop = true;
            this.rbtKadin.Text = "Kadın";
            this.rbtKadin.UseVisualStyleBackColor = true;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(248, 191);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(362, 35);
            this.txtTCKimlik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "T.C Kimlik No:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(248, 127);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(362, 35);
            this.txtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyadı :";
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(248, 399);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(362, 38);
            this.cmbBirim.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 35);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // rbtErkek
            // 
            this.rbtErkek.AutoSize = true;
            this.rbtErkek.Location = new System.Drawing.Point(328, 276);
            this.rbtErkek.Name = "rbtErkek";
            this.rbtErkek.Size = new System.Drawing.Size(87, 34);
            this.rbtErkek.TabIndex = 4;
            this.rbtErkek.TabStop = true;
            this.rbtErkek.Text = "Erkek";
            this.rbtErkek.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(248, 64);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(362, 35);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(382, 592);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(271, 62);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIletisimBilgileriniGor
            // 
            this.btnIletisimBilgileriniGor.Location = new System.Drawing.Point(12, 689);
            this.btnIletisimBilgileriniGor.Name = "btnIletisimBilgileriniGor";
            this.btnIletisimBilgileriniGor.Size = new System.Drawing.Size(641, 65);
            this.btnIletisimBilgileriniGor.TabIndex = 3;
            this.btnIletisimBilgileriniGor.Text = "İLETİŞİM BİLGİLERİNİ GÖR";
            this.btnIletisimBilgileriniGor.UseVisualStyleBackColor = true;
            this.btnIletisimBilgileriniGor.Click += new System.EventHandler(this.btnIletisimBilgileriniGor_Click);
            // 
            // btnTemiz
            // 
            this.btnTemiz.Location = new System.Drawing.Point(12, 592);
            this.btnTemiz.Name = "btnTemiz";
            this.btnTemiz.Size = new System.Drawing.Size(271, 62);
            this.btnTemiz.TabIndex = 4;
            this.btnTemiz.Text = "TEMİZLE";
            this.btnTemiz.UseVisualStyleBackColor = true;
            this.btnTemiz.Click += new System.EventHandler(this.btnTemiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 793);
            this.Controls.Add(this.btnTemiz);
            this.Controls.Add(this.btnIletisimBilgileriniGor);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton rbtKadin;
        private TextBox txtTCKimlik;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbtErkek;
        private TextBox txtAd;
        private Label label1;

        private Button btnKaydet;
        private Button btnIletisimBilgileriniGor;
        private Button btnTemiz;
        private ComboBox cmbBirim;
    }
}