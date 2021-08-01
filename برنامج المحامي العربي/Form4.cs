using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace برنامج_المحامي_العربي
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            ArrayList list = DBase.getAll2(Form1.rowid);

            for (int i = 0; i < list.Count; i++)
            {
                Hashtable ss = (Hashtable)list[i];

                dataGridView2.Rows.Add(new string[] { ss["id"].ToString(), ss["a1"].ToString(), ss["a3"].ToString() });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Form1.rowid_2 = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                Form1.done = true;

                Close();

            }catch(Exception ){}
        }
    }
}