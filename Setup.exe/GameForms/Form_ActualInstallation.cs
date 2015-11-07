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
	public partial class Form_ActualInstallation : GameForm
	{
		private bool _doFillup = true;

		public Form_ActualInstallation()
		{
			InitializeComponent();
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			if (progressBar.Value - 4000 <= 0)
			{
				GameManager.Instance.NextEvent();
            }
			else
			{
				if (_doFillup)
				{
					progressBar.Value -= 4000;
				}
			}
		}

		public override void OnGameUpdate()
		{
			if (_doFillup)
			{
				int newValue = (int) Math.Round(0.96f*progressBar.Value + 0.04f*10060);
				if (newValue > 10000)
				{
					//todo implement fail
					GameManager.Instance.NextEvent();
				}
				else
				{
					progressBar.Value = newValue;
				}
			}
			//progressBar.Value = Math.Min(progressBar.Maximum, progressBar.Value + 40);
			base.OnGameUpdate();
		}
	}
}