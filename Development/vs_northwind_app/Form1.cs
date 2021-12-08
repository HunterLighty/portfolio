using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment9_Lighty
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter DANorthwind;
        OleDbCommandBuilder commandbuilder;
        DataTable DTCategories = new DataTable();
        DataRow dtCategoryRow;
        String Connstr, dbname;
        String sqlstr;
        int rowpos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (rowpos >= DTCategories.Rows.Count - 1)
            {
                return;
            }
            else
            {
                rowpos += 1;
            }
            Cattxt.Text = Convert.ToString(DTCategories.Rows[rowpos][0]);
            Nametxt.Text = Convert.ToString(DTCategories.Rows[rowpos][1]);
            Desctxt.Text = Convert.ToString(DTCategories.Rows[rowpos][2]);
        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (rowpos <= 0)
            {
                return;
            }
            else
            {
                rowpos -= 1;
            }
            Cattxt.Text = Convert.ToString(DTCategories.Rows[rowpos][0]);
            Nametxt.Text = Convert.ToString(DTCategories.Rows[rowpos][1]);
            Desctxt.Text = Convert.ToString(DTCategories.Rows[rowpos][2]);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbname = "Northwind.mdb";
            Connstr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source = " + dbname;
            sqlstr = "Select * from Categories;";
            DANorthwind = new OleDbDataAdapter(sqlstr, Connstr);
            DANorthwind.Fill(DTCategories);
            if (DTCategories.Rows.Count > 0)
            {
                Cattxt.Text = Convert.ToString(DTCategories.Rows[rowpos][0]);
                Nametxt.Text = Convert.ToString(DTCategories.Rows[rowpos][1]);
                Desctxt.Text = Convert.ToString(DTCategories.Rows[rowpos][2]);


            }
        }
    }
}
