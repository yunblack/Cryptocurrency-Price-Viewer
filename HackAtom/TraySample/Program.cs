using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using X_Monitor_II;

namespace TraySample
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            //Application.Run(new Rate());
        }
    }
}
