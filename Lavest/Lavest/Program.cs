using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lavest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmlogin());
           // Application.Run(new FrmVenda());
            //Application.Run(new FrmCompra());
        }
    }
}
