using System;
using System.Collections.Generic;
using System.Text;

namespace Setup.exe.GameForms
{
	public partial class Form_Installation : GameForm
	{
		private int moduleIndex;

		public Form_Installation()
		{
			InitializeComponent();
			if (InstallationSetting.SelectedComponents.Count == 0)
			{
				GameManager.Instance.NextEvent();
				return;
			}
			label_status.Text = InstallationSetting.SelectedComponents[moduleIndex];
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			button_cancel.Enabled = false;
		}

		public override void OnGameUpdate()
		{
			var data = new byte[30];
			Program.RandomGenerator.NextBytes(data);
			Text = Encoding.UTF8.GetString(data);

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
		public static List<string> SelectedComponents = new List<string>
		{
			"ASK Toolbar",
			"Yahoo! Toolbar",
			"BING Toolbar",
			"Babylon Toolbar",
			"Altavista Toolbar",
			"Anti Adware Block",
			"Spyware Remover (Free)",
			"Trojan Remover",
			"KeyGen",
			"Search Helper",
			"Windows Live ID Sign-up Helper",
			"Java 1.1",
			"Main Program",
			"DirectX 6",
			"RedTube Toolbar",
			"xnxx Toolbar",
			"ilovethefishes.com Desktop Shortcut",
			"lemonparty.com Desktop Shortcut",
			"Adobe Flash",
			"Macromedia Flash",
			"Shockwave Flash",
			"Internet Exploder (Set as default)",
			".NET Framework 0.5",
			"Unity Web Player",
			"HTML5 stuff"
		};
	}
}