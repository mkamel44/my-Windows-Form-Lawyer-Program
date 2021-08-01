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
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void Button1Click(object sender, EventArgs e)
		{
			var conn = DBase.createConnection();

			var addEmp = new OleDbCommand("update admin set name='" + textBox1.Text + "' , pass='" + textBox2.Text + "'", conn);

			addEmp.ExecuteNonQuery();

			conn.Close();

			Close();

		}
	}
}
