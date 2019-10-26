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
    class main_ad
    {
        public void loadimage(MainWindow frm)
        {
            Bitmap images = WebImageView("https://tistory1.daumcdn.net/tistory/2397123/skin/images/adv02.jpg");
            
        }
        private Bitmap WebImageView(string URL)
        {
            try
            {
                WebClient Downloader = new WebClient();
                Stream ImageStream = Downloader.OpenRead(URL);
                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
                return DownloadImage;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
