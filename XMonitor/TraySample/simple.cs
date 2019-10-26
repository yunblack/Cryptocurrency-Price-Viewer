using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net;
using System.Timers;
using Planet;
using System.Data.OleDb;

namespace Planet
{
    public partial class simple : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;
        string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataSets\Database.mdb";

        public simple()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }
        private int i = 0;

        private System.Timers.Timer aTimer;
        private void simple_Load(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += viewrefresh;
            aTimer.Enabled = true;
        }
        public void DisplaySettingValue_Dac()
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
                
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_Bitcoin()
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
                N06.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin04"])) + " won";
                N07.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Bitcoin09"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_Ethereum()
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
                N06.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum04"])) + " won";
                N07.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ethereum09"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_Ripple()
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
                N06.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple04"])) + " won";
                N07.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["Ripple09"])) + " won";                
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_EOS()
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
                N06.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS04"])) + " won";
                N07.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["EOS09"])) + " won";                
            }
            reader.Close();
            conn.Close();
            conn = null;
        }
        public void DisplaySettingValue_BitcoinCash()
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
                N06.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash04"])) + " won";
                N07.Text = String.Format("{0:#,###.####}", Convert.ToDouble(reader["BitcoinCash09"])) + " won";
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        private void viewrefresh(Object source, ElapsedEventArgs e)
        {
            Coin coin = new Coin();

            Coin_BTC coin1 = new Coin_BTC();
            Coin_ETH coin2 = new Coin_ETH();
            Coin_XPR coin3 = new Coin_XPR();
            Coin_EOS coin4 = new Coin_EOS();
            Coin_BCH coin5 = new Coin_BCH();
            Coin_ETC coin6 = new Coin_ETC();

            if (i == 0)
            {
                N01.Text = "Coin";
                N02.Text = "- won";
                N03.Text = "- won";
                N04.Text = "- won";
                N05.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
            }
            else if (i == 1)
            {
                N01.Text = "Bitcoin";
                coin1.get_coin("BTC", this);
                N05.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                DisplaySettingValue_Bitcoin();
            }
            else if (i == 2)
            {
                N01.Text = "Ethereum";
                coin2.get_coin("ETH", this);
                N05.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                DisplaySettingValue_Ethereum();
            }
            else if (i == 3)
            {
                N01.Text = "Ripple";
                coin3.get_coin("XRP", this);
                N05.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                DisplaySettingValue_Ripple();
            }
            else if (i == 4)
            {
                N01.Text = "EOS";
                coin4.get_coin("EOS", this);
                N05.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                DisplaySettingValue_EOS();
            }
            else
            {
                N01.Text = "Bitcoin Cash";
                coin5.get_coin("BCH", this);
                N05.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                DisplaySettingValue_BitcoinCash();
            }
        }

        private void setBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.Opacity = setBar.Value * 0.01;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            i = 0;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            i = 2;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            i = 3;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            i = 4;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            i = 5;
        }

        private void m2_Click(object sender, EventArgs e)
        {
            e1.Enabled = false;
            e2.Enabled = true;
            e3.Enabled = true;
            e4.Enabled = true;
            e5.Enabled = true;
            e6.Enabled = true;
            i = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            e1.Enabled = true;
            e2.Enabled = false;
            e3.Enabled = true;
            e4.Enabled = true;
            e5.Enabled = true;
            e6.Enabled = true;
            i = 1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            e1.Enabled = true;
            e2.Enabled = true;
            e3.Enabled = false;
            e4.Enabled = true;
            e5.Enabled = true;
            e6.Enabled = true;
            i = 2;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            e1.Enabled = true;
            e2.Enabled = true;
            e3.Enabled = true;
            e4.Enabled = false;
            e5.Enabled = true;
            e6.Enabled = true;
            i = 3;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            e1.Enabled = true;
            e2.Enabled = true;
            e3.Enabled = true;
            e4.Enabled = true;
            e5.Enabled = false;
            e6.Enabled = true;
            i = 4;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            e1.Enabled = true;
            e2.Enabled = true;
            e3.Enabled = true;
            e4.Enabled = true;
            e5.Enabled = true;
            e6.Enabled = false;
            i = 5;
        }
    }
    class Coin
    {
        public string get_coin(string coin_name, string coin_type)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);
                return coin_json["data"][coin_type].ToString();
            }
        }
    }

    class Coin_BTC
    {
        public simple frm = new simple();

        public void get_coin(string coin_name, simple frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.N04.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.N03.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.N02.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";

                //return coin_json["data"]["date"].ToString();
            }
        }
    }
    class Coin_ETH
    {
        public simple frm = new simple();

        public void get_coin(string coin_name, simple frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.N04.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.N03.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.N02.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";

                //return coin_json["data"]["date"].ToString();
            }
        }
    }
    class Coin_XPR
    {
        public simple frm = new simple();

        public void get_coin(string coin_name, simple frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.N04.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.N03.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.N02.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";

                //return coin_json["data"]["date"].ToString();
            }
        }
    }

    class Coin_EOS
    {
        public simple frm = new simple();

        public void get_coin(string coin_name, simple frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.N04.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.N03.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.N02.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";

                //return coin_json["data"]["date"].ToString();
            }
        }
    }

    class Coin_BCH
    {
        public simple frm = new simple();

        public void get_coin(string coin_name, simple frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.N04.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.N03.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.N02.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";

                //return coin_json["data"]["date"].ToString();
            }
        }
    }

    class Coin_ETC
    {
        public simple frm = new simple();

        public void get_coin(string coin_name, simple frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.N04.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.N03.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.N02.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";

                //return coin_json["data"]["date"].ToString();
            }
        }
    }
}
