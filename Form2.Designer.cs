namespace WindowsFormsApplication20
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
            this.ExcelDosyasiOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.XmlDokumanOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MusteriBilgileriniGetir = new System.Windows.Forms.Button();
            this.DovizKurlariniGetir = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.DovizKuruGetir = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelDosyasiOlustur
            // 
            this.ExcelDosyasiOlustur.Location = new System.Drawing.Point(706, 33);
            this.ExcelDosyasiOlustur.Name = "ExcelDosyasiOlustur";
            this.ExcelDosyasiOlustur.Size = new System.Drawing.Size(253, 31);
            this.ExcelDosyasiOlustur.TabIndex = 0;
            this.ExcelDosyasiOlustur.Text = "Datağrideyükle";
            this.ExcelDosyasiOlustur.UseVisualStyleBackColor = true;
            this.ExcelDosyasiOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(688, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // XmlDokumanOlustur
            // 
            this.XmlDokumanOlustur.Location = new System.Drawing.Point(207, 450);
            this.XmlDokumanOlustur.Name = "XmlDokumanOlustur";
            this.XmlDokumanOlustur.Size = new System.Drawing.Size(111, 66);
            this.XmlDokumanOlustur.TabIndex = 6;
            this.XmlDokumanOlustur.Text = "XMLDOSYASINA EKLEME HATASI ";
            this.XmlDokumanOlustur.UseVisualStyleBackColor = true;
            this.XmlDokumanOlustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bin klasörü içinde oluturduğumuz XML verilerini datağride ğetir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MusteriBilgileriniGetir
            // 
            this.MusteriBilgileriniGetir.Location = new System.Drawing.Point(1058, 302);
            this.MusteriBilgileriniGetir.Name = "MusteriBilgileriniGetir";
            this.MusteriBilgileriniGetir.Size = new System.Drawing.Size(75, 23);
            this.MusteriBilgileriniGetir.TabIndex = 11;
            this.MusteriBilgileriniGetir.Text = "load";
            this.MusteriBilgileriniGetir.UseVisualStyleBackColor = true;
            this.MusteriBilgileriniGetir.Click += new System.EventHandler(this.button4_Click);
            // 
            // DovizKurlariniGetir
            // 
            this.DovizKurlariniGetir.Location = new System.Drawing.Point(674, 302);
            this.DovizKurlariniGetir.Name = "DovizKurlariniGetir";
            this.DovizKurlariniGetir.Size = new System.Drawing.Size(75, 23);
            this.DovizKurlariniGetir.TabIndex = 10;
            this.DovizKurlariniGetir.Text = "create,";
            this.DovizKurlariniGetir.UseVisualStyleBackColor = true;
            this.DovizKurlariniGetir.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(642, 331);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(679, 271);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "otomatikmen bin Klasörü içinde Contact44.xml oluştursun ve oluşturulan veriyi dat" +
    "ağride çeksin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "KAYDET";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(212, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(326, 339);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // DovizKuruGetir
            // 
            this.DovizKuruGetir.Location = new System.Drawing.Point(43, 234);
            this.DovizKuruGetir.Name = "DovizKuruGetir";
            this.DovizKuruGetir.Size = new System.Drawing.Size(158, 32);
            this.DovizKuruGetir.TabIndex = 16;
            this.DovizKuruGetir.Text = "TEXTBOX1DEN İD AL SİL";
            this.DovizKuruGetir.UseVisualStyleBackColor = true;
            this.DovizKuruGetir.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(126, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "SİL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(126, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "ĞÜNCELLE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 390);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 418);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(101, 444);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(101, 470);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "BİN KLASÖRÜ İÇİNDE OLUŞTURDUĞUMUZ VERİLERİ veri.xml\'e KAYDET EKLE SİL ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "PRİCE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "DESCRİPTİON";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "CALORİES";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 598);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.DovizKuruGetir);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MusteriBilgileriniGetir);
            this.Controls.Add(this.DovizKurlariniGetir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XmlDokumanOlustur);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExcelDosyasiOlustur);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelDosyasiOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button XmlDokumanOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MusteriBilgileriniGetir;
        private System.Windows.Forms.Button DovizKurlariniGetir;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button DovizKuruGetir;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}