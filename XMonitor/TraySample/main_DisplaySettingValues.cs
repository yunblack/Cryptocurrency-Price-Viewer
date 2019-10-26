using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Timers;
using Planet;
using WatchDocks;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using TraySample;

namespace WatchDocks
{
    class main_DisplaySettingValues
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;
        string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataSets\Database.mdb";

        public void DisplaySettingValue(MainWindow frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table0";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.Set1.Text = reader["f1"] + "";
                frm.Set2.Text = reader["f2"] + "";
                frm.Set3.Text = reader["f3"] + "";
                frm.Set4.Text = reader["f4"] + "";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        public void DisplaySettingValue_Dac()
        {
        }

        public void DisplaySettingValue_Bitcoin(MainWindow frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table2";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.Set1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin02"])) + " won";
                frm.Set2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin03"])) + " won";
                frm.Set3.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin04"])) + " won";
                frm.Set4.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin05"])) + " won";
                frm.Set5.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin06"])) + " won";

                frm.Set7.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin07"])) + " won";
                frm.Set8.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin08"])) + " won";
                frm.Set9.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin09"])) + " won";
                frm.Set10.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin10"])) + " won";
                frm.Set11.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin11"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_Ethereum(MainWindow frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table3";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.Set1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum02"])) + " won";
                frm.Set2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum03"])) + " won";
                frm.Set3.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum04"])) + " won";
                frm.Set4.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum05"])) + " won";
                frm.Set5.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum06"])) + " won";

                frm.Set7.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum07"])) + " won";
                frm.Set8.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum08"])) + " won";
                frm.Set9.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum09"])) + " won";
                frm.Set10.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum10"])) + " won";
                frm.Set11.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum11"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_Ripple(MainWindow frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table4";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.Set1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple02"])) + " won";
                frm.Set2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple03"])) + " won";
                frm.Set3.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple04"])) + " won";
                frm.Set4.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple05"])) + " won";
                frm.Set5.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple06"])) + " won";

                frm.Set7.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple07"])) + " won";
                frm.Set8.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple08"])) + " won";
                frm.Set9.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple09"])) + " won";
                frm.Set10.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple10"])) + " won";
                frm.Set11.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple11"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_EOS(MainWindow frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table5";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.Set1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS02"])) + " won";
                frm.Set2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS03"])) + " won";
                frm.Set3.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS04"])) + " won";
                frm.Set4.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS05"])) + " won";
                frm.Set5.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS06"])) + " won";

                frm.Set7.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS07"])) + " won";
                frm.Set8.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS08"])) + " won";
                frm.Set9.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS09"])) + " won";
                frm.Set10.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS10"])) + " won";
                frm.Set11.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS11"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_BitcoinCash(MainWindow frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table6";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.Set1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash02"])) + " won";
                frm.Set2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash03"])) + " won";
                frm.Set3.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash04"])) + " won";
                frm.Set4.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash05"])) + " won";
                frm.Set5.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash06"])) + " won";

                frm.Set7.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash07"])) + " won";
                frm.Set8.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash08"])) + " won";
                frm.Set9.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash09"])) + " won";
                frm.Set10.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash10"])) + " won";
                frm.Set11.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash11"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
    }
}
