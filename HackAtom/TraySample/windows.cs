using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Planet
{
    public partial class windows : MetroFramework.Forms.MetroForm
    {
        public windows()
        {
            InitializeComponent();
        }

        private void windows_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
