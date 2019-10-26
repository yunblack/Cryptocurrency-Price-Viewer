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
using WatchDocks;

namespace Planet
{
    public partial class setting : MetroFramework.Forms.MetroForm
    {

        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

        string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataSets\Database.mdb";

        private settingComponent setComp = new settingComponent();
        public setting()
        {
            InitializeComponent();
            //DisplaySettingValue_Dac();
        }
        MainWindow f1;
        public setting(MainWindow form)
        {
            InitializeComponent();
            f1 = form;
        }

        private void setting_Load(object sender, EventArgs e)
        {
            main01.BringToFront();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = false;
            textEnabledNo();
            main01.Visible = false;

            setComp.DisplaySettingValue_Dac(this);
            setComp.evalVoid(this);

            SetName.Text = "Coin";
            SetName2.Text = "Coin";

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = false;
            textEnabledNo();
            main01.Visible = false;

            setComp.DisplaySettingValue_Bitcoin(this);
            setComp.evalVoid(this);

            SetName.Text = "Bitcoin";
            SetName2.Text = "Bitcoin";

            c2.Visible = true;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = false;
            textEnabledNo();
            main01.Visible = false;

            setComp.DisplaySettingValue_Ethereum(this);
            setComp.evalVoid(this);

            SetName.Text = "Ethereum";
            SetName2.Text = "Ethereum";

            c2.Visible = false;
            c3.Visible = true;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = false;
            textEnabledNo();
            main01.Visible = false;

            setComp.DisplaySettingValue_Ripple(this);
            setComp.evalVoid(this);

            SetName.Text = "Ripple";
            SetName2.Text = "Ripple";

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = true;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = false;
            textEnabledNo();
            main01.Visible = false;

            setComp.DisplaySettingValue_EOS(this);
            setComp.evalVoid(this);

            SetName.Text = "EOS";
            SetName2.Text = "EOS";

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = true;
            c6.Visible = false;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = false;
            textEnabledNo();
            main01.Visible = false;

            setComp.DisplaySettingValue_BitcoinCash(this);
            setComp.evalVoid(this);

            SetName.Text = "Bitcoin Cash";
            SetName2.Text = "Bitcoin Cash";

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = true;
        }

        private void b7_Click(object sender, EventArgs e)
        {

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void b8_Click(object sender, EventArgs e)
        {

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void b9_Click(object sender, EventArgs e)
        {

            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
        }

        private void IbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Coin3 coin = new Coin3();

            if (c2.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BTC", "average_price"))) + " won";

            }
            else if (c3.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("ETH", "average_price"))) + " won";

            }
            else if (c4.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("XRP", "average_price"))) + " won";

            }
            else if (c5.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("EOS", "average_price"))) + " won";

            }
            else if (c6.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BCH", "average_price"))) + " won";
            }


            bt1.Enabled = false;
            bt2.Enabled = true;

            t1.Enabled = true;
            t2.Enabled = true;
            t3.Enabled = true;
            t4.Enabled = true;
            t5.Enabled = true;
            t6.Enabled = true;
            t7.Enabled = true;
            t8.Enabled = true;
            t9.Enabled = true;
            t10.Enabled = true;
            t12.Enabled = true;
        }
        private void textEnabledNo()
        {
            t1.Enabled = false;
            t2.Enabled = false;
            t3.Enabled = false;
            t4.Enabled = false;
            t5.Enabled = false;
            t6.Enabled = false;
            t7.Enabled = false;
            t8.Enabled = false;
            t9.Enabled = false;
            t10.Enabled = false;
            t12.Enabled = false;
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            Coin3 coin = new Coin3();

            if (c2.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BTC", "average_price"))) + " won";

            }
            else if (c3.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("ETH", "average_price"))) + " won";

            }
            else if (c4.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("XRP", "average_price"))) + " won";

            }
            else if (c5.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("EOS", "average_price"))) + " won";

            }
            else if (c6.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BCH", "average_price"))) + " won";
            }

            t1.Enabled = false;
            t2.Enabled = false;
            t3.Enabled = false;
            t4.Enabled = false;
            t5.Enabled = false;
            t6.Enabled = false;
            t7.Enabled = false;
            t8.Enabled = false;
            t9.Enabled = false;
            t10.Enabled = false;
            t12.Enabled = false;

            bt1.Enabled = true;
            bt2.Enabled = false;


            setComp.evalVoid(this);
            windows task1 = new windows();
            
            if (c2.Visible)
            {
                if (conn == null)
                {
                    conn = new OleDbConnection(connStr);
                    conn.Open();
                }

                string sql = "Update table2 SET Bitcoin01='" + SetName.Text + "',Bitcoin02='" + t1.Text + "',Bitcoin03='" + t2.Text + "',Bitcoin04='" + t3.Text
                    + "',Bitcoin05='" + t4.Text + "',Bitcoin06='" + t5.Text + "',Bitcoin07='" + t6.Text + "',Bitcoin08='" + t7.Text + "',Bitcoin09='" + t8.Text
                    + "',Bitcoin10='" + t9.Text + "',Bitcoin11='" + t10.Text + "',BitcoinValue='" + t11.Text + "',BitcoinPerc='" + t12.Text + "' " +
                "WHERE Bitcoin01='" + SetName.Text + "'";

                //MessageBox.Show(sql);

                comm = new OleDbCommand(sql, conn);
                int x = comm.ExecuteNonQuery(); //int값을 리턴
                if (x == 1)
                {
                    task1.ShowDialog();
                }
                conn.Close();
                conn = null;

                setComp.DisplaySettingValue_Bitcoin(this);
            }
            else if (c3.Visible)
            {
                if (conn == null)
                {
                    conn = new OleDbConnection(connStr);
                    conn.Open();
                }

                string sql = "Update table3 SET Ethereum01='" + SetName.Text + "',Ethereum02='" + t1.Text + "',Ethereum03='" + t2.Text + "',Ethereum04='" + t3.Text
                    + "',Ethereum05='" + t4.Text + "',Ethereum06='" + t5.Text + "',Ethereum07='" + t6.Text + "',Ethereum08='" + t7.Text + "',Ethereum09='" + t8.Text
                    + "',Ethereum10='" + t9.Text + "',Ethereum11='" + t10.Text + "',EthereumValue='" + t11.Text + "',EthereumPerc='" + t12.Text + "' " +
                "WHERE Ethereum01='" + SetName.Text + "'";

                //MessageBox.Show(sql);

                comm = new OleDbCommand(sql, conn);
                int x = comm.ExecuteNonQuery(); //int값을 리턴
                if (x == 1)
                {
                    task1.Show();
                }
                conn.Close();
                conn = null;

                setComp.DisplaySettingValue_Ethereum(this);
            }
            else if (c4.Visible)
            {
                if (conn == null)
                {
                    conn = new OleDbConnection(connStr);
                    conn.Open();
                }

                string sql = "Update table4 SET Ripple01='" + SetName.Text + "',Ripple02='" + t1.Text + "',Ripple03='" + t2.Text + "',Ripple04='" + t3.Text
                    + "',Ripple05='" + t4.Text + "',Ripple06='" + t5.Text + "',Ripple07='" + t6.Text + "',Ripple08='" + t7.Text + "',Ripple09='" + t8.Text
                    + "',Ripple10='" + t9.Text + "',Ripple11='" + t10.Text + "',RippleValue='" + t11.Text + "',RipplePerc='" + t12.Text + "' " +
                "WHERE Ripple01='" + SetName.Text + "'";

                //MessageBox.Show(sql);

                comm = new OleDbCommand(sql, conn);
                int x = comm.ExecuteNonQuery(); //int값을 리턴
                if (x == 1)
                {
                    task1.Show();
                }
                conn.Close();
                conn = null;

                setComp.DisplaySettingValue_Ripple(this);
            }
            else if (c5.Visible)
            {
                if (conn == null)
                {
                    conn = new OleDbConnection(connStr);
                    conn.Open();
                }

                string sql = "Update table5 SET EOS01='" + SetName.Text + "',EOS02='" + t1.Text + "',EOS03='" + t2.Text + "',EOS04='" + t3.Text
                    + "',EOS05='" + t4.Text + "',EOS06='" + t5.Text + "',EOS07='" + t6.Text + "',EOS08='" + t7.Text + "',EOS09='" + t8.Text
                    + "',EOS10='" + t9.Text + "',EOS11='" + t10.Text + "',EOSValue='" + t11.Text + "',EOSPerc='" + t12.Text + "' " +
                "WHERE EOS01='" + SetName.Text + "'";

                //MessageBox.Show(sql);

                comm = new OleDbCommand(sql, conn);
                int x = comm.ExecuteNonQuery(); //int값을 리턴
                if (x == 1)
                {
                    task1.Show();
                }
                conn.Close();
                conn = null;

                setComp.DisplaySettingValue_EOS(this);
            }
            else if (c6.Visible)
            {
                if (conn == null)
                {
                    conn = new OleDbConnection(connStr);
                    conn.Open();
                }

                string sql = "Update table6 SET BitcoinCash01='" + SetName.Text + "',BitcoinCash02='" + t1.Text + "',BitcoinCash03='" + t2.Text + "',BitcoinCash04='" + t3.Text
                    + "',BitcoinCash05='" + t4.Text + "',BitcoinCash06='" + t5.Text + "',BitcoinCash07='" + t6.Text + "',BitcoinCash08='" + t7.Text + "',BitcoinCash09='" + t8.Text
                    + "',BitcoinCash10='" + t9.Text + "',BitcoinCash11='" + t10.Text + "',BitcoinCashValue='" + t11.Text + "',BitcoinCashPerc='" + t12.Text + "' " +
                "WHERE BitcoinCash01='" + SetName.Text + "'";

                //MessageBox.Show(sql);

                comm = new OleDbCommand(sql, conn);
                int x = comm.ExecuteNonQuery(); //int값을 리턴
                if (x == 1)
                {
                    task1.Show();
                }
                conn.Close();
                conn = null;

                setComp.DisplaySettingValue_BitcoinCash(this);
            }
          
            f1.evalButton();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Coin3 coin = new Coin3();

            if (c2.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BTC", "average_price"))) + " won";

            }
            else if (c3.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("ETH", "average_price"))) + " won";

            }
            else if (c4.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("XRP", "average_price"))) + " won";

            }
            else if (c5.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("EOS", "average_price"))) + " won";

            }
            else if (c6.Visible)
            {
                t11.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BCH", "average_price"))) + " won";
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            b2_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            b3_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            b4_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            b5_Click(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            b6_Click(sender, e);
        }
    }
    class Coin3
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
}
