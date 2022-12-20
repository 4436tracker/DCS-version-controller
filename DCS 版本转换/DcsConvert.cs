using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCS_版本转换
{
    public partial class DCSConvert : Form
    {

        string dcsPath;
        public DCSConvert()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            try
            {
                RegistryKey hkcu = Registry.CurrentUser;
                RegistryKey software = hkcu.OpenSubKey("Software", true);
                RegistryKey ed = software.OpenSubKey("Eagle Dynamics", true);
                RegistryKey dcs = ed.OpenSubKey("DCS World OpenBeta", true);
                if (dcs == null)
                {
                    dcs = ed.OpenSubKey("DCS World", true);
                }
                dcsPath = dcs.GetValue("Path").ToString();
            }catch
            {
                MessageBox.Show("没找到官网版DCS", "错误");
                this.Close();
            }
            
        }

        private void buttonSelectDcsPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "选择DCS主程序";
            openFileDialog.Filter = "DCS.exe|DCS.exe";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                buttonStable.Enabled = true;
                buttonRelease.Enabled = true;
                buttonCustomVersion.Enabled = true;
                buttonFix.Enabled = true;
                textBoxCustomVersion.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void buttonStable_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = dcsPath + "\\bin\\DCS_updater.exe";
            process.StartInfo.Arguments = "update @openbeta";
            process.Start();
        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = dcsPath + "\\bin\\DCS_updater.exe";
            process.StartInfo.Arguments = "update @release";
            process.Start();
        }

        private void buttonCustomVersion_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = dcsPath + "\\bin\\DCS_updater.exe";
            process.StartInfo.Arguments = "update " + textBoxCustomVersion.Text;
            process.Start();
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = dcsPath + "\\bin\\DCS_updater.exe";
            process.StartInfo.Arguments = "repair";
            process.Start();
        }
    }
}

