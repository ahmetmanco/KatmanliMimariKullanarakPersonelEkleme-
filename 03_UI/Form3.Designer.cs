namespace _03_UI
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonelBilgileriTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxPersoneller = new System.Windows.Forms.ListBox();
            this.btnPersonelBulTemizle = new System.Windows.Forms.Button();
            this.txtPersonelBul = new System.Windows.Forms.TextBox();
            this.cmbPersonelBul = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelBilgileriTemizle);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 627);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // btnPersonelBilgileriTemizle
            // 
            this.btnPersonelBilgileriTemizle.Location = new System.Drawing.Point(6, 538);
            this.btnPersonelBilgileriTemizle.Name = "btnPersonelBilgileriTemizle";
            this.btnPersonelBilgileriTemizle.Size = new System.Drawing.Size(661, 83);
            this.btnPersonelBilgileriTemizle.TabIndex = 1;
            this.btnPersonelBilgileriTemizle.Text = "TEMİZLE";
            this.btnPersonelBilgileriTemizle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(661, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(12, 671);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(887, 110);
            this.btnAnaMenu.TabIndex = 1;
            this.btnAnaMenu.Text = "ANA MENU";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(974, 671);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(410, 110);
            this.btnPersonelSil.TabIndex = 2;
            this.btnPersonelSil.Text = "PERSONELİ VERİTABANINDAN SİL";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxPersoneller);
            this.groupBox2.Controls.Add(this.btnPersonelBulTemizle);
            this.groupBox2.Controls.Add(this.txtPersonelBul);
            this.groupBox2.Controls.Add(this.cmbPersonelBul);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Location = new System.Drawing.Point(711, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 627);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bul";
            // 
            // lbxPersoneller
            // 
            this.lbxPersoneller.FormattingEnabled = true;
            this.lbxPersoneller.ItemHeight = 30;
            this.lbxPersoneller.Location = new System.Drawing.Point(6, 97);
            this.lbxPersoneller.Name = "lbxPersoneller";
            this.lbxPersoneller.Size = new System.Drawing.Size(661, 394);
            this.lbxPersoneller.TabIndex = 4;
            // 
            // btnPersonelBulTemizle
            // 
            this.btnPersonelBulTemizle.Location = new System.Drawing.Point(6, 538);
            this.btnPersonelBulTemizle.Name = "btnPersonelBulTemizle";
            this.btnPersonelBulTemizle.Size = new System.Drawing.Size(661, 83);
            this.btnPersonelBulTemizle.TabIndex = 3;
            this.btnPersonelBulTemizle.Text = "TEMİZLE";
            this.btnPersonelBulTemizle.UseVisualStyleBackColor = true;
            this.btnPersonelBulTemizle.Click += new System.EventHandler(this.btnPersonelBulTemizle_Click);
            // 
            // txtPersonelBul
            // 
            this.txtPersonelBul.Location = new System.Drawing.Point(6, 39);
            this.txtPersonelBul.Name = "txtPersonelBul";
            this.txtPersonelBul.Size = new System.Drawing.Size(182, 35);
            this.txtPersonelBul.TabIndex = 2;
            // 
            // cmbPersonelBul
            // 
            this.cmbPersonelBul.FormattingEnabled = true;
            this.cmbPersonelBul.Location = new System.Drawing.Point(237, 36);
            this.cmbPersonelBul.Name = "cmbPersonelBul";
            this.cmbPersonelBul.Size = new System.Drawing.Size(273, 38);
            this.cmbPersonelBul.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(536, 34);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(131, 40);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 793);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPersonelBilgileriTemizle;
        private DataGridView dataGridView1;
        private Button btnAnaMenu;
        private Button btnPersonelSil;
        private GroupBox groupBox2;
        private ListBox lbxPersoneller;
        private Button btnPersonelBulTemizle;
        private TextBox txtPersonelBul;
        private ComboBox cmbPersonelBul;
        private Button btnAra;
    }
}