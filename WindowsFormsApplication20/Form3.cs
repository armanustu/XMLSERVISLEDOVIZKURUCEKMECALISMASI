using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApplication20
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();//XML DOC ile Verilen  produc.xml dosyasını Node ave child Nodes ile oku 
            XmlNodeList xmlnode;
            int i = 0;  
            string str = null;
            FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Product");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                MessageBox.Show(str);
                listBox4.Items.Add(str);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //String xmlNode;

            XmlReader xReader = XmlReader.Create("C:\\Users\\lenova\\Documents\\Visual Studio 2012\\Projects\\WindowsFormsApplication20\\WindowsFormsApplication20\\bin\\Debug\\product.xml");
            while (xReader.Read())
            {
                switch (xReader.NodeType)
                {
                    case XmlNodeType.Element:
                        listBox1.Items.Add("<" + xReader.Name + ">");
                        break;
                    case XmlNodeType.Text:
                        listBox1.Items.Add(xReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        listBox1.Items.Add("");
                        break;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();//xml doc ile path yolu verilen tabloyu tek bir değeri SelectSingleNode ile okuruz 
            xmlDoc.Load("D:\\product.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Product");
            string proID = "", proName = "", price = "";
            foreach (XmlNode node in nodeList)
            {
                proID = node.SelectSingleNode("Product_id").InnerText;
                proName = node.SelectSingleNode("Product_name").InnerText;
                price = node.SelectSingleNode("Product_price").InnerText;
               // MessageBox.Show(proID + " " + proName + " " + price);
                listBox2.Items.Add(proID + " " + proName + " " + price);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    http://csharp.net-informations.com/xml/xml-from-sql.htm

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\product.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Product");
            string proID = "", proName = "", price = "";
            foreach (XmlNode node in nodeList)
            {
                proID = node.SelectSingleNode("Product_id").InnerText;
                proName = node.SelectSingleNode("Product_name").InnerText;
                price = node.SelectSingleNode("Product_price").InnerText;
                MessageBox.Show(proID + " " + proName + " " + price);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlReader = new XmlTextReader("D:\\product.xml");
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        listBox5.Items.Add("<" + xmlReader.Name + ">");
                        break;
                    case XmlNodeType.Text:
                        listBox5.Items.Add(xmlReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        listBox5.Items.Add("");
                        break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;

            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());

            DataSet ds = new DataSet();

            DataView dv;

            ds.ReadXml(xmlFile);


            string ürün = textBox1.Text;
            dv = new DataView(ds.Tables[0]);

            dv.Sort = "Product_name";

            int index = dv.Find(""+ürün);



            if (index == -1)
            {

                MessageBox.Show("Item Not Found");

            }

            else
            {
                MessageBox.Show( "ARADIĞINIZ BULUNDU ÜRÜN BULUNDU");
                MessageBox.Show("ÜRÜN ADI="+dv[index]["Product_name"].ToString() + "ÜRÜN FİYATI= " + dv[index]["Product_Price"].ToString());



            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);
            dv = new DataView(ds.Tables[0], "Product_price > = 3000", "Product_Name", DataViewRowState.CurrentRows);
            dv.ToTable().WriteXml("Result.xml");
            MessageBox.Show("Result.xml sayfasına kaydedildi");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XmlTextReader rd = new XmlTextReader("test.xml");
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(rd);
            //XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("user");
            //string users;
            //foreach (XmlNode node in nodeList)
            //{
            //    users = node.SelectSingleNode(""+node.Name).InnerText;
            //  //proID = node.SelectSingleNode("Product_id").InnerText;

            //    MessageBox.Show(users);
            //}
            while (rd.Read())
            {
                if (rd.NodeType ==XmlNodeType.Element) {

                    if (rd.HasAttributes)
                    {
                        while (rd.MoveToNextAttribute())
                        {
                            listBox6.Items.Add(rd.AttributeCount+""+rd.Name+""+rd.Value);

                        }
                    }
                
                }
                
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNode xmlnode;
            FileStream fs = new FileStream("tree.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.ChildNodes[1];
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xmldoc.DocumentElement.Name));
            TreeNode tNode;
            tNode = treeView1.Nodes[0];
            AddNode(xmlnode, tNode);
        }
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }

    }
}
