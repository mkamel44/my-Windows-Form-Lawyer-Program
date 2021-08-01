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
    public partial class Form1 : Form
    {
        public static bool done = false;
        public static string rowid = "";
        public static string rowid_1 = "";
        public static string rowid_2 = "";

        public Form1()
        {
            InitializeComponent();
            tabControl1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = true;
            rowid = DBase.addNew();
            emptyAllFields();
        }

        public void emptyAllFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            //-----------------------------------
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox3.Text = "";
            //-----------------------------------
            textBox10.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            textBox8.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBase.TextBoxSaveChanged("a1", textBox1.Text, rowid);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DBase.TextBoxSaveChanged("a2", textBox2.Text, rowid);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DBase.TextBoxSaveChanged("a3", dateTimePicker1.Text, rowid);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DBase.TextBoxSaveChanged("a4", textBox3.Text, rowid);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DBase.TextBoxSaveChanged("a5", textBox4.Text, rowid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ff = new Form2();

            ff.ShowDialog();

            if (done)
            {

                get(DBase.get(rowid));

                done = false;

            }
        }

        public void get(Hashtable tb)
        {
            tabControl1.Enabled = true;

            emptyAllFields();

            textBox1.Text = tb["a1"].ToString();
            textBox2.Text = tb["a2"].ToString();
            dateTimePicker1.Text = tb["a3"].ToString();
            textBox3.Text = tb["a4"].ToString();
            textBox4.Text = tb["a5"].ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ff = new Form7();

            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rowid_1 = DBase.add1(rowid, textBox5.Text, textBox6.Text, dateTimePicker2.Text, comboBox3.Text, textBox7.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                DBase.update1(rowid_1, textBox5.Text, textBox6.Text, dateTimePicker2.Text, comboBox3.Text, textBox7.Text);

            }
            catch (Exception) { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                DBase.delete1(rowid_1);

                button12_Click(null, null);

            }
            catch (Exception)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox3.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            textBox8.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rowid_2 = DBase.add2(rowid, textBox10.Text, textBox9.Text, dateTimePicker3.Text, comboBox1.Text, textBox8.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DBase.update2(rowid_2, textBox10.Text, textBox9.Text, dateTimePicker3.Text, comboBox1.Text, textBox8.Text);
            }
            catch (Exception) { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                DBase.delete1(rowid_2);

                button13_Click(null, null);
            }
            catch (Exception) { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {

                DBase.delete(rowid);

                DBase.delete_1(rowid);

                DBase.delete_2(rowid);

                tabControl1.Enabled = false;

                emptyAllFields();

            }
            catch (Exception) { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var ff = new Form3();

            ff.ShowDialog();

            if (done)
            {

                get1(DBase.get1(rowid_1));

                done = false;

            }
        }

        public void get1(Hashtable tb)
        {

            textBox5.Text = tb["a1"].ToString();
            textBox6.Text = tb["a2"].ToString();
            dateTimePicker2.Text = tb["a3"].ToString();
            comboBox3.Text = tb["a4"].ToString();
            textBox7.Text = tb["a5"].ToString();

        }

        public void get2(Hashtable tb)
        {

            textBox10.Text = tb["a1"].ToString();
            textBox9.Text = tb["a2"].ToString();
            dateTimePicker3.Text = tb["a3"].ToString();
            comboBox1.Text = tb["a4"].ToString();
            textBox8.Text = tb["a5"].ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var ff = new Form4();

            ff.ShowDialog();

            if (done)
            {

                get2(DBase.get2(rowid_2));

                done = false;

            }
        }



    }
}