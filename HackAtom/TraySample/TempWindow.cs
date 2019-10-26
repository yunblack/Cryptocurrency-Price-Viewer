using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WatchDocks
{
    public partial class TempWindow : MetroFramework.Forms.MetroForm
    {
        public TempWindow()
        {
            InitializeComponent();
        }

        private void TempWindow_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
