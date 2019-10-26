using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Timers;
using System.Net.Http;
using Planet;
using WatchDocks;
using System.Data.OleDb;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace X_Monitor_II
{
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void Rate_Load(object sender, EventArgs e)
        {
            DropDownInit();

        }

        void DropDownInit()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("BTC", "비트코인");
            items.Add("XEM", "NEM");
            items.Add("ETH", "이더리움");
            items.Add("ETC", "이더리움 클래식");
            items.Add("QTUM", "퀀텀");
            items.Add("XRP", "리플");
            items.Add("EMC2", "아인스타이늄");
            items.Add("BCC", "비트코인캐시");
            items.Add("BTG", "비트코인골드");
            items.Add("XMR", "모네로");
            items.Add("LTC", "라이트코인");
            items.Add("DASH", "대시");
            items.Add("OMG", "오미세고");
            items.Add("VTC", "버트코인");
            items.Add("STORJ", "스토리지");
            items.Add("ARK", "아크");
            items.Add("LSK", "리스크");
            items.Add("ADA", "에이다");
            items.Add("SNT", "스테이터스네트워크토큰");
            items.Add("REP", "어거");
            items.Add("XLM", "스텔라루멘");
            items.Add("SBD", "스팀달러");
            items.Add("NEO", "네오");
            items.Add("STRAT", "스트라티스");

            ddlCoin.DataSource = new BindingSource(items, null);
            ddlCoin.DisplayMember = "Value";
            ddlCoin.ValueMember = "Key";

            items = new Dictionary<string, string>();
            items.Add("1", "1분");
            items.Add("3", "3분");
            items.Add("5", "5분");
            items.Add("10", "10분");
            items.Add("15", "15분");
            items.Add("30", "30분");
            items.Add("60", "1시간");
            items.Add("240", "4시간");
            items.Add("days", "1일");
            items.Add("weeks", "1주");
            items.Add("months", "1달");

            ddlTime.DataSource = new BindingSource(items, null);
            ddlTime.DisplayMember = "Value";
            ddlTime.ValueMember = "Key";
            ddlTime.SelectedValue = "days";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string requestUrl;
            int intCheck;
            string coin = ddlCoin.SelectedValue.ToString();
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
