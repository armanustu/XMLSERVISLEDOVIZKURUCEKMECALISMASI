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

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
            ds.WriteXml("Contacts.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsload = new DataSet();
            dsload.ReadXml("Contacts.xml");
            dataGridView1.DataSource = dsload.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ////XML READER İLE OKUMA
            //try
            //{

                XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                    {
                        if (xmlReader.HasAttributes)
                            listBox5.Items.Add(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
                    }
                }

                //XMLDOC OKUMA İŞLEMİYLE SAYFA BAŞLIĞINI ÇEKME
                //XmlDocument xmlDoc = new XmlDocument();
                //xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
                //XmlNode titleNode1 = xmlDoc.SelectSingleNode("//rss/channel/title");
                //if (titleNode1 != null)
                //    listBox5.Items.Add("titleNode.InnerText");


                //XmlDocument xmlDoc1 = new XmlDocument();
                //xmlDoc1.Load("http://rss.cnn.com/rss/edition_world.rss");
                //XmlNodeList itemNodes = xmlDoc1.SelectNodes("//rss/channel/item");
                //foreach (XmlNode itemNode in itemNodes)
                //{
                //    XmlNode titleNode = itemNode.SelectSingleNode("title");
                //    XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                //    if ((titleNode != null) && (dateNode != null))
                //        listBox4.Items.Add(dateNode.InnerText + ": " + titleNode.InnerText);
                //}


            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("sonuçları ğörmek için internete bağlanmayı deneyiniz yada kodları buton içine yazınız");
            //}
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt8 = new DataTable();
            dt8.TableName = "Contact4";
            DataColumn dt4= new DataColumn("Name");
            DataColumn dt5 = new DataColumn("Ağe");
            DataColumn dt6 = new DataColumn("ğender");
            dt8.Columns.Add(dt4);
            dt8.Columns.Add(dt5);
            dt8.Columns.Add(dt6);
            dt8.Rows.Add("arman", "24", "erkek");
            dt8.Rows.Add("alper", "23", "erkek");
            dt8.Rows.Add("arda", "24", "erkek");
            DataSet ds = new DataSet();
            ds.DataSetName = "Adressbook";
            ds.Tables.Add(dt8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet dsload = new DataSet();
            dsload.ReadXml("Contact2.xml");
            dataGridView1.DataSource = dsload.Tables[0];

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //XML DOSYASI OLUŞTURMA
            XmlTextWriter xwrite = new XmlTextWriter("savefile.xml",Encoding.Unicode);
            xwrite.WriteStartDocument();
            xwrite.WriteStartElement("xmlfile");
            xwrite.WriteStartElement("title");
            xwrite.WriteStartElement("title1");
            xwrite.WriteString(textBox1.Text);
            listBox1.Items.Add(""+textBox1.Text);
            xwrite.WriteEndElement();
            foreach (String item in listBox1.Items)
            {

                xwrite.WriteStartElement("item");
                xwrite.WriteString(item);
                xwrite.WriteEndElement();

                
            }
            xwrite.WriteEndElement();
            xwrite.WriteEndDocument();
            xwrite.Close();
        
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            XmlTextWriter xwrite = new XmlTextWriter("savefile223.xml", Encoding.Unicode);
            xwrite.WriteStartDocument();
            xwrite.WriteStartElement("xmlfile");
            xwrite.WriteStartElement("title");
            xwrite.WriteString(textBox1.Text);
            listBox1.Items.Add("" + textBox1.Text);
            xwrite.WriteEndElement();
            foreach (String item in listBox1.Items)
            {

                xwrite.WriteStartElement("item");
                xwrite.WriteString(item);
                xwrite.WriteEndElement();


            }
            xwrite.WriteEndElement();
            xwrite.WriteEndDocument();
            xwrite.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
               listBox2.Items.Add(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);
        }

    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                XmlWriter xmlWriter = XmlWriter.Create("test.xml");

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("users");

                xmlWriter.WriteStartElement("user");
                xmlWriter.WriteAttributeString("age", "42");
                xmlWriter.WriteString("John Doe");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("user");
                xmlWriter.WriteAttributeString("age", "39");
                xmlWriter.WriteString("Jane Doe");

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

            //XML DOC İLE XML OLUŞTURMA YAZIM ŞEKLİ
            //XmlDocument xmlDoc = new XmlDocument();
            //XmlNode rootNode = xmlDoc.CreateElement("users");
            //xmlDoc.AppendChild(rootNode);

            //XmlNode userNode = xmlDoc.CreateElement("user");
            //XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "42";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "John Doe";
            //rootNode.AppendChild(userNode);

            //userNode = xmlDoc.CreateElement("user");
            //attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "39";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "Jane Doe";
            //rootNode.AppendChild(userNode);

            //xmlDoc.Save("test-doc.xml");


            //XML DOC İLE YAŞ DEĞERİNİ BİR ARTIR
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("test-doc.xml");
            //XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            //foreach (XmlNode userNode in userNodes)
            //{
            //    int age = int.Parse(userNode.Attributes["age"].Value);
            //    userNode.Attributes["age"].Value = (age + 1).ToString();
            //}
            //xmlDoc.Save("test-doc.xml");  

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
