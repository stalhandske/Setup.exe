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
    public partial class Form_Summary : GameForm
    {
        public Form_Summary()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            GameManager.Instance.NextEvent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("Never gonna give you up, never gonna let you down, never gonna turn around and desert you. Never gonna make you cry, never gonna ...");
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            GameManager.Instance.PlaySound(global::Setup.exe.Properties.Resources.F___Windows_Error);
            button_cancel.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Hover(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.None;
                GameManager.Instance.PlaySound(global::Setup.exe.Properties.Resources.F___Windows_Error);
            }
        }
    }
}
