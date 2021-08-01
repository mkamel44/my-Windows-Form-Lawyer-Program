using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace برنامج_المحامي_العربي
{
    public class DBase
    {
        public static OleDbConnection createConnection()
        {

            int index = Application.ExecutablePath.LastIndexOf('\\');

            string path = Application.ExecutablePath.Substring(0, index) + "\\" + "dbase.mdb";

            OleDbConnection aConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Persist Security Info=True;Jet OLEDB:Database Password=admin123");

            aConnection.Open();

            return aConnection;

        }

        public static void TextBoxSaveChanged(string key, string value, string id)
        {

            var conn = createConnection();

            var addEmp = new OleDbCommand("update data set " + key + "='" + value + "' where id=" + id, conn);

            addEmp.ExecuteNonQuery();

            conn.Close();

        }

        public static ArrayList getAll()
        {
            ArrayList list = new ArrayList();

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT * FROM data order by id desc";

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Hashtable table = new Hashtable();

                table.Add("id", reader["id"].ToString());

                table.Add("a1", reader["a1"].ToString());

                table.Add("a2", reader["a2"].ToString());

                table.Add("a3", reader["a3"].ToString());

                table.Add("a4", reader["a4"].ToString());

                table.Add("a5", reader["a5"].ToString());

                list.Add(table);
            }

            reader.Close();

            con.Close();

            return list;
        }

        public static ArrayList getAll1(string id)
        {
            ArrayList list = new ArrayList();

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT * FROM subdata1 where data_id=" + id + " order by id desc";

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Hashtable table = new Hashtable();

                table.Add("id", reader["id"].ToString());

                table.Add("a1", reader["a1"].ToString());

                table.Add("a2", reader["a2"].ToString());

                table.Add("a3", reader["a3"].ToString());

                table.Add("a4", reader["a4"].ToString());

                table.Add("a5", reader["a5"].ToString());

                list.Add(table);
            }

            reader.Close();

            con.Close();

            return list;
        }

        public static ArrayList getAll2(string id)
        {
            ArrayList list = new ArrayList();

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT * FROM subdata2 where data_id=" + id + " order by id desc";

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Hashtable table = new Hashtable();

                table.Add("id", reader["id"].ToString());

                table.Add("a1", reader["a1"].ToString());

                table.Add("a2", reader["a2"].ToString());

                table.Add("a3", reader["a3"].ToString());

                table.Add("a4", reader["a4"].ToString());

                table.Add("a5", reader["a5"].ToString());

                list.Add(table);
            }

            reader.Close();

            con.Close();

            return list;
        }

        public static Hashtable get(string id)
        {

            Hashtable table = new Hashtable();

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT * FROM data where id=" + id;

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                table.Add("id", reader["id"].ToString());

                table.Add("a1", reader["a1"].ToString());

                table.Add("a2", reader["a2"].ToString());

                table.Add("a3", reader["a3"].ToString());

                table.Add("a4", reader["a4"].ToString());

                table.Add("a5", reader["a5"].ToString());
            }

            reader.Close();

            con.Close();

            return table;
        }

        public static Hashtable get1(string id)
        {

            Hashtable table = new Hashtable();

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT * FROM subdata1 where id=" + id;

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                table.Add("id", reader["id"].ToString());

                table.Add("a1", reader["a1"].ToString());

                table.Add("a2", reader["a2"].ToString());

                table.Add("a3", reader["a3"].ToString());

                table.Add("a4", reader["a4"].ToString());

                table.Add("a5", reader["a5"].ToString());
            }

            reader.Close();

            con.Close();

            return table;
        }

        public static Hashtable get2(string id)
        {

            Hashtable table = new Hashtable();

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT * FROM subdata2 where id=" + id;

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                table.Add("id", reader["id"].ToString());

                table.Add("a1", reader["a1"].ToString());

                table.Add("a2", reader["a2"].ToString());

                table.Add("a3", reader["a3"].ToString());

                table.Add("a4", reader["a4"].ToString());

                table.Add("a5", reader["a5"].ToString());
            }

            reader.Close();

            con.Close();

            return table;
        }

        public static string addNew()
        {
            OleDbConnection con = createConnection();

            String insertSQL = "insert into data (a1,a2,a3,a4,a5) values ('','','','','')";

            OleDbCommand command = new OleDbCommand(insertSQL, con);

            command.ExecuteNonQuery();

            con.Close();

            return getLastRow();

        }

        public static string add1(string id, string a1, string a2, string a3, string a4, string a5)
        {
            OleDbConnection con = createConnection();

            String insertSQL = "insert into subdata1 (data_id,a1,a2,a3,a4,a5) values (" + id + ",'" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "')";

            OleDbCommand command = new OleDbCommand(insertSQL, con);

            command.ExecuteNonQuery();

            con.Close();

            return getLastRow1();
        }

        public static string add2(string id, string a1, string a2, string a3, string a4, string a5)
        {
            OleDbConnection con = createConnection();

            String insertSQL = "insert into subdata2 (data_id,a1,a2,a3,a4,a5) values (" + id + ",'" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "')";

            OleDbCommand command = new OleDbCommand(insertSQL, con);

            command.ExecuteNonQuery();

            con.Close();

            return getLastRow1();
        }

        public static void update1(string id, string a1, string a2, string a3, string a4, string a5)
        {
            OleDbConnection con = createConnection();

            String insertSQL = "update subdata1 set a1='" + a1 + "' , a2='" + a2 + "', a3='" + a3 + "', a4='" + a4 + "', a5='" + a5 + "' where id =" + id;

            OleDbCommand command = new OleDbCommand(insertSQL, con);

            command.ExecuteNonQuery();

            con.Close();
        }

        public static void update2(string id, string a1, string a2, string a3, string a4, string a5)
        {
            OleDbConnection con = createConnection();

            String insertSQL = "update subdata2 set a1='" + a1 + "' , a2='" + a2 + "', a3='" + a3 + "', a4='" + a4 + "', a5='" + a5 + "' where id =" + id;

            OleDbCommand command = new OleDbCommand(insertSQL, con);

            command.ExecuteNonQuery();

            con.Close();
        }

        public static void delete1(string id)
        {
            OleDbConnection con = createConnection();

            string del = "delete from subdata1 where id=" + id;

            OleDbCommand command = new OleDbCommand(del, con);

            command.ExecuteNonQuery();

            con.Close();

        }

        public static void delete2(string id)
        {
            OleDbConnection con = createConnection();

            string del = "delete from subdata1 where id=" + id;

            OleDbCommand command = new OleDbCommand(del, con);

            command.ExecuteNonQuery();

            con.Close();

        }

        private static string getLastRow()
        {
            string lolo = "";

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT max(id) as lolo FROM data";

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lolo = reader["lolo"].ToString();
            }

            reader.Close();

            con.Close();

            return lolo;

        }

        private static string getLastRow1()
        {
            string lolo = "";

            OleDbConnection con = createConnection();

            String selectSQL = "SELECT max(id) as lolo FROM subdata1";

            OleDbCommand command = new OleDbCommand(selectSQL, con);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lolo = reader["lolo"].ToString();
            }

            reader.Close();

            con.Close();

            return lolo;

        }

        public static void delete(string id)
        {
            OleDbConnection con = createConnection();

            string del = "delete from data where id=" + id;

            OleDbCommand command = new OleDbCommand(del, con);

            command.ExecuteNonQuery();

            con.Close();

        }

        public static void delete_1(string id)
        {
            OleDbConnection con = createConnection();

            string del = "delete from subdata1 where data_id=" + id;

            OleDbCommand command = new OleDbCommand(del, con);

            command.ExecuteNonQuery();

            con.Close();

        }

        public static void delete_2(string id)
        {
            OleDbConnection con = createConnection();

            string del = "delete from subdata2 where data_id=" + id;

            OleDbCommand command = new OleDbCommand(del, con);

            command.ExecuteNonQuery();

            con.Close();

        }
    }
}