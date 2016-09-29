using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Sharp Mail Oder - Sales Bonus	
// Created by David McNiven
// Student # 200330143	
// Created on September 30th 2016	
// App description

namespace Sharp_Mail_Order___Sales_Bonus
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
            Application.Run(new Form1());
        }
    }
}
