namespace WindowsFormsApplication20
{
    partial class Form1
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
            this.XmlDokumanOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MusteriBilgileriniGetir = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.DovizKurlariniGetir = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelDosyasiOlustur
            // 
            this.ExcelDosyasiOlustur.Location = new System.Drawing.Point(903, 29);
            this.ExcelDosyasiOlustur.Name = "ExcelDosyasiOlustur";
            this.ExcelDosyasiOlustur.Size = new System.Drawing.Size(75, 23);
            this.ExcelDosyasiOlustur.TabIndex = 0;
            this.ExcelDosyasiOlustur.Text = "load";
            this.ExcelDosyasiOlustur.UseVisualStyleBackColor = true;
            this.ExcelDosyasiOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(674, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // XmlDokumanOlustur
            // 
            this.XmlDokumanOlustur.Location = new System.Drawing.Point(798, 29);
            this.XmlDokumanOlustur.Name = "XmlDokumanOlustur";
            this.XmlDokumanOlustur.Size = new System.Drawing.Size(75, 23);
            this.XmlDokumanOlustur.TabIndex = 0;
            this.XmlDokumanOlustur.Text = "create";
            this.XmlDokumanOlustur.UseVisualStyleBackColor = true;
            this.XmlDokumanOlustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "otomatikmen bin Klasörü içinde Contacts.xml oluştursun ve oluşturulan veriyi data" +
    "ğride çeksin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(671, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "c#",
            "Database",
            "java"});
            this.listBox1.Location = new System.Drawing.Point(12, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 147);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "oluştur ve kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Otomatikmen savefile.xml oluştur ve verileri hem xml hemde savefile.xml\'e kaydet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "proğramlama diilini ğiriniz";
            // 
            // MusteriBilgileriniGetir
            // 
            this.MusteriBilgileriniGetir.Location = new System.Drawing.Point(143, 114);
            this.MusteriBilgileriniGetir.Name = "MusteriBilgileriniGetir";
            this.MusteriBilgileriniGetir.Size = new System.Drawing.Size(75, 23);
            this.MusteriBilgileriniGetir.TabIndex = 11;
            this.MusteriBilgileriniGetir.Text = "Kaydet??";
            this.MusteriBilgileriniGetir.UseVisualStyleBackColor = true;
            this.MusteriBilgileriniGetir.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(771, 294);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(102, 173);
            this.listBox2.TabIndex = 12;
            // 
            // DovizKurlariniGetir
            // 
            this.DovizKurlariniGetir.Location = new System.Drawing.Point(798, 265);
            this.DovizKurlariniGetir.Name = "DovizKurlariniGetir";
            this.DovizKurlariniGetir.Size = new System.Drawing.Size(75, 23);
            this.DovizKurlariniGetir.TabIndex = 13;
            this.DovizKurlariniGetir.Text = "Paradövizlerini ğetir";
            this.DovizKurlariniGetir.UseVisualStyleBackColor = true;
            this.DovizKurlariniGetir.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(667, 294);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(98, 173);
            this.listBox5.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(667, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "TEST.XML OLUŞTUR VE YAZDIR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 508);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.DovizKurlariniGetir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.MusteriBilgileriniGetir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.XmlDokumanOlustur);
            this.Controls.Add(this.ExcelDosyasiOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelDosyasiOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button XmlDokumanOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MusteriBilgileriniGetir;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button DovizKurlariniGetir;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button button6;
    }
}

