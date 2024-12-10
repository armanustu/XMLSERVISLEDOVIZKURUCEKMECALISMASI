namespace WindowsFormsApplication20
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
            this.ExcelDosyasiOlustur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.XmlDokumanOlustur = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.MusteriBilgileriniGetir = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.DovizKurlariniGetir = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.DovizKuruGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExcelDosyasiOlustur
            // 
            this.ExcelDosyasiOlustur.Location = new System.Drawing.Point(12, 12);
            this.ExcelDosyasiOlustur.Name = "ExcelDosyasiOlustur";
            this.ExcelDosyasiOlustur.Size = new System.Drawing.Size(188, 49);
            this.ExcelDosyasiOlustur.TabIndex = 0;
            this.ExcelDosyasiOlustur.Text = "Varolan product.xml dosyasını XMLDOC İLE OKU";
            this.ExcelDosyasiOlustur.UseVisualStyleBackColor = true;
            this.ExcelDosyasiOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(643, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 134);
            this.listBox1.TabIndex = 1;
            // 
            // XmlDokumanOlustur
            // 
            this.XmlDokumanOlustur.Location = new System.Drawing.Point(630, 12);
            this.XmlDokumanOlustur.Name = "XmlDokumanOlustur";
            this.XmlDokumanOlustur.Size = new System.Drawing.Size(297, 62);
            this.XmlDokumanOlustur.TabIndex = 2;
            this.XmlDokumanOlustur.Text = "XMLREADER İLE Product.xml dosyasını oku";
            this.XmlDokumanOlustur.UseVisualStyleBackColor = true;
            this.XmlDokumanOlustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "D DOSYASINDA VAROLAN Product.xml dosyasını XML DOC ile oku";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(23, 307);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(293, 186);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(666, 332);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(285, 147);
            this.listBox3.TabIndex = 5;
            // 
            // MusteriBilgileriniGetir
            // 
            this.MusteriBilgileriniGetir.Location = new System.Drawing.Point(562, 190);
            this.MusteriBilgileriniGetir.Name = "MusteriBilgileriniGetir";
            this.MusteriBilgileriniGetir.Size = new System.Drawing.Size(75, 23);
            this.MusteriBilgileriniGetir.TabIndex = 6;
            this.MusteriBilgileriniGetir.Text = "MusteriBilgileriniGetir";
            this.MusteriBilgileriniGetir.UseVisualStyleBackColor = true;
            this.MusteriBilgileriniGetir.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(13, 80);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(234, 121);
            this.listBox4.TabIndex = 7;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(353, 352);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(247, 134);
            this.listBox5.TabIndex = 8;
            // 
            // DovizKurlariniGetir
            // 
            this.DovizKurlariniGetir.Location = new System.Drawing.Point(353, 307);
            this.DovizKurlariniGetir.Name = "DovizKurlariniGetir";
            this.DovizKurlariniGetir.Size = new System.Drawing.Size(203, 39);
            this.DovizKurlariniGetir.TabIndex = 9;
            this.DovizKurlariniGetir.Text = "D Dosyasında bulunan product dosyasını XMLTEXTREADER İLE OKU";
            this.DovizKurlariniGetir.UseVisualStyleBackColor = true;
            this.DovizKurlariniGetir.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(676, 277);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 51);
            this.button6.TabIndex = 10;
            this.button6.Text = "VAR OLAN Product.xml  DOSYASINDA VAR OLAN BİR ÜRÜNÜ ARA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(827, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(302, 165);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(235, 121);
            this.listBox6.TabIndex = 12;
            // 
            // DovizKuruGetir
            // 
            this.DovizKuruGetir.Location = new System.Drawing.Point(496, 48);
            this.DovizKuruGetir.Name = "DovizKuruGetir";
            this.DovizKuruGetir.Size = new System.Drawing.Size(75, 23);
            this.DovizKuruGetir.TabIndex = 13;
            this.DovizKuruGetir.Text = "Filtrele";
            this.DovizKuruGetir.UseVisualStyleBackColor = true;
            this.DovizKuruGetir.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "3000 büyük ürünler result.xml sayfasına kaydet";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(353, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 34);
            this.button8.TabIndex = 15;
            this.button8.Text = "Test klasöründeki atribue ve değerlerini oku";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1005, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(161, 175);
            this.treeView1.TabIndex = 16;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1069, 216);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 491);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DovizKuruGetir);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DovizKurlariniGetir);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.MusteriBilgileriniGetir);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.XmlDokumanOlustur);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ExcelDosyasiOlustur);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelDosyasiOlustur;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button XmlDokumanOlustur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button MusteriBilgileriniGetir;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button DovizKurlariniGetir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Button DovizKuruGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button9;
    }
}