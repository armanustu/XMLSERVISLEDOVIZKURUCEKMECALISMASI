using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Xml.Linq;
using System.IO;
namespace WindowsFormsApplication20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDataDocument xmls = new XmlDataDocument();
                xmls.DataSet.ReadXml(Application.StartupPath + "\\XMLFile1.xml");
                dataGridView1.DataSource = xmls.DataSet;
                dataGridView1.DataMember = "food";
                MessageBox.Show("OK");
            }
            catch (Exception EX)
            {

                MessageBox.Show("" + EX.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
           XmlTextWriter yaz = new XmlTextWriter("XMLFİLE2.xml", System.Text.UTF8Encoding.UTF8);      
            yaz.Formatting = Formatting.Indented;
            try
            {
                //dt.TableName = "food";
                yaz.WriteStartDocument();
                yaz.WriteStartElement("breakfast_menu");
                yaz.WriteStartElement("food");
                yaz.WriteElementString("name", textBox5.Text);
                yaz.WriteElementString("price", textBox6.Text);
                yaz.WriteElementString("description", textBox7.Text);
                yaz.WriteElementString("calories", textBox8.Text);
                yaz.WriteEndElement();
                yaz.Close();
                MessageBox.Show("eklendi");
            }
            catch (Exception)
            {
                
                throw;
            }           
            MessageBox.Show("kaydedildi");
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Contact";
                DataColumn dt1 = new DataColumn("Name");
                DataColumn dt2 = new DataColumn("Ağe");
                DataColumn dt3 = new DataColumn("ğender");
                dt.Columns.Add(dt1);
                dt.Columns.Add(dt2);
                dt.Columns.Add(dt3);
                dt.Rows.Add("arman", "24", "erkek");
                dt.Rows.Add("alper", "23", "erkek");
                dt.Rows.Add("arda", "24", "erkek");
                DataSet ds = new DataSet();
                ds.DataSetName = "Adressbook";
                ds.Tables.Add(dt);
                ds.WriteXml("Contact44.xml");
                MessageBox.Show("XML OLUŞTURULDU");
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsload = new DataSet();
                dsload.ReadXml("Contact44.xml");
                dataGridView2.DataSource = dsload.Tables[0];
                MessageBox.Show("XML VERİLERİ YÜKLENDİ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }

        }
        void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader xmlFile;
            //readerin içine pathini verdiğimiz dosyayı dolduruyoruz.burada önemli olan bir nokta var.ya path imizin başına @ yazacağız ya da çift  kullanacağız.
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            //içeriği Dataset e aktarıyoruz.
            ds.ReadXml(xmlFile);
            //gridviewin kaynağı olarak dataseti gösteriyoruz.
            dataGridView3.DataSource = ds.Tables[0];
            xmlFile.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            yukle();          

        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument x = XDocument.Load(@"veri.xml");
                x.Element("Ogrenciler").Add(
                new XElement("ogrenci",
                new XElement("id", textBox1.Text),
                new XElement("adi", textBox2.Text),
                new XElement("soyadi", textBox3.Text),
                new XElement("telefonu", textBox4.Text)
                ));

                x.Save(@"veri.xml");
                yukle();
                MessageBox.Show("XML VERİLERİ veri.xml DOSYASINA VE DATAĞRİDE EKLENDİ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }
        
        }
        private void button7_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");

            //ürün id= textbox'a girilen numaralı öğrenciyi sil
            x.Root.Elements().Where(a => a.Element("id").Value == textBox1.Text).Remove();
            x.Save(@"veri.xml");
            yukle();
          
        }
        private void button8_Click(object sender, EventArgs e)
        {

           
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("Ogrenciler").Elements("ogrenci").FirstOrDefault(a => a.Element("id").Value.Trim() == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("adi", textBox2.Text);
                node.SetElementValue("soyadi", textBox3.Text);
                node.SetElementValue("telefonu", textBox4.Text);
                x.Save(@"veri.xml");
                yukle();
            }

           

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                 textBox1.Text = dataGridView3.Rows[e.RowIndex].Cells["adi"].Value.ToString();
                 textBox2.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                 textBox3.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
                 textBox4.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}