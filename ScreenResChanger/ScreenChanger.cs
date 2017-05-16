using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenResChanger
{
    class ScreenChanger
    {
        #region imports

        //DISP_CHANGE_SUCCESSFUL = 0: Indicates that the function succeeded.
        //DISP_CHANGE_BADMODE = -2: The graphics mode is not supported.
        //DISP_CHANGE_FAILED = -1: The display driver failed the specified graphics mode.
        //DISP_CHANGE_RESTART = 1: The computer must be restarted for the graphics mode to work.
        //ENUM_CURRENT_SETTINGS = -1: Retrieves the current display mode.
        //ENUM_REGISTRY_SETTINGS = -2: Retrieves the current display mode stored in the Registry.
        [Flags()]
        public enum ChangeDisplaySettingsFlags : uint
        {
            CDS_NONE = 0,
            CDS_UPDATEREGISTRY = 0x00000001,
            CDS_TEST = 0x00000002,
            CDS_FULLSCREEN = 0x00000004,
            CDS_GLOBAL = 0x00000008,
            CDS_SET_PRIMARY = 0x00000010,
            CDS_VIDEOPARAMETERS = 0x00000020,
            CDS_ENABLE_UNSAFE_MODES = 0x00000100,
            CDS_DISABLE_UNSAFE_MODES = 0x00000200,
            CDS_RESET = 0x40000000,
            CDS_RESET_EX = 0x20000000,
            CDS_NORESET = 0x10000000
        }



        public static void EnumerateSupportedModes()
        {
            DEVMODE mode = new DEVMODE();
            mode.dmSize = (ushort)Marshal.SizeOf(mode);

            int modeIndex = 0; // 0 = The first mode

            Console.WriteLine("Supported Modes:");

            while (EnumDisplaySettings(null,
                modeIndex,
                ref mode) == true) // Mode found
            {
                Console.WriteLine("\t" +
                    "{0} by {1}, " +
                    "{2} bit, " +
                    "{3} degrees, " +
                    "{4} hertz",
                    mode.dmPelsWidth,
                    mode.dmPelsHeight,
                    mode.dmBitsPerPel,
                    mode.dmDisplayOrientation * 90,
                    mode.dmDisplayFrequency);

                modeIndex++; // The next mode
            }
        }
        public static byte[] ToLPTStr(string str)
        {
            var lptArray = new byte[str.Length + 1];

            var index = 0;
            foreach (char c in str.ToCharArray())
                lptArray[index++] = Convert.ToByte(c);

            lptArray[index] = Convert.ToByte('\0');

            return lptArray;
        }

        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern Boolean EnumDisplaySettings(
           byte[] lpszDeviceName,
           [param: MarshalAs(UnmanagedType.U4)]
           int iModeNum,
           [In, Out]
           ref DEVMODE lpDevMode);

        [StructLayout(LayoutKind.Sequential,
            CharSet = CharSet.Ansi)]
        public struct DEVMODE
        {
            // You can define the following constant
            // but OUTSIDE the structure because you know
            // that size and layout of the structure
            // is very important
            // CCHDEVICENAME = 32 = 0x50
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;
            // In addition you can define the last character array
            // as following:
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            //public Char[] dmDeviceName;

            // After the 32-bytes array
            [MarshalAs(UnmanagedType.U2)]
            public UInt16 dmSpecVersion;

            [MarshalAs(UnmanagedType.U2)]
            public UInt16 dmDriverVersion;

            [MarshalAs(UnmanagedType.U2)]
            public UInt16 dmSize;

            [MarshalAs(UnmanagedType.U2)]
            public UInt16 dmDriverExtra;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmFields;

            public POINTL dmPosition;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmDisplayOrientation;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmDisplayFixedOutput;

            [MarshalAs(UnmanagedType.I2)]
            public Int16 dmColor;

            [MarshalAs(UnmanagedType.I2)]
            public Int16 dmDuplex;

            [MarshalAs(UnmanagedType.I2)]
            public Int16 dmYResolution;

            [MarshalAs(UnmanagedType.I2)]
            public Int16 dmTTOption;

            [MarshalAs(UnmanagedType.I2)]
            public Int16 dmCollate;

            // CCHDEVICENAME = 32 = 0x50
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;
            // Also can be defined as
            //[MarshalAs(UnmanagedType.ByValArray,
            //    SizeConst = 32, ArraySubType = UnmanagedType.U1)]
            //public Byte[] dmFormName;

            [MarshalAs(UnmanagedType.U2)]
            public UInt16 dmLogPixels;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmBitsPerPel;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmPelsWidth;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmPelsHeight;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmDisplayFlags;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmDisplayFrequency;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmICMMethod;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmICMIntent;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmMediaType;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmDitherType;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmReserved1;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmReserved2;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmPanningWidth;

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dmPanningHeight;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTL
        {
            [MarshalAs(UnmanagedType.I4)]
            public int x;
            [MarshalAs(UnmanagedType.I4)]
            public int y;
        }



        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int ChangeDisplaySettings(
            [In, Out]
            ref DEVMODE lpDevMode,
            [param: MarshalAs(UnmanagedType.U4)]
            uint dwflags);

        [DllImport("user32.dll")]
        internal static extern int ChangeDisplaySettingsEx(
          byte[] lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd,
          uint dwflags, IntPtr lParam);

        public static void ChangeDisplaySettings
        (int width, int height, int bitCount)
        {
            DEVMODE originalMode = new DEVMODE();
            originalMode.dmSize =
            (ushort)Marshal.SizeOf(originalMode);

            // Retrieving current settings
            // to edit them
            EnumDisplaySettings(ToLPTStr("\\\\.\\DISPLAY1"),
                -1,
                ref originalMode);

            // Making a copy of the current settings
            // to allow reseting to the original mode
            DEVMODE newMode = originalMode;

            // Changing the settings
            newMode.dmPelsWidth = (uint)width;
            newMode.dmPelsHeight = (uint)height;
            newMode.dmBitsPerPel = (uint)bitCount;

            // Capturing the operation result
            int result =
            ChangeDisplaySettings(ref newMode, 0);

            if (result == 0)
            {
                Console.WriteLine("Succeeded.\n");

                //// Inspecting the new mode
                //GetCurrentSettings();

                //Console.WriteLine();

                //// Waiting for seeing the results
                //Console.ReadKey(true);

                //ChangeDisplaySettings(ref originalMode, 0);
            }
            else if (result == -2)
                Console.WriteLine("Mode not supported.");
            else if (result == 1)
                Console.WriteLine("Restart required.");
            else
                Console.WriteLine("Failed. Error code = {0}", result);
        }



        #endregion

        public static void setDisplayRes(string displayName, screenRes settings)
        {
            DEVMODE NSpecs = new DEVMODE();
            int Nndx = getDMbySpecs(settings.Height, settings.Width, settings.DisplayFrequency, 0, 0, ref NSpecs, displayName);

            //Note that this function sets both the DEVMODE to the selected display mode and returns the index value of this display mode. It returns -1 if it fails (-1 is the value of ENUM_CURRENT_SETTINGS), and sets the DEVMODE to the current display mode.
            if (Nndx == -1)
            {
                Console.WriteLine("Could not find specified mode");
                return;
            }
           
            bool test = setDisplayMode(ref NSpecs, displayName);

        }

        //static bool setDisplayMode(int i)
        //{
        //    DEVMODE DM = new DEVMODE();
        //    DM.dmSize = (ushort)Marshal.SizeOf(DM);
        //    EnumDisplaySettings(ToLPTStr("\\\\.\\DISPLAY1"), i, ref DM);
        //    bool test = ChangeDisplaySettings(ref DM, (uint)ChangeDisplaySettingsFlags.CDS_UPDATEREGISTRY) == 0;
        //    test &= ChangeDisplaySettings(ref DM, (uint)ChangeDisplaySettingsFlags.CDS_TEST) == 0;
        //    if (test)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        static bool setDisplayMode(ref DEVMODE DM, string displayName)
        {
            DEVMODE d = new DEVMODE();
           int test =  ChangeDisplaySettingsEx(ToLPTStr(displayName), ref DM, (IntPtr)null, 0, (IntPtr)null);
            ChangeDisplaySettingsEx(null, ref d, (IntPtr)null, 0, (IntPtr)null);
            //bool test = ChangeDisplaySettings(ref DM, (uint)ChangeDisplaySettingsFlags.CDS_TEST) == 0;
            //test &= ChangeDisplaySettings(ref DM, (uint)ChangeDisplaySettingsFlags.CDS_UPDATEREGISTRY) == 0;
            if (test > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int getDMbySpecs(int H, int W, int F, int G, int B, ref DEVMODE DM, string displayName)
        {
            DM.dmSize = (ushort)Marshal.SizeOf(DM);
            DEVMODE SelDM = new DEVMODE();
            SelDM.dmSize = (ushort)Marshal.SizeOf(SelDM);
            int iOMI = 0;
            int i = 0;

            for (iOMI = 0; !(EnumDisplaySettings(ToLPTStr(displayName), iOMI, ref SelDM) == false); iOMI++)
            {
                Console.WriteLine(
                    "F = " + SelDM.dmDisplayFrequency.ToString() +
                    " G = " + SelDM.dmDisplayFlags.ToString() +
                    " B = " + SelDM.dmBitsPerPel.ToString() +
                    " H = " + SelDM.dmPelsHeight.ToString() +
                    " W = " + SelDM.dmPelsWidth.ToString()
                    );
                if (H == SelDM.dmPelsHeight && W == SelDM.dmPelsWidth && F == SelDM.dmDisplayFrequency)
                {
                    B = (int)SelDM.dmBitsPerPel;
                    G = (int)SelDM.dmDisplayFlags;
                    break;
                }
                Console.WriteLine();
                if ((B == -1 || B == SelDM.dmBitsPerPel) && (H == -1 || H == SelDM.dmPelsHeight) && (W == -1 || W == SelDM.dmPelsWidth) && (G == -1 || G == SelDM.dmDisplayFlags) && (F == -1 || F == SelDM.dmDisplayFrequency))

                    break;
            }
            if (EnumDisplaySettings(ToLPTStr(displayName), iOMI, ref DM) == false)
            {
                iOMI = -1;
                //getCurrentRes(ref DM, null);
            }
            return iOMI;
        }


        public static List<screenRes> getProfiles(string displayName)
        {
            List<screenRes> returnList = new List<screenRes>();
            //Screen curScreen;
            //foreach (Screen s in Screen.AllScreens)
            //{
            //    if (s.DeviceName.Equals(displayName))
            //    {
            //        curScreen = s;
            //        break;
            //    }
            //}


            DEVMODE OSpecs = new DEVMODE();
            //getCurrentRes(ref OSpecs, null);


            OSpecs.dmSize = (ushort)Marshal.SizeOf(OSpecs);
            DEVMODE SelDM = new DEVMODE();
            SelDM.dmSize = (ushort)Marshal.SizeOf(SelDM);
            int iOMI = 0;





            for (iOMI = 0; !(EnumDisplaySettings(ToLPTStr(displayName), iOMI, ref SelDM) == false); iOMI++)
            {
                returnList.Add(new screenRes((int)SelDM.dmPelsHeight, (int)SelDM.dmPelsWidth, (int)SelDM.dmDisplayFrequency));
                Console.WriteLine(
                    "F = " + SelDM.dmDisplayFrequency.ToString() +
                    " G = " + SelDM.dmDisplayFlags.ToString() +
                    " B = " + SelDM.dmBitsPerPel.ToString() +
                    " H = " + SelDM.dmPelsHeight.ToString() +
                    " W = " + SelDM.dmPelsWidth.ToString()
                    );


            }
            return returnList;
        }

        public class screenRes
        {
            public int Height;
            public int Width;
            public int DisplayFrequency;

            //only used for loading from file
            public string DisplayName;
             public screenRes(int height, int width, int displayFrequency)
            {
                Height = height;
                Width = width;
                DisplayFrequency = displayFrequency;
            }
        }
    }

}
