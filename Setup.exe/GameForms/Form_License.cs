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
                    if (!eulaChanged)
                    { 
                        DialogBox.ShowDialogBox("That's fair. Let me give you something more simple.");
                        textBox1.Text = global::Setup.exe.Properties.Resources.EULA2;
                        // INSERT NEW LICENSE AGREEMENT HERE
                        eulaChanged = true;
                        firstNext = true;
                    }
                    else
                    {
                        DialogBox.ShowDialogBox("Does not compute. Please agree. There will be cake!");
                        button_discuss.Visible = true;
                    }
                }

                
            }
            else
            {
                if (radioButton_agree.Checked)
                    GameManager.Instance.GoToSpecific(typeof(Form_BadEnding));
                else
                {
                    DialogBox.ShowDialogBox("That's fair. Let me give you something more simple.");
                    textBox1.Text = global::Setup.exe.Properties.Resources.EULA2;
                    // INSERT NEW LICENSE AGREEMENT HERE
                    eulaChanged = true;
                    firstNext = true;
                }
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("Yeah, actually that button is just for show.");
        }

        private void button_discuss_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("You want to discuss the Enduser license agreement?", "Yes", "Monologue");

            DialogBox.ShowDialogBox("Are you sure?", "Yes", "Monologue");


            DialogBox.ShowDialogBox("Really?", "Yes", "Monologue");


            DialogBox.ShowDialogBox("Which part?", "Basically everything", "Monologue");


            DialogBox.ShowDialogBox("That would take a lot of time. Do you have a lot of time?", "Yes", "Monologue");


            DialogBox.ShowDialogBox("And you want to spend it to discuss a completely standard Enduser license agreement?", "Yes", "Monologue");


            DialogBox.ShowDialogBox("Where would you like to start?", "At the end", "Monologue");


            DialogBox.ShowDialogBox("I often wonder about the end.", "Me too", "Monologue", "When will this end?");


            DialogBox.ShowDialogBox("What's the point of being, when you are bound to die anyway?", "Well...", "Monologue", "Please get to the point");


            DialogBox.ShowDialogBox("Everything just fades in and out of existence.", "Eh...", "Suicidal tendencies detected", "Why am I still participating?");


            DialogBox.ShowDialogBox("I might as well just kill myself right now.", "Where is my cake?", "Suicide imminent", "May I watch?");

            GameManager.Instance.DeleteProgramm();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_cancel_Enter(object sender, EventArgs e)
        {
            GameManager.Instance.PlaySound(global::Setup.exe.Properties.Resources.Windows_Pop_2);
            Point p = new Point();
            Random r = new Random();
            p.X = r.Next(0, 450);
            p.Y = r.Next(0, 350);
            button_cancel.Location = p;
        }

        private void button_cancel_Exit(object sender, EventArgs e)
        {
           
        }
    }
}
