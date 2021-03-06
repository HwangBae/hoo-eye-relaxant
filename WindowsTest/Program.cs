using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hoo.Relaxant.Test;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Hoo.Relaxant {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MonitorServiceForm());
            
        }
    }
}