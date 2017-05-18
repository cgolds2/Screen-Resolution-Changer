using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenResChanger
{
    class DataHandeler
    {
        static string fileName = "";
        public static void changeScreenToProfile(int profileNumber)
        {
            ScreenChanger.screenRes s = loadFromFile(profileNumber);
            if (s == null)
            {
                Console.Write("Could not find profile");
                return;
            }
            ScreenChanger.setDisplayRes(s.DisplayName, s);
        }

        
        public static ScreenChanger.screenRes loadFromFile(int profileNumber)
        {
            ScreenChanger.screenRes returnRes = null;
            string[] lines = System.IO.File.ReadAllLines(fileName);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Equals("//" + profileNumber.ToString()))
                {

                    returnRes.DisplayName = lines[i + 1];
                    returnRes.Width = Int32.Parse(lines[i + 2]);
                    returnRes.Height = Int32.Parse(lines[i + 3]);
                    returnRes.DisplayFrequency = Int32.Parse(lines[i + 4]);
                    break;
                }
            }

            return returnRes;
        }

        public static List<ScreenChanger.screenRes> loadAllFromFile()
        {
            List<ScreenChanger.screenRes> returnRes = new List<ScreenChanger.screenRes>();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("//"))
                {
                    ScreenChanger.screenRes profile = new ScreenChanger.screenRes();
                    profile.profileNumber = Int32.Parse(lines[i].Replace("//", ""));
                    profile.DisplayName = lines[i + 1];
                    profile.Width = Int32.Parse(lines[i + 2]);
                    profile.Height = Int32.Parse(lines[i + 3]);
                    profile.DisplayFrequency = Int32.Parse(lines[i + 4]);
                    returnRes.Add(profile);
                }
            }
            return returnRes;
        }

        public static void writeProfile(int number, ScreenChanger.screenRes screenProfile)
        {
            int Largest = 0;
            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<string> lineList = new List<string>(lines);
            bool found = false;
            for (int i = 0; i < lineList.Count; i++)
            {
                if (lineList[i].Contains("//"))
                {
                    try
                    {
                        string test = lineList[i].Replace("//", "");
                        test.Trim();
                        Largest = Int32.Parse(test);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

                if (!found)
                {
                    string confer = "//" + number.ToString();
                    string line = lineList[i];
                    if (line.Equals(confer))
                    {
                        lineList.Insert(i + 1, screenProfile.DisplayFrequency.ToString());
                        lineList.Insert(i + 1, screenProfile.Height.ToString());
                        lineList.Insert(i + 1, screenProfile.Width.ToString());
                        lineList.Insert(i + 1, screenProfile.DisplayName.ToString());
                        i += 4;
                        found = true;
                    }
                }
                else
                {
                    if (lineList[i].Equals("//" + (number + 1).ToString()))
                    {
                        break;
                    }
                    else
                    {
                        lineList.RemoveAt(i);
                        i--;
                    }
                }

            }
            if (!found)
            {
                //if the number was never found, it needs to be added
                if(number == -1)
                {
                    //if number is -1, that is the programmer saying add to largest
                    number = Largest + 1;
                }
                lineList.Add("//" + number.ToString());
                lineList.Add(screenProfile.DisplayName.ToString());
                lineList.Add(screenProfile.Width.ToString());
                lineList.Add(screenProfile.Height.ToString());
                lineList.Add(screenProfile.DisplayFrequency.ToString());


            }

            lines = lineList.ToArray();
            System.IO.File.WriteAllLines(fileName, lines);

        }
    }
}
