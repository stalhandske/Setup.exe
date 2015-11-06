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
    public partial class Form_License : GameForm
    {
        bool firstNext = true;

        public Form_License()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (firstNext)
            {
                if (!radioButton1.Checked && !radioButton_agree.Checked)
                {
                    DialogBox.ShowDialogBox("That's not how it works.");
                }
                else if (radioButton_agree.Checked)
                {

                }
                else
                {
                    // INSERT NEW LICENSE AGREEMENT HERE
                    firstNext = false;
                }

                
            }
            else
            {
                GameManager.Instance.NextEvent();
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseUp(object sender, EventArgs e)
        {
            button_next.Enabled = true;
        }
    }
}
