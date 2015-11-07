using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.exe.GameForms
{
	public partial class Form_Installation : GameForm
	{
		public Form_Installation()
		{
			InitializeComponent();
			label_status.Text = InstallationSetting.SelectedComponents[moduleIndex];
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			button_cancel.Enabled = false;
		}

		private int moduleIndex = 0;
		public override void OnGameUpdate()
		{
			byte[] data = new byte[30];
			Program.RandomGenerator.NextBytes(data);
			this.Text = System.Text.Encoding.UTF8.GetString(data);

			progressBar.Value += 10;
			if (progressBar.Value == 100)
			{
				progressBar.Value = 0;
				moduleIndex++;
				if (moduleIndex == InstallationSetting.SelectedComponents.Count)
				{
					GameManager.Instance.NextEvent();
					return;
				}
				label_status.Text = InstallationSetting.SelectedComponents[moduleIndex];
			}
			base.OnGameUpdate();
		}
	}


	public static class InstallationSetting
	{
		public static List<string> SelectedComponents=new List<string>();
	}
}
