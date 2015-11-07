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

namespace Setup.exe.GameForms
{
    public partial class Form_Finish : GameForm
    {
        public Form_Finish()
        {
            InitializeComponent();
	        if (InstallationSetting.SelectedComponents[0]== "ASK Toolbar")
	        {
		        label_description.Text = "Successfully installed ASK toolbar! \nGame Over!";
	        }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (radioButton_yes.Checked)
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.FileName = "cmd";
                proc.Arguments = "/C shutdown -f -r -t 5";
                Process.Start(proc);
            }
            Application.Exit();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("Hahaha, too l8!");
            Application.Exit();
        }
    }
}
