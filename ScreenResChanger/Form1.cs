using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenResChanger
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            int i = 0;
            foreach (var screen in Screen.AllScreens)
            {
                // For each screen, add the screen properties to a list box.
                dgvScreens.Rows.Add(i, screen.DeviceName, screen.Bounds.Size.Width,  screen.Bounds.Size.Height);
              
                i++;
                
            }
            reloadSavedProfiles();
        }

        private  void reloadSavedProfiles()
        {
            dgvSavedProfiles.Rows.Clear();
            List<ScreenChanger.screenRes> savedProfiles = DataHandeler.loadAllFromFile();
            foreach (ScreenChanger.screenRes item in savedProfiles)
            {
                dgvSavedProfiles.Rows.Add(item.profileNumber, item.DisplayName, item.Width, item.Height, item.DisplayFrequency);
            }
        }

        private void btnGetProfiles_Click(object sender, EventArgs e)
        {

            Screen Srn = Screen.AllScreens[(int)dgvScreens.SelectedRows[0].Cells[0].Value];
            int i = 0;
            dgvProfiles.Rows.Clear();
            lblScreenName.Text =(string) dgvScreens.SelectedRows[0].Cells[1].Value;
            foreach (ScreenChanger.screenRes item in ScreenChanger.getProfiles(Srn.DeviceName))
            {
                dgvProfiles.Rows.Add(i,  item.Width, item.Height, item.DisplayFrequency);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblScreenName.Text.Equals("None Set"))
            {
                MessageBox.Show("No screen set");
                return;
            }
            ScreenChanger.screenRes s = new ScreenChanger.screenRes(
                (int)dgvProfiles.SelectedRows[0].Cells[2].Value,
          (int)dgvProfiles.SelectedRows[0].Cells[1].Value,
          (int)dgvProfiles.SelectedRows[0].Cells[3].Value
                );

            ScreenChanger.setDisplayRes(lblScreenName.Text, s);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ScreenChanger.screenRes s = new ScreenChanger.screenRes(
                (int)dgvProfiles.SelectedRows[0].Cells[2].Value,
          (int)dgvProfiles.SelectedRows[0].Cells[1].Value,
          (int)dgvProfiles.SelectedRows[0].Cells[3].Value
                );
            s.DisplayName = lblScreenName.Text;
            DataHandeler.writeProfile((int)dgvSavedProfiles.SelectedRows[0].Cells[0].Value, s);
            reloadSavedProfiles();
        }
        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            ScreenChanger.screenRes s = new ScreenChanger.screenRes(
               (int)dgvProfiles.SelectedRows[0].Cells[2].Value,
         (int)dgvProfiles.SelectedRows[0].Cells[1].Value,
         (int)dgvProfiles.SelectedRows[0].Cells[3].Value
               );
            s.DisplayName = lblScreenName.Text;
            DataHandeler.writeProfile(-1, s);
            reloadSavedProfiles();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}

