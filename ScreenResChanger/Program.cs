using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenResChanger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Count() == 0) { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            }
            else
            {
                foreach (string item in args)
                {
                   ScreenChanger.screenRes s =  DataHandeler.loadFromFile(Int32.Parse(item));
                    ScreenChanger.setDisplayRes(s.DisplayName,s);
                }
                Application.Exit();
            }
        }
    }
}
