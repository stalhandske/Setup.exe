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
    public partial class Form_InstallationType : GameForm
    {
        public Form_InstallationType()
        {
            InitializeComponent();
        }

        private void radioButton_typical_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (radioButton_typical.Checked || radioButton_custom.Checked)
            {
                GameManager.Instance.GoToSpecific(typeof(Form_Summary));
            }
            else
            {
                GameManager.Instance.NextEvent();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("Never gonna give you up",rick: true);
        }

        private void radioButton_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_custom.Checked)
            {
                GameManager.Instance.PlaySound(global::Setup.exe.Properties.Resources.Windows_Pop_2);
                radioButton_custom.Text = "Typical";
                pictureBox_custom.Image = global::Setup.exe.Properties.Resources.Typical;
                label_custom.Text = "Or this one :)";
            }
        }
    }
}
