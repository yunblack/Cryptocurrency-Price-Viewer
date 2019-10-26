using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Timers;
using Planet;
using TraySample;
using WatchDocks;
using System.Data.OleDb;
using System.IO;

namespace WatchDocks
{
    public partial class ExpertViewMode : MetroFramework.Forms.MetroForm
    {
        public ExpertViewMode()
        {
            InitializeComponent();
        }

        private void ExpertViewMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        class Coin_BTC
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public string get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    frm.a1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.a2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.a3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.a4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    return coin_json["data"]["date"].ToString();
                }
            }
        }
        class Coin_ETH
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    

                    frm.b1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.b2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.b3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.b4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.b6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.b7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.b8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.b9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }
        class Coin_XPR
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);


                    frm.c1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.c2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.c3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.c4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.c6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.c7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.c8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.c9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }

        class Coin_EOS
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    frm.d1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.d2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.d3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.d4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.d6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.d7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.d8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.d9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    // return coin_json["data"]["date"].ToString();
                }
            }
        }

        class Coin_BCH
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);


                   

                    frm.e1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.e2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.e3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.e4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.e6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.e7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.e8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.e9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }

        class Coin_ETC
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                   

                    frm.f1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.f2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.f3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.f4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.f6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.f7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.f8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.f9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }

        class Coin_QTUM
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    

                    frm.g1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.g2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.g3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.g4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.g6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.g7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.g8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.g9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }

        class Coin_DASH
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);


                    frm.h1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.h2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    //frm.h3.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin_json["data"]["average_price"].ToString())) + " won";
                    //frm.h4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";
                    
                    frm.h6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.h7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.h8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.h9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }
        /*
        class Coin_XMR
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) > 0)
                    {
                        frm.i4.ForeColor = Color.Aqua;
                    }
                    else if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) < 0)
                    {
                        frm.i4.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.i4.ForeColor = Color.White;
                        frm.i4.Text = "0";
                    }

                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) > 0)
                    {
                        frm.i5.ForeColor = Color.Turquoise;
                    }
                    else if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) < 0)
                    {
                        frm.i5.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.i5.ForeColor = Color.White;
                    }

                    frm.i1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.i2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.i3.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin_json["data"]["average_price"].ToString())) + " won";
                    frm.i4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";
                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) == 0)
                    {
                        frm.i4.Text = "0 won";
                    }
                    frm.i5.Text = coin_json["data"]["24H_fluctate_rate"].ToString() + " %";
                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) == 0)
                    {
                        frm.i5.Text = "0 %";
                    }
                    frm.i6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.i7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    frm.i8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    frm.i9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }

            */
        /*

        class Coin_BSV
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) > 0)
                    {
                        frm.j4.ForeColor = Color.Aqua;
                    }
                    else if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) < 0)
                    {
                        frm.j4.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.j4.ForeColor = Color.White;
                        frm.j4.Text = "0";
                    }

                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) > 0)
                    {
                        frm.j5.ForeColor = Color.Turquoise;
                    }
                    else if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) < 0)
                    {
                        frm.j5.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.j5.ForeColor = Color.White;
                    }

                    frm.j1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.j2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.j3.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin_json["data"]["average_price"].ToString())) + " won";
                    frm.j4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";
                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) == 0)
                    {
                        frm.j4.Text = "0 won";
                    }
                    frm.j5.Text = coin_json["data"]["24H_fluctate_rate"].ToString() + " %";
                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) == 0)
                    {
                        frm.j5.Text = "0 %";
                    }
                    frm.j6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.j7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    frm.j8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    frm.j9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }
        */
        /*
        class Coin_TRX
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) > 0)
                    {
                        frm.k4.ForeColor = Color.Aqua;
                    }
                    else if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) < 0)
                    {
                        frm.k4.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.k4.ForeColor = Color.White;
                        frm.k4.Text = "0";
                    }

                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) > 0)
                    {
                        frm.k5.ForeColor = Color.Turquoise;
                    }
                    else if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) < 0)
                    {
                        frm.k5.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.k5.ForeColor = Color.White;
                    }

                    frm.k1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.k2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.k3.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin_json["data"]["average_price"].ToString())) + " won";
                    frm.k4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";
                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) == 0)
                    {
                        frm.k4.Text = "0 won";
                    }
                    frm.k5.Text = coin_json["data"]["24H_fluctate_rate"].ToString() + " %";
                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) == 0)
                    {
                        frm.k5.Text = "0 %";
                    }
                    frm.k6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.k7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    frm.k8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    frm.k9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }
        */

        class Coin_XLM
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    frm.m1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.m2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.m3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.m4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.m6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.m7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //frm.m8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.m9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }

        class Coin_LTC
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);


                    frm.n1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.n2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.n3.Text = String.Format("{0:#,###.##}", (Convert.ToDouble(coin_json["data"]["min_price"].ToString()) + Convert.ToDouble(coin_json["data"]["max_price"].ToString())) / 2) + " won";
                    //frm.n4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";

                    frm.n6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.n7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    //.n8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    //frm.n9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }
/*
        class Coin_ADA
        {
            public ExpertViewMode frm = new ExpertViewMode();

            public void get_coin(string coin_name, ExpertViewMode frm)
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString("https://api.bithumb.com/public/ticker/" + coin_name);
                    JObject coin_json = JObject.Parse(json);

                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) > 0)
                    {
                        frm.o4.ForeColor = Color.Aqua;
                    }
                    else if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) < 0)
                    {
                        frm.o4.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.o4.ForeColor = Color.White;
                        frm.o4.Text = "0";
                    }

                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) > 0)
                    {
                        frm.o5.ForeColor = Color.Turquoise;
                    }
                    else if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) < 0)
                    {
                        frm.o5.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        frm.o5.ForeColor = Color.White;
                    }

                    frm.o1.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["min_price"].ToString())) + " won";
                    frm.o2.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["max_price"].ToString())) + " won";
                    frm.o3.Text = String.Format("{0:#,###.##}", Convert.ToDouble(coin_json["data"]["average_price"].ToString())) + " won";
                    frm.o4.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString())) + " won";
                    if (Convert.ToInt32(coin_json["data"]["24H_fluctate"].ToString()) == 0)
                    {
                        frm.o4.Text = "0 won";
                    }
                    frm.o5.Text = coin_json["data"]["24H_fluctate_rate"].ToString() + " %";
                    if (Convert.ToDouble(coin_json["data"]["24H_fluctate_rate"].ToString()) == 0)
                    {
                        frm.o5.Text = "0 %";
                    }
                    frm.o6.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["opening_price"].ToString())) + " won";
                    frm.o7.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["closing_price"].ToString())) + " won";
                    frm.o8.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["buy_price"].ToString())) + " won";
                    frm.o9.Text = String.Format("{0:#,###}", Convert.ToInt32(coin_json["data"]["sell_price"].ToString())) + " won";

                    //return coin_json["data"]["date"].ToString();
                }
            }
        }
        */
        private System.Timers.Timer aTimer;

        private void ExoertViewMode_Load(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer(3000);
            aTimer.Elapsed += viewrefresh;
            aTimer.Enabled = true;
        }

        private void viewrefresh(Object source, ElapsedEventArgs e)
        {
            Coin_BTC coin = new Coin_BTC();
            Coin_ETH coin2 = new Coin_ETH();
            Coin_XPR coin3 = new Coin_XPR();
            Coin_EOS coin4 = new Coin_EOS();
            Coin_BCH coin5 = new Coin_BCH();
            Coin_ETC coin6 = new Coin_ETC();

            //Coin_ADA coin7 = new Coin_ADA();
            Coin_XLM coin8 = new Coin_XLM();
            //Coin_TRX coin9 = new Coin_TRX();
            //Coin_BSV coin10 = new Coin_BSV();
            Coin_DASH coin11 = new Coin_DASH();
            Coin_LTC coin12 = new Coin_LTC();
            //Coin_XMR coin13 = new Coin_XMR();
            Coin_QTUM coin14 = new Coin_QTUM();

            t9.Text = String.Format("{0:#,###}", coin.get_coin("BTC", this));

            coin2.get_coin("ETH", this);
            coin3.get_coin("XRP", this);
            coin4.get_coin("EOS", this);
            coin5.get_coin("BCH", this);
            coin6.get_coin("ETC", this);

            coin12.get_coin("LTC", this);
            coin11.get_coin("DASH", this);
            coin14.get_coin("QTUM", this);
            coin8.get_coin("XLM", this);
            //coin9.get_coin("TRX", this);
            //coin7.get_coin("ADA", this);
            //coin10.get_coin("BSV", this);

        }

        private void setBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.Opacity = setBar.Value * 0.01;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void a5_Click(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void a8_Click(object sender, EventArgs e)
        {

        }

        private void b8_Click(object sender, EventArgs e)
        {

        }

        private void b9_Click(object sender, EventArgs e)
        {

        }
    }
}