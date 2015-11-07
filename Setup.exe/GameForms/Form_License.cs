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
        bool eulaChanged = false;

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
                    if (eulaChanged)
                    {
                        GameManager.Instance.NextEvent();
                    }
                    else if (!firstNext)
                    {
                        // Bad ending
                    }
                    else
                    { 
                        DialogBox.ShowDialogBox("Are you really sure you want to do that?");
                        textBox1.Focus();
                        //textBox1.Select(0, 10);
                        textBox1.SelectionStart = textBox1.Text.IndexOf("(d)");
                        textBox1.SelectionLength = textBox1.Text.IndexOf("2.4") - textBox1.Text.IndexOf("(d)");
                        DialogBox.ShowDialogBox("Maybe you should read this section more carefully.");
                        textBox1.ScrollToCaret();

                        firstNext = false;
                    }
                }
                else
                {
                    DialogBox.ShowDialogBox("That's fair. Let me give you something more simple.");
                    textBox1.Text = global::Setup.exe.Properties.Resources.EULA2;
                    // INSERT NEW LICENSE AGREEMENT HERE
                    eulaChanged = true;
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

        private void button_back_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("Yeah, actually that button is just for show.");
        }
    }
}
