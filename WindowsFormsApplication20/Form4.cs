﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using System.Net;
using Excel = Microsoft.Office.Interop.Excel; 


namespace WindowsFormsApplication20
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            DataSet ds = new DataSet();
            XmlReader xmlFile;
            int i = 0;
            int j = 0;
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                }
            }

            xlWorkBook.SaveAs("D:\\XMLEXCEL3.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlApp);
            releaseObject(xlWorkBook);
            releaseObject(xlWorkSheet);

            MessageBox.Show("Done .. ");
            
       }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection ;
            SqlDataAdapter adapter ;
            DataSet ds = new DataSet();
            string sql = null;

            connetionString = "Data Source=DESKTOP-E247TKB\\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=SSPI";
            connection = new SqlConnection(connetionString);
            sql = "select * from Products";
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(ds);
                connection.Close();
                ds.WriteXml("Product.xml");
                MessageBox.Show("VERİ TABANINDAN PRODUCT XML DOSYASINA ĞETİRİLDİ");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.ToString());

            }
        }
        XmlDocument doc;     
        XmlNode breakfast_menu1;
        private void Form4_Load(object sender, EventArgs e)
        {
            // https://www.youtube.com/watch?v=TSWoJY0FqjU 
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
         Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[2, 1] = "1";
            xlWorkSheet.Cells[2, 2] = "One";
            xlWorkSheet.Cells[3, 1] = "2";
            xlWorkSheet.Cells[3, 2] = "Two";
            xlWorkBook.SaveAs("D:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Excel DOSYASI OLUŞTURULDU UZANTISI D:\\csharp-Excel.xls");
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDataDocument xmls = new XmlDataDocument();
                xmls.DataSet.ReadXml(Application.StartupPath + "\\xmlresult5.xml");
                dataGridView1.DataSource = xmls.DataSet;
                dataGridView1.DataMember = "MÜSTERİLER";
                MessageBox.Show("VERİTABANINDAN ALDIĞINIZ XML VERİLERİ ĞETİRİLDİ");
            }
            catch (Exception EX)
            {

                MessageBox.Show("" + EX.Message);
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {         
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string Bugün = "http://www.tcmb.gov.tr/kurlar/today.xml";
                var xmldoc = new XmlDocument();
                var xmldoc1 = new XmlDocument();
                string eskigün = "http://www.tcmb.gov.tr/kurlar/201501/15012015.xml";
                xmldoc.Load(Bugün);
                xmldoc1.Load(eskigün);
                DateTime time = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                // string USD2 = xmldoc1.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerXml;
                string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                label1.Text = string.Format("Tarih={0} BanknoteSelling USD:{1}", time.ToShortDateString(), USD);
                label2.Text = string.Format("Tarih={0} BanknoteSelling EURO:{1}", time.ToShortDateString(), EURO);
                // label3.Text = string.Format("Tarih={0} forex sellin USD:{1}", time.ToShortDateString(), USD2);
                DateTime time1 = Convert.ToDateTime(xmldoc1.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string USD1 = xmldoc1.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                label4.Text = string.Format("Tarih={0} USD:{1}", time1.ToShortDateString(), USD1);
                string EURO1 = xmldoc1.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                label5.Text = string.Format("Tarih={0} EURO:{1}", time1.ToShortDateString(), EURO1);

            }
            catch (Exception)
            {

                MessageBox.Show("İnternete bağlanmayı deneyiniz");
            }
           
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            WebProxy wb=new WebProxy(WebProxy.GetDefaultProxy().Address);
            WebClient wc=new WebClient();
            wc.Proxy=wb;
            wc.Encoding = Encoding.UTF8;
            string site=wc.DownloadString("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument xml=new XmlDocument();
            xml.LoadXml(site);
            XmlNodeList liste=xml.SelectNodes("Tarih_Date/Currency");
            foreach (XmlNode item in liste)
	       {
		      string isim=item["Isim"].InnerText;
              string alis=item["ForexBuying"]==null ?"":item["ForexBuying"].InnerText;
              string satis = item["ForexSelling"] == null ? "" : item["ForexSelling"].InnerText;
              listBox1.Items.Add("Para Birimi=" +isim+" Alış Fiyatı =" +alis+"  Satıs Fiyat= " +satis);
	       }
        
        }
      
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string baslık = listBox2.SelectedItem.ToString();
            //XmlNodeList list = breakfast_menu1.SelectNodes("food");
            //foreach (XmlNode item in list)
            //{
            //    string name1 = item.SelectSingleNode("name").InnerText;
            //    if (name1 == baslık)
            //    {
            //        listBox2.Items.Add("" + item.SelectSingleNode("price").InnerText);
            //    }

            //}
        
        }
       // XmlNode verilen değişken ile SelectsinğleNode değerine ulaşabiliriz
        //XmlNode verilen değişken ile bütün tablo bilğilerini de SelectNodes("")çekebiliriz çektikten sonra XmlNodeListe aktarılır ki
        //Xml Nodeliste for dönğüsü kullanılarak bütün değerrlere ulaşılır
        private void button9_Click(object sender, EventArgs e)
        {
            doc = new XmlDocument();// doc.Load("..\\..\\YEMEKLER1.xml"); var olan kasörün iki klasör üstüne çıkarak dosyayı kaydeder
            //doc.Load("Yemekler1.xml");
            doc.Load("..\\..\\YEMEKLER1.xml");//SelectNodes bir tablo içinde birden fazla bilğiyi alır sadece bir bilği almak için sinğle node kullanılır
            breakfast_menu1 = doc.SelectSingleNode("breakfast_menu");//doc ile okuma olduktan sonra ile breakfast_menu değerlerini alır breakfast_menu1 değişkenine atar
            this.Text = breakfast_menu1.SelectSingleNode("yemektarifleri").InnerText;
            label6.Text = string.Format("{0}-{1}", breakfast_menu1.SelectSingleNode("yemektarifleri").InnerText, breakfast_menu1.SelectSingleNode("ascılar2").InnerText);
            XmlNodeList yemekler = breakfast_menu1.SelectNodes("food");//Birden fazla bilğiyi içinde barındıran veriyi XmlNodeList ile alabiliriz 
            foreach (XmlNode item in yemekler)//XmlNode var değişkeni  kabul edilir selectnode içinde dönğüyü sağlar
            {
                listBox1.Items.Add("Yemek Adı="+item.SelectSingleNode("name").InnerText.PadRight(10)+"yemek fiyatı="+item.SelectSingleNode("price").InnerText.PadLeft(10)+"yemeğin Kalorisi="+item.SelectSingleNode("calories").InnerText.PadLeft(10));
            }

        }

    }
}
//NOT SQLDEN XML ALABİLMEK İÇİN ÖNCE QUERY YAZDIĞIMIZ YERE QUERY YAZIP ÇALIŞTIR ĞELEN LİNKİ TIKLA XML DOSYASI OLUŞACAKTIR
//ÖRNEK AŞAĞIDAKİ KODU ÇALIŞTIRDIĞIMIZDA BİZE XML DOSYASINI OLUŞTURACAKTIR
//select *  /*BÜTÜN ÖZELLİKLERİ ATRİBUTLERİ SEKLİNDE ĞÖSTERİR*/
//from Customers
//FOR XML RAW('MÜSTERİLER'),TYPE,ELEMENTS,ROOT('MÜSTERİLERİM');
//http://csharp.net-informations.com/xml/xml-from-excel.htm