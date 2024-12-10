namespace WindowsFormsApplication20
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.MusteriBilgileriniGetir = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelDosyasiOlustur
            // 
            this.ExcelDosyasiOlustur.Location = new System.Drawing.Point(12, 12);
            this.ExcelDosyasiOlustur.Name = "ExcelDosyasiOlustur";
            this.ExcelDosyasiOlustur.Size = new System.Drawing.Size(77, 35);
            this.ExcelDosyasiOlustur.TabIndex = 0;
            this.ExcelDosyasiOlustur.Text = "ExcelDosyasiOlustur";
            this.ExcelDosyasiOlustur.UseVisualStyleBackColor = true;
            this.ExcelDosyasiOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 186);
            this.listBox1.TabIndex = 1;
            // 
            // XmlDokumanOlustur
            // 
            this.XmlDokumanOlustur.Location = new System.Drawing.Point(473, 23);
            this.XmlDokumanOlustur.Name = "XmlDokumanOlustur";
            this.XmlDokumanOlustur.Size = new System.Drawing.Size(101, 58);
            this.XmlDokumanOlustur.TabIndex = 2;
            this.XmlDokumanOlustur.Text = "SQLDEN VERİLERİ ĞETİR";
            this.XmlDokumanOlustur.UseVisualStyleBackColor = true;
            this.XmlDokumanOlustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(594, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 245);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "EXPORT EXCEL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MusteriBilgileriniGetir
            // 
            this.MusteriBilgileriniGetir.Location = new System.Drawing.Point(155, 228);
            this.MusteriBilgileriniGetir.Name = "MusteriBilgileriniGetir";
            this.MusteriBilgileriniGetir.Size = new System.Drawing.Size(102, 38);
            this.MusteriBilgileriniGetir.TabIndex = 5;
            this.MusteriBilgileriniGetir.Text = "NODELARI GETİR";
            this.MusteriBilgileriniGetir.UseVisualStyleBackColor = true;
            this.MusteriBilgileriniGetir.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 272);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(202, 186);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select XML Node By Name ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.MusteriBilgileriniGetir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.XmlDokumanOlustur);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ExcelDosyasiOlustur);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelDosyasiOlustur;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button XmlDokumanOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button MusteriBilgileriniGetir;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
    }
}