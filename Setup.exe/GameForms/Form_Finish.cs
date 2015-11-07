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
    public partial class Form_Finish : GameForm
    {
        public Form_Finish()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("Hahaha, too l8!");
            Application.Exit();
        }
    }
}
