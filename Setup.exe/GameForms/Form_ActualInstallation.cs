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
	public partial class Form_ActualInstallation : GameForm
	{
		public Form_ActualInstallation()
		{
			InitializeComponent();
		}

		public int speed = 10;

		private void button_cancel_Click(object sender, EventArgs e)
		{
			speed *=3;
		}

		public override void OnGameUpdate()
		{
			progressBar.Value=Math.Min(progressBar.Maximum,progressBar.Value+speed);
			base.OnGameUpdate();
		}
	}
}
