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

			string successText = InstallationSetting.SelectedComponents.Count > 0 ? "\nGame Over!" : "\nYou Win!";
			string moduleText = "nothing";
			if (InstallationSetting.SelectedComponents.Count == 1)
			{
				moduleText = "ASK Toolbar";
			}
			if (InstallationSetting.SelectedComponents.Count >1)
			{
				moduleText = InstallationSetting.SelectedComponents.Count+" Toolbars";
			}


			label_description.Text = $"Successfully installed {moduleText}! {successText}\n You should restart your computer now!";
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
