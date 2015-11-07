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
		}
	}


	public static class InstallationSetting
	{
		public static List<string> SelectedComponents=new List<string>();
	}
}
