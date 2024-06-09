namespace Ogrenci_Kart
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNo = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxProgram = new System.Windows.Forms.TextBox();
            this.tbxDurum = new System.Windows.Forms.TextBox();
            this.tbxKayıt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.btnformac = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxıd = new System.Windows.Forms.TextBox();
            this.btnınsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNo
            // 
            this.tbxNo.Location = new System.Drawing.Point(117, 58);
            this.tbxNo.Name = "tbxNo";
            this.tbxNo.Size = new System.Drawing.Size(100, 20);
            this.tbxNo.TabIndex = 0;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(117, 91);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(100, 20);
            this.tbxAd.TabIndex = 1;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(117, 133);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyad.TabIndex = 1;
            // 
            // tbxProgram
            // 
            this.tbxProgram.Location = new System.Drawing.Point(117, 178);
            this.tbxProgram.Name = "tbxProgram";
            this.tbxProgram.Size = new System.Drawing.Size(100, 20);
            this.tbxProgram.TabIndex = 2;
            // 
            // tbxDurum
            // 
            this.tbxDurum.Location = new System.Drawing.Point(117, 216);
            this.tbxDurum.Name = "tbxDurum";
            this.tbxDurum.Size = new System.Drawing.Size(100, 20);
            this.tbxDurum.TabIndex = 2;
            // 
            // tbxKayıt
            // 
            this.tbxKayıt.Location = new System.Drawing.Point(117, 260);
            this.tbxKayıt.Name = "tbxKayıt";
            this.tbxKayıt.Size = new System.Drawing.Size(100, 20);
            this.tbxKayıt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Program";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(30, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kayıt Yılı";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(236, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 264);
            this.listBox1.TabIndex = 10;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(236, 297);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(155, 23);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(33, 332);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(184, 40);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(30, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tc Kimlik no";
            // 
            // tbxTc
            // 
            this.tbxTc.Location = new System.Drawing.Point(117, 297);
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(100, 20);
            this.tbxTc.TabIndex = 14;
            // 
            // btnformac
            // 
            this.btnformac.BackColor = System.Drawing.SystemColors.Info;
            this.btnformac.Location = new System.Drawing.Point(685, 377);
            this.btnformac.Name = "btnformac";
            this.btnformac.Size = new System.Drawing.Size(198, 65);
            this.btnformac.TabIndex = 15;
            this.btnformac.Text = "YÖNLENDİR";
            this.btnformac.UseVisualStyleBackColor = false;
            this.btnformac.Click += new System.EventHandler(this.btnformac_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(571, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "@Sedat Kuba Tüm Hakları Saklıdır";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(515, 292);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(540, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mevcut Tablo Durumu Ve Listeleme";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(706, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Form 2 Yönlendirme Butonu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(30, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID ";
            // 
            // tbxıd
            // 
            this.tbxıd.Enabled = false;
            this.tbxıd.Location = new System.Drawing.Point(117, 26);
            this.tbxıd.Name = "tbxıd";
            this.tbxıd.Size = new System.Drawing.Size(100, 20);
            this.tbxıd.TabIndex = 21;
            // 
            // btnınsert
            // 
            this.btnınsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnınsert.Location = new System.Drawing.Point(33, 388);
            this.btnınsert.Name = "btnınsert";
            this.btnınsert.Size = new System.Drawing.Size(184, 40);
            this.btnınsert.TabIndex = 22;
            this.btnınsert.Text = "Güncelle";
            this.btnınsert.UseVisualStyleBackColor = true;
            this.btnınsert.Click += new System.EventHandler(this.btnınsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(33, 443);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(184, 40);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(264, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(301, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Bu Form \"SEDAT KUBA \" Tarafından Tasarlanıp Kodlanmıştır. \r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(394, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(449, 15);
            this.label12.TabIndex = 46;
            this.label12.Text = "(Not: Klasörde Bulunan dbOkul.bat  Uzantılı Sql dosasını Kulanmayı Unutmayınız)";
            this.label12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(924, 522);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnınsert);
            this.Controls.Add(this.tbxıd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnformac);
            this.Controls.Add(this.tbxTc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKayıt);
            this.Controls.Add(this.tbxDurum);
            this.Controls.Add(this.tbxProgram);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.tbxNo);
            this.Name = "Form1";
            this.Text = "Sedat Kuban\'ın  Öğrenci  Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNo;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxProgram;
        private System.Windows.Forms.TextBox tbxDurum;
        private System.Windows.Forms.TextBox tbxKayıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTc;
        private System.Windows.Forms.Button btnformac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxıd;
        private System.Windows.Forms.Button btnınsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}

