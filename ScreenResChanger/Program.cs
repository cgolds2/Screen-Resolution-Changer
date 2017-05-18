using System;
using System.Collections.Generic;
using System.IO;
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
            //MessageBox.Show("parameter count = " + args.Length.ToString());
            if (!File.Exists(DataHandeler.fileName))
            {
                File.Create(DataHandeler.fileName).Dispose();
            }
            if (args.Count() == 0) { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            }
            else
            {
                List<ScreenChanger.screenRes> profile = DataHandeler.loadAllFromFile(); ;
                foreach (string item in args)
                {
                    //MessageBox.Show(item);
                    int number = Int32.Parse(item.Trim());
                    foreach (ScreenChanger.screenRes pro in profile)
                    {
                        if(number == pro.profileNumber)
                        {
                            //MessageBox.Show(pro.DisplayName);
                            ScreenChanger.setDisplayRes(pro.DisplayName, pro);
                            break;
                        }
                    }
                  // ScreenChanger.screenRes s =  DataHandeler.loadFromFile();

                }
                Application.Exit();
            }
        }
    }
}
