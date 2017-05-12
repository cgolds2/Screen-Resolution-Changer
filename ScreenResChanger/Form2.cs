//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ScreenResChanger
//{
//    public partial class Form2 : Form
//    {
//        public Form2()
//        {
//            InitializeComponent();
//            int selB, selG, selF, selH, selW;
           
//            DEVMODE OSpecs = new DEVMODE();
//            getCurrentRes(ref OSpecs);
//            int Ondx = getDMbySpecs(OSpecs.dmPelsHeight, OSpecs.dmPelsWidth, OSpecs.dmDisplayFrequency, OSpecs.dmDisplayFlags, OSpecs.dmBitsPerPel, ref OSpecs);
//            Screen Srn = Screen.PrimaryScreen;
//            Console.WriteLine("Current res is " + OSpecs.dmPelsHeight + " by " + OSpecs.dmPelsWidth + "\n");
//            DEVMODE NSpecs = new DEVMODE();
//            int Nndx = getDMbySpecs(selH, selW, selF, selG, selB, ref NSpecs);
//            //Note that this function sets both the DEVMODE to the selected display mode and returns the index value of this display mode. It returns -1 if it fails (-1 is the value of ENUM_CURRENT_SETTINGS), and sets the DEVMODE to the current display mode.
//            if (Nndx == -1)
//            {
//                Console.WriteLine("Could not find specified mode");
//            }
//            else if (setDisplayMode(ref NSpecs) || setDisplayMode(Nndx)) //This is just to illustrate both ways of doing it. One or the other may be more convenient (ie, the latter if you are getting this from a file, the former if you already have the DEVMODE in your program, etc.)
//            {
//                //reset display mode to original after waiting long enough to see it changed
//                Console.WriteLine("Successful change. Waiting 4 seconds.");
//                Thread.Sleep(4000);
//                if (setDisplayMode(ref OSpecs) || setDisplayMode(Ondx))
//                {
//                    //success!
//                    Console.WriteLine("Mode reversion succeeded.");
//                }
//                else
//                {
//                    Console.WriteLine("Mode reversion failed. Manual reset required.");
//                }
//            }
//            else
//            {
//                //return
//                Console.WriteLine("Resolution change failed. Aborting");
//            }
//        }
//        static bool setDisplayMode(int i)
//        {
//            DEVMODE DM = new DEVMODE();
//            DM.dmSize = (short)Marshal.SizeOf(DM);
//            User32.EnumDisplaySettings(null, i, ref DM);
//            if (User32.ChangeDisplaySettings(ref DM, User32.CDS_TEST) == 0 && User32.ChangeDisplaySettings(ref DM, User32.CDS_UPDATEREGISTRY) == 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        static bool setDisplayMode(ref DEVMODE DM)
//        {
//            if (User32.ChangeDisplaySettings(ref DM, User32.CDS_TEST) == 0 && User32.ChangeDisplaySettings(ref DM, User32.CDS_UPDATEREGISTRY) == 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        static int getDMbySpecs(int H, int W, int F, int G, int B, ref DEVMODE DM)
//        {
//            DM.dmSize = (short)Marshal.SizeOf(DM);
//            DEVMODE SelDM = new DEVMODE();
//            SelDM.dmSize = (short)Marshal.SizeOf(SelDM);
//            int iOMI = 0;
//            for (iOMI = 0; User32.EnumDisplaySettings(null, iOMI, ref SelDM) != 0; iOMI++)
//            {
//                if ((B == -1 || B == SelDM.dmBitsPerPel) && (H == -1 || H == SelDM.dmPelsHeight) && (W == -1 || W == SelDM.dmPelsWidth) && (G == -1 || G == SelDM.dmDisplayFlags) && (F == -1 || F == SelDM.dmDisplayFrequency))

//                    break;
//            }
//            if (User32.EnumDisplaySettings(null, iOMI, ref DM) == 0)
//            {
//                iOMI = -1;
//                getCurrentRes(ref DM);
//            }
//            return iOMI;
//        }
//        static void getCurrentRes(ref DEVMODE dm)
//        {
//            dm = new DEVMODE();
//            dm.dmSize = (short)Marshal.SizeOf(dm);
//            User32.EnumDisplaySettings(null, User32.ENUM_CURRENT_SETTINGS, ref dm);
//            return;
//        }
//    }
//}
