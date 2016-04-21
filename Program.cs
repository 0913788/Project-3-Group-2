using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Kickstart_Rotterdam__Real_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Checks for an internet connection; pings Google DNS
            var ping = new Pinger().Run("8.8.8.8");
            if (ping == false)
            {
                MessageBox.Show("(>-_-)>#   t(^.^t)          <(Y.Y)>  (>^#^<) \n-------------------         -------------------\n\n No internet access, the application will shutdown.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var t1 = Task.Factory.StartNew(()=>Application.Run(new Splash_Screen()));
            Task.WaitAll(t1);

            var program = new Main_Program();
            program.Run();
        }
    }
}
