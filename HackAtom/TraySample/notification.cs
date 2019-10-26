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

namespace Planet
{
    public partial class notification : MetroFramework.Forms.MetroForm
    {
        public notification()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.coindac.io/index");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
