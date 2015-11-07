using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.exe
{
	public partial class DialogBox : Form
	{
		public DialogBox(string text, string headerText, string buttonText, string button2Text)
		{
			InitializeComponent();
			label_text.Text = text;
			Text = headerText;
            button_ok.Text = buttonText;
            if (button2Text != "")
            {
                button_No.Visible = true;
                button_No.Text = button2Text;
            }
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		public static void ShowDialogBox(string text, string buttonText = "OK", string headerText = "DialogBox", string button2Text = "")
		{
            GameManager.Instance.PlaySound(global::Setup.exe.Properties.Resources.Windows_Pop_1);

            DialogBox box=new DialogBox(text,headerText, buttonText, button2Text);
			box.ShowDialog();
        }
	}
}
