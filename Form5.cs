using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel; 
namespace WindowsFormsApplication20
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "42");
            xmlWriter.WriteString("arda Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "39");
            xmlWriter.WriteString("sema çoskun");


            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "43");
            xmlWriter.WriteString("alper");


            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
       // http://csharp.net-informations.com/excel/csharp-excel-datagridview.htm
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn ;
            string connectionString = null;
            string sql = null;

            connectionString = "server=DESKTOP-E247TKB\\SQLEXPRESS; Initial Catalog=NORTHWND;Integrated Security=SSPI";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Products";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp ;
            Excel.Workbook xlWorkBook ;
            Excel.Worksheet xlWorkSheet ;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0; 

            for (i = 0; i <= dataGridView1.RowCount  - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount  - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("csharp.net-informations.xlS", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file D:\\csharp.net-informations.xls");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Create A XML Document Of Response String  
                XmlDocument xmlDocument = new XmlDocument();

                //Read the XML File  
                xmlDocument.Load("C:\\Users\\lenova\\Documents\\Visual Studio 2012\\Projects\\WindowsFormsApplication20\\WindowsFormsApplication20\\demo.xml");

                //Create a XML Node List with XPath Expression  
                XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/info/collage");

                List<Info> infos = new List<Info>();

                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    Info info = new Info();
                    info.CollageName = xmlNode["name"].InnerText;
                    info.Students = xmlNode["students"].InnerText;
                    infos.Add(info);
                }
                foreach (Info item in infos)
                {
                    listBox2.Items.Add( item.CollageName+""+item.Students);
                }
               
                
            }
            catch
            {
                throw;
            }  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
