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
    class main_view_bitcoin
    {
        public void loadview(MainWindow frm)
        {
            view_bitcoin(frm);
        }
        public void view_bitcoin(MainWindow frm)
        {
            Coin coin = new Coin();
            frm.t1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin.get_coin("BTC", "opening_price"))) + " won";
            frm.t2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin.get_coin("BTC", "closing_price"))) + " won";
            frm.t3.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin.get_coin("BTC", "average_price"))) + " won";
            frm.t4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin.get_coin("BTC", "max_price"))) + " won";
            frm.t5.Text = String.Format("{0:#,###}", Convert.ToInt32(coin.get_coin("BTC", "min_price"))) + " won";

            frm.t8.Text = DateTime.Now.ToString("yyyy : MM : dd : HH : mm : ss") + "";
            frm.t9.Text = String.Format("{0:#,###}", coin.get_coin("BTC", "date"));
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
}
