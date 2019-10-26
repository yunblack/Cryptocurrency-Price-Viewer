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
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Xml;
using System.Data;
using Newtonsoft.Json;


namespace TraySample
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm 
    {
        public MainWindow()
        {
           
           InitializeComponent();
           DisplaySetting.DisplaySettingValue(this);

            this.FormClosing += Form1_FormClosing;
            this.notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            this.ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            this.openSmallScreenToolStripMenuItem.Click += openSmallScreenToolStripMenuItem_Click;
            this.openMainScreenToolStripMenuItem.Click += openMainScreenToolStripMenuItem_Click;
            this.settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;      
            this.detailViewToolStripMenuItem.Click+=detailViewToolStripMenuItem_Click;
           
        }
        public int checktime = 0;
        public string coin_name_bitcoin = "BTC";
        public string coin_name_ethereum = "ETH";
        public string coin_name_ripple = "XRP";
        public string coin_name_eos = "EOS";
        public string coin_name_bitcoincash = "BCH";

        private main_DisplaySettingValues DisplaySetting = new main_DisplaySettingValues();

        public void evalButton()
        {
            if (c1.Visible)
            {
                DisplaySetting.DisplaySettingValue(this);
            }
            if (c2.Visible)
            {
                DisplaySetting.DisplaySettingValue_Bitcoin(this);
            }
            if (c3.Visible)
            {
                DisplaySetting.DisplaySettingValue_Ethereum(this);
            }
            if (c4.Visible)
            {
                DisplaySetting.DisplaySettingValue_Ripple(this);
            }
            if (c5.Visible)
            {
                DisplaySetting.DisplaySettingValue_EOS(this);
            }
            if (c6.Visible)
            {
                DisplaySetting.DisplaySettingValue_BitcoinCash(this);
            }
        }       

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            System.Environment.Exit(0);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            this.Visible = false;
        }

        private System.Timers.Timer aTimer;


        private void DropDownInit()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("BTC", "비트코인");

            ddlCoin.DataSource = new BindingSource(items, null);
            ddlCoin.DisplayMember = "Value";
            ddlCoin.ValueMember = "Key";
            
            items = new Dictionary<string, string>();
            items.Add("days", "1일");

            ddlTime.DataSource = new BindingSource(items, null);
            ddlTime.DisplayMember = "Value";
            ddlTime.ValueMember = "Key";
            ddlTime.SelectedValue = "days";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.ChartAreas["DateTime"].BackColor = Color.Black;
            
            DropDownInit();
            main_ad cs = new main_ad();
            cs.loadimage(this);

            Front_page.BringToFront();
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += viewrefresh;
            aTimer.Enabled = true;
        }

        private DateTime ConvertTimestamp(double timestamp)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return date.AddSeconds(timestamp / 1000).ToLocalTime();
        }

        private void refreshGraph()
        {

        }



        private void viewrefresh(Object source, ElapsedEventArgs e)
        {
            checktime++;
            if (checktime % 5==0)
            {
                //System.Diagnostics.Process.Start("https://watchdocks.tk/");

                   // adwindows sfrm = new adwindows();
                   // sfrm.ShowDialog();
                   // checktime = 0;
            }
            if (checktime % 1000 == 0)
            {
                //System.Diagnostics.Process.Start("http://darkengineer.net/");
            }

            Coin coin = new Coin();
            Coin_BTC coin1 = new Coin_BTC();
            Coin_ETH coin2 = new Coin_ETH();
            Coin_XPR coin3 = new Coin_XPR();
            Coin_EOS coin4 = new Coin_EOS();
            Coin_BCH coin5 = new Coin_BCH();
            Coin_ETC coin6 = new Coin_ETC();

            if (c1.Visible)
            {
                Front_page.Visible = false;
                Main01.BringToFront();
            }

            else if (c9.Visible)
            {
                Front_page.Visible = false;
                value_clean();
            }

            else if (c2.Visible)
            {
                Front_page.Visible = false;
                name.Text = "Bitcoin";


                t8.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                t9.Text = String.Format("{0:#,###}", coin1.get_coin("BTC", this));
            }

            else if (c3.Visible)
            {
                Front_page.Visible = false;
                name.Text = "Ethereum";


                t8.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                t9.Text = String.Format("{0:#,###}", coin1.get_coin("ETH", this));
            }
            else if (c4.Visible)
            {
                Front_page.Visible = false;
                name.Text = "Ripple";


                t8.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                t9.Text = String.Format("{0:#,###}", coin1.get_coin("XRP", this));

            }
            else if (c5.Visible)
            {
                Front_page.Visible = false;
                name.Text = "EOS";

                t8.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                t9.Text = String.Format("{0:#,###}", coin1.get_coin("EOS", this));


            }
            else if (c6.Visible)
            {
                Front_page.Visible = false;
                name.Text = "Bitcoin Cash";


                t8.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
                t9.Text = String.Format("{0:#,###}", coin1.get_coin("BCH", this));

            }

            else if (c7.Visible)
            {
                Front_page.Visible = false;
            }
        }

        private void value_clean()
        {
            t1.Text = "-";
            t2.Text = "-";
            t3.Text = "-";
            t4.Text = "-";
            t5.Text = "-";

            t8.Text = "-";
            t9.Text = "-";

            n1.Text = "Opening Price";
            n2.Text = "Closing Price";
            n3.Text = "Average Price";
            n4.Text = "Maximum Price";
            n5.Text = "Minimum Price";

            n8.Text = "Current Time";
            n9.Text = "Date Value";

            name.Text = "-";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Main01.BringToFront();
            c1.Visible = true;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c9.Visible = false;
        }
        private void BTC_graph()
        {
           
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Graph(sender, e, "BTC");
            price_panel.BringToFront();
            DisplaySetting.DisplaySettingValue_Bitcoin(this);
            c1.Visible = false;
            c2.Visible = true;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c9.Visible = false;

        }

        private async void Graph(object sender, EventArgs e, string Coin)
        {
            string requestUrl;
            int intCheck;
            string coin = Coin;
            string time = ddlTime.SelectedValue.ToString();

            if (int.TryParse(time, out intCheck))
                requestUrl = $"https://crix-api-endpoint.upbit.com/v1/crix/candles/minutes/{time}?code=CRIX.UPBIT.KRW-{coin}&count=200";
            else
                requestUrl = $"https://crix-api-endpoint.upbit.com/v1/crix/candles/{time}?code=CRIX.UPBIT.KRW-{coin}&count=200";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(requestUrl);
                var responseString = await response.Content.ReadAsStringAsync();
                var json = JArray.Parse(responseString);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(json.ToString());

                chart1.Series["DateTime"].XValueMember = "candleDateTimeKst";
                chart1.Series["DateTime"].YValueMembers = "highPrice,lowPrice,openingPrice,tradePrice";
                chart1.Series["DateTime"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                chart1.Series["DateTime"].CustomProperties = "PriceDownColor=Blue, PriceUpColor=Red";
                chart1.Series["DateTime"]["OpenCloseStyle"] = "Triangle";
                chart1.Series["DateTime"]["ShowOpenClose"] = "Both";
                chart1.DataManipulator.IsStartFromFirst = true;
                chart1.DataSource = dt;
                chart1.DataBind();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Graph(sender, e, "ETH");
            price_panel.BringToFront();
            DisplaySetting.DisplaySettingValue_Ethereum(this);

            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = true;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c9.Visible = false;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Graph(sender, e, "XRP");
            price_panel.BringToFront();
            DisplaySetting.DisplaySettingValue_Ripple(this);
            
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = true;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c9.Visible = false;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Graph(sender, e, "EOS");
            price_panel.BringToFront();
            DisplaySetting.DisplaySettingValue_EOS(this);

            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = true;
            c6.Visible = false;
            c7.Visible = false;
            c9.Visible = false;
        }
        private void b6_Click(object sender, EventArgs e)
        {
            Graph(sender, e, "BCH");
            price_panel.BringToFront();
            DisplaySetting.DisplaySettingValue_BitcoinCash(this);
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = true;
            c7.Visible = false;
            c9.Visible = false;
        }

        public void b7_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "simple")
                {
                    frm.Activate();
                    return;
                }
            }
            simple sfrm = new simple();
            sfrm.Show();
        }

        private void openSmallScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "simple")
                {
                    frm.Activate();
                    return;
                }
            }
            simple sfrm = new simple();
            sfrm.Show();
        }

        private void openMainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
            b1_Click(sender, e);
        }
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "info")
                {
                    frm.Activate();
                    return;
                }
            }

            info sfrm = new info();
            sfrm.ShowDialog();
            */
            
            TempWindow sfrm = new TempWindow();
            sfrm.ShowDialog();
            
        }

        private void b9_Click(object sender, EventArgs e)
        {
            /*
            TempWindow sfrm = new TempWindow();
            sfrm.ShowDialog();
            */
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "ExpertViewMode")
                {
                    frm.Activate();
                    return;
                }
            }

            ExpertViewMode sfrm = new ExpertViewMode();
            sfrm.Show();

        }

        private void openWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://watchdocks.tk/");
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {          
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b8_Click(object sender, EventArgs e)
        {
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "setting")
                {
                    frm.Activate();
                    return;
                }
            }
            
            setting sfrm = new setting(this);
            sfrm.Show();
            
            /*
            TempWindow sfrm = new TempWindow();
            sfrm.ShowDialog();
            */
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "setting")
                {
                    frm.Activate();
                    return;
                }
            }

            setting sfrm = new setting();
            sfrm.Show();
            */        

            TempWindow sfrm = new TempWindow();
            sfrm.ShowDialog();

        }

        

        private void detailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "ExpertViewMode")
                {
                    frm.Activate();
                    return;
                }
            }

            ExpertViewMode sfrm = new ExpertViewMode();
            sfrm.Show();

            /*
            TempWindow sfrm = new TempWindow();
            sfrm.ShowDialog();
            */
        }

        private void Main01_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void chatSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
                if (frm.Name == "chat")
                {
                    frm.Activate();
                    return;
                }
            }

            chat sfrm = new chat();
            sfrm.Show();
            */

            TempWindow sfrm = new TempWindow();
            sfrm.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void price_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void la02_Click(object sender, EventArgs e)
        {
            b2_Click(sender, e);
        }

        private void la03_Click(object sender, EventArgs e)
        {
            b3_Click(sender, e);
        }

        private void la04_Click(object sender, EventArgs e)
        {
            b4_Click(sender, e);
        }

        private void la05_Click(object sender, EventArgs e)
        {
            b5_Click(sender, e);
        }

        private void la06_Click(object sender, EventArgs e)
        {
            b6_Click(sender, e);
        }

        private void la07_Click(object sender, EventArgs e)
        {
            b7_Click(sender, e);
        }

        private void la08_Click(object sender, EventArgs e)
        {
            b9_Click(sender, e);
        }

        private void la09_Click(object sender, EventArgs e)
        {
            b8_Click(sender, e);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
    class Coin { 
            public string get_coin(string coin_name,string coin_type)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/"+ coin_name);
                JObject coin_json = JObject.Parse(json);
                return coin_json["data"][coin_type].ToString();
            }
        }
    }
    
    class Coin_BTC
    {
       //public MainWindow frm = new MainWindow();

        public string get_coin(string coin_name, MainWindow frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                frm.t3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString())+ Convert.ToDouble(coin_json["data"]["max_price"].ToString()))/2) + " won";
                frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";               
                //frm.t7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " won";
                //frm.v1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_1day"].ToString())) + " " + coin_name + " ";
                //frm.v2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_7day"].ToString())) + " " + coin_name + " ";

                using (WebClient wc2 = new WebClient())
                {
                    string json2 = wc2.DownloadString("https://earthquake.kr:23490/query/KRWUSD");
                    JObject jjson = JObject.Parse(json2);
                    frm.usd01.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " $";
                    frm.usd02.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " $";
                    frm.usd03.Text = String.Format("{0:#,###.##}", ((Convert.ToDouble(coin_json["data"]["min_price"].ToString())+ Convert.ToDouble(coin_json["data"]["max_price"].ToString()))/2) * Convert.ToDouble(jjson["KRWUSD"][0].ToString())) + " $";
                    frm.usd04.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " $";
                    frm.usd05.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " $";
                    //frm.usd06.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " $";
                    
                }
                //frm.usd07.Text = coin_json["data"]["fluctate_rate_24H"].ToString() + " %";
                //frm.t7_2.Text= coin_json["data"]["24H_fluctate_rate"].ToString() + " %";

                return coin_json["data"]["date"].ToString();
            }
        }
    }
    class Coin_ETH
    {
        //public MainWindow frm = new MainWindow();

        public string get_coin(string coin_name, MainWindow frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                frm.t3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                //frm.t7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " won";
                //frm.v1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_1day"].ToString())) + " " + coin_name + " ";
                //frm.v2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_7day"].ToString())) + " " + coin_name + " ";

                using (WebClient wc2 = new WebClient())
                {
                    string json2 = wc2.DownloadString("https://earthquake.kr:23490/query/KRWUSD");
                    JObject jjson = JObject.Parse(json2);
                    frm.usd01.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " $";
                    frm.usd02.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " $";
                    frm.usd03.Text = String.Format("{0:#,###.##}", ((Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) * Convert.ToDouble(jjson["KRWUSD"][0].ToString())) + " $";
                    frm.usd04.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " $";
                    frm.usd05.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " $";
                    //frm.usd06.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " $";

                }
                //frm.usd07.Text = coin_json["data"]["fluctate_rate_24H"].ToString() + " %";
                //frm.t7_2.Text= coin_json["data"]["24H_fluctate_rate"].ToString() + " %";

                return coin_json["data"]["date"].ToString();
            }
        }
    }
    class Coin_XPR
    {
        //public MainWindow frm = new MainWindow();

        public string get_coin(string coin_name, MainWindow frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                frm.t3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                //frm.t7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " won";
                //frm.v1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_1day"].ToString())) + " " + coin_name + " ";
                //frm.v2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_7day"].ToString())) + " " + coin_name + " ";

                using (WebClient wc2 = new WebClient())
                {
                    string json2 = wc2.DownloadString("https://earthquake.kr:23490/query/KRWUSD");
                    JObject jjson = JObject.Parse(json2);
                    frm.usd01.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " $";
                    frm.usd02.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " $";
                    frm.usd03.Text = String.Format("{0:#,###.##}", ((Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) * Convert.ToDouble(jjson["KRWUSD"][0].ToString())) + " $";
                    frm.usd04.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " $";
                    frm.usd05.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " $";
                    //frm.usd06.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " $";

                }
                //frm.usd07.Text = coin_json["data"]["fluctate_rate_24H"].ToString() + " %";
                //frm.t7_2.Text= coin_json["data"]["24H_fluctate_rate"].ToString() + " %";

                return coin_json["data"]["date"].ToString();
            }
        }
    }

    class Coin_EOS
    {
        //public MainWindow frm = new MainWindow();

        public string get_coin(string coin_name, MainWindow frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                frm.t3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                //frm.t7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " won";
                //frm.v1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_1day"].ToString())) + " " + coin_name + " ";
                //frm.v2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_7day"].ToString())) + " " + coin_name + " ";

                using (WebClient wc2 = new WebClient())
                {
                    string json2 = wc2.DownloadString("https://earthquake.kr:23490/query/KRWUSD");
                    JObject jjson = JObject.Parse(json2);
                    frm.usd01.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " $";
                    frm.usd02.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " $";
                    frm.usd03.Text = String.Format("{0:#,###.##}", ((Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) * Convert.ToDouble(jjson["KRWUSD"][0].ToString())) + " $";
                    frm.usd04.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " $";
                    frm.usd05.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " $";
                    //frm.usd06.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " $";

                }
                //frm.usd07.Text = coin_json["data"]["fluctate_rate_24H"].ToString() + " %";
                //frm.t7_2.Text= coin_json["data"]["24H_fluctate_rate"].ToString() + " %";

                return coin_json["data"]["date"].ToString();
            }
        }
    }

    class Coin_BCH
    {
        //public MainWindow frm = new MainWindow();

        public string get_coin(string coin_name, MainWindow frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                frm.t3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                //frm.t7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " won";
                //frm.v1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_1day"].ToString())) + " " + coin_name + " ";
                //frm.v2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_7day"].ToString())) + " " + coin_name + " ";

                using (WebClient wc2 = new WebClient())
                {
                    string json2 = wc2.DownloadString("https://earthquake.kr:23490/query/KRWUSD");
                    JObject jjson = JObject.Parse(json2);
                    frm.usd01.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " $";
                    frm.usd02.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " $";
                    frm.usd03.Text = String.Format("{0:#,###.##}", ((Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) * Convert.ToDouble(jjson["KRWUSD"][0].ToString())) + " $";
                    frm.usd04.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " $";
                    frm.usd05.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " $";
                    //frm.usd06.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " $";

                }
                //frm.usd07.Text = coin_json["data"]["fluctate_rate_24H"].ToString() + " %";
                //frm.t7_2.Text= coin_json["data"]["24H_fluctate_rate"].ToString() + " %";
                
                return coin_json["data"]["date"].ToString();
            }
        }
    }

    class Coin_ETC
    {
        //public MainWindow frm = new MainWindow();
        public string get_coin(string coin_name, MainWindow frm)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                JObject coin_json = JObject.Parse(json);

                frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                frm.t3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                //frm.t7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " won";
                //frm.v1.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_1day"].ToString())) + " " + coin_name + " ";
                //frm.v2.Text = String.Format("{0:#,###.####}", Convert.ToDouble(coin_json["data"]["volume_7day"].ToString())) + " " + coin_name + " ";

                using (WebClient wc2 = new WebClient())
                {
                    string json2 = wc2.DownloadString("https://earthquake.kr:23490/query/KRWUSD");
                    JObject jjson = JObject.Parse(json2);
                    frm.usd01.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " $";
                    frm.usd02.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " $";
                    frm.usd03.Text = String.Format("{0:#,###.##}", ((Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) * Convert.ToDouble(jjson["KRWUSD"][0].ToString())) + " $";
                    frm.usd04.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " $";
                    frm.usd05.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " $";
                    //frm.usd06.Text = String.Format("{0:#,###.##}", Convert.ToDouble(jjson["KRWUSD"][0].ToString()) * Convert.ToInt32(coin_json["data"]["fluctate_24H"].ToString())) + " $";

                }
                //frm.usd07.Text = coin_json["data"]["fluctate_rate_24H"].ToString() + " %";
                //frm.t7_2.Text= coin_json["data"]["24H_fluctate_rate"].ToString() + " %";

                return coin_json["data"]["date"].ToString();
            }
        }
        
    }

}
