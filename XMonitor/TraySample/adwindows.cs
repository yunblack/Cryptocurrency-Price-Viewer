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
    public partial class adwindows : MetroFramework.Forms.MetroForm
    {
        public adwindows()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    Rectangle workingArea = Screen.GetWorkingArea(this);
                    this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
                    return;
                }
            }
        }
        private void adtest001_Load(object sender, EventArgs e)
        {
            advertisement cs = new advertisement();
            cs.load(this);
        }
    }
}
