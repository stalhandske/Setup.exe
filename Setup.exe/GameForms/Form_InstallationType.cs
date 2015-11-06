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
            if (radioButton_typical.Checked)
            {
                GameManager.Instance.GoToSpecific(typeof(Form_Summary));
            }
            else
            {
                GameManager.Instance.NextEvent();
            }
        }
    }
}
