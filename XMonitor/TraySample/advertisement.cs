using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Planet;
using System.Net;
using System.IO;

namespace WatchDocks
{
    class advertisement
    {
        public void load(adwindows frm)
        {
            Bitmap images = WebImageView("https://tistory4.daumcdn.net/tistory/2397123/skin/images/adv01.jpg");
            frm.pictureBox1.Image = images;
        }
        public Bitmap WebImageView(string URL)
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
