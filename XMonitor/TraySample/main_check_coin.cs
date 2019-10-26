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
    class main_check_coin
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;
        string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataSets\Database.mdb";

        public MainWindow frm = new MainWindow();

        public void check_bitcoin(double value)
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
            }

        }
        public void check_ethereum(double value)
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

            }

        }
        public void check_ripple(double value)
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

            }

        }
        public void check_eos(double value)
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

            }

        }
        public void check_bitcoincash(double value)
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

            }

        }
    }
}
