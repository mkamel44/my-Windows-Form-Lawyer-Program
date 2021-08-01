using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace برنامج_المحامي_العربي
{
    public partial class Form6 : Form
    {
        public bool Bo;

        public Form6()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
          

            var conn = DBase.createConnection();

            var getEmp = new OleDbCommand("select * from admin where name='" + textBox1.Text + "' and pass='" + textBox2.Text + "'", conn);

            var myReader = getEmp.ExecuteReader();

            Bo = false;

            while (myReader.Read())
            {
                Bo = true;
            }

            myReader.Close();
            conn.Close();


            if (Bo)
            {
                textBox1.Text = "";

                textBox2.Text = "";

                button1.Enabled = false;

                Close();
            }
            else
            {
                MessageBox.Show(@"الاسم وكلمة السر خطأ");
            }

        }
    }
}