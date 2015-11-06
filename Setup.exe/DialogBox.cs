using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.exe
{
	public partial class DialogBox : Form
	{
		public DialogBox(string text, string headerText)
		{
			InitializeComponent();
			label_text.Text = text;
			Text = headerText;
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		public static void ShowDialogBox(string text, string headerText = "DialogBox")
		{
			DialogBox box=new DialogBox(text,headerText);
			box.ShowDialog();
		}
	}
}
