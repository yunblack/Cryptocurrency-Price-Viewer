using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Data.OleDb;
using TraySample;
using Planet;


namespace WatchDocks
{
    class settingComponent
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;
        string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataSets\Database.mdb";

        public void evalVoid(setting frm)
        {
            if (String.IsNullOrEmpty(frm.t1.Text))
            {
                frm.t1.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t2.Text))
            {
                frm.t2.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t3.Text))
            {
                frm.t3.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t4.Text))
            {
                frm.t4.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t5.Text))
            {
                frm.t5.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t6.Text))
            {
                frm.t6.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t7.Text))
            {
                frm.t7.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t8.Text))
            {
                frm.t8.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t9.Text))
            {
                frm.t9.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t10.Text))
            {
                frm.t10.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t11.Text))
            {
                frm.t11.Text = "0";
            }
            if (String.IsNullOrEmpty(frm.t12.Text))
            {
                frm.t12.Text = "0";
            }
        }

        public void DisplaySettingValue_Dac(setting frm)
        {
            if (conn == null) //DB
            {
                conn = new OleDbConnection(connStr);
                conn.Open(); //DB open
            }
            string sql = "SELECT * FROM table1";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                frm.t1.Text = reader["Dac02"] + "";
                frm.t2.Text = reader["Dac03"] + "";
                frm.t3.Text = reader["Dac04"] + "";
                frm.t4.Text = reader["Dac05"] + "";
                frm.t5.Text = reader["Dac06"] + "";
                frm.t6.Text = reader["Dac07"] + "";
                frm.t7.Text = reader["Dac08"] + "";
                frm.t8.Text = reader["Dac09"] + "";
                frm.t9.Text = reader["Dac10"] + "";
                frm.t10.Text = reader["Dac11"] + "";
                frm.t11.Text = reader["DacValue"] + "";
                frm.t12.Text = reader["DacPerc"] + "";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        public void DisplaySettingValue_Bitcoin(setting frm)
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
                frm.t1.Text = reader["Bitcoin02"] + "";
                frm.t2.Text = reader["Bitcoin03"] + "";
                frm.t3.Text = reader["Bitcoin04"] + "";
                frm.t4.Text = reader["Bitcoin05"] + "";
                frm.t5.Text = reader["Bitcoin06"] + "";
                frm.t6.Text = reader["Bitcoin07"] + "";
                frm.t7.Text = reader["Bitcoin08"] + "";
                frm.t8.Text = reader["Bitcoin09"] + "";
                frm.t9.Text = reader["Bitcoin10"] + "";
                frm.t10.Text = reader["Bitcoin11"] + "";
                frm.t11.Text = reader["BitcoinValue"] + "";
                frm.t12.Text = reader["BitcoinPerc"] + "";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        public void DisplaySettingValue_Ethereum(setting frm)
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
                frm.t1.Text = reader["Ethereum02"] + "";
                frm.t2.Text = reader["Ethereum03"] + "";
                frm.t3.Text = reader["Ethereum04"] + "";
                frm.t4.Text = reader["Ethereum05"] + "";
                frm.t5.Text = reader["Ethereum06"] + "";
                frm.t6.Text = reader["Ethereum07"] + "";
                frm.t7.Text = reader["Ethereum08"] + "";
                frm.t8.Text = reader["Ethereum09"] + "";
                frm.t9.Text = reader["Ethereum10"] + "";
                frm.t10.Text = reader["Ethereum11"] + "";
                frm.t11.Text = reader["EthereumValue"] + "";
                frm.t12.Text = reader["EthereumPerc"] + "";

            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        public void DisplaySettingValue_Ripple(setting frm)
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
                frm.t1.Text = reader["Ripple02"] + "";
                frm.t2.Text = reader["Ripple03"] + "";
                frm.t3.Text = reader["Ripple04"] + "";
                frm.t4.Text = reader["Ripple05"] + "";
                frm.t5.Text = reader["Ripple06"] + "";
                frm.t6.Text = reader["Ripple07"] + "";
                frm.t7.Text = reader["Ripple08"] + "";
                frm.t8.Text = reader["Ripple09"] + "";
                frm.t9.Text = reader["Ripple10"] + "";
                frm.t10.Text = reader["Ripple11"] + "";
                frm.t11.Text = reader["RippleValue"] + "";
                frm.t12.Text = reader["RipplePerc"] + "";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_EOS(setting frm)
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
                frm.t1.Text = reader["EOS02"] + "";
                frm.t2.Text = reader["EOS03"] + "";
                frm.t3.Text = reader["EOS04"] + "";
                frm.t4.Text = reader["EOS05"] + "";
                frm.t5.Text = reader["EOS06"] + "";
                frm.t6.Text = reader["EOS07"] + "";
                frm.t7.Text = reader["EOS08"] + "";
                frm.t8.Text = reader["EOS09"] + "";
                frm.t9.Text = reader["EOS10"] + "";
                frm.t10.Text = reader["EOS11"] + "";
                frm.t11.Text = reader["EOSValue"] + "";
                frm.t12.Text = reader["EOSPerc"] + "";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        public void DisplaySettingValue_BitcoinCash(setting frm)
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
                frm.t1.Text = reader["BitcoinCash02"] + "";
                frm.t2.Text = reader["BitcoinCash03"] + "";
                frm.t3.Text = reader["BitcoinCash04"] + "";
                frm.t4.Text = reader["BitcoinCash05"] + "";
                frm.t5.Text = reader["BitcoinCash06"] + "";
                frm.t6.Text = reader["BitcoinCash07"] + "";
                frm.t7.Text = reader["BitcoinCash08"] + "";
                frm.t8.Text = reader["BitcoinCash09"] + "";
                frm.t9.Text = reader["BitcoinCash10"] + "";
                frm.t10.Text = reader["BitcoinCash11"] + "";
                frm.t11.Text = reader["BitcoinCashValue"] + "";
                frm.t12.Text = reader["BitcoinCashPerc"] + "";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
    }
}
