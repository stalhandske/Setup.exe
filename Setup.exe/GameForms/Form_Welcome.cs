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
    public partial class Form_Welcome : GameForm
    {
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            GameManager.Instance.NextEvent();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            GameManager.Instance.NextEvent();
        }

        private void button_cancel_Enter(object sender, EventArgs e)
        {
            GameManager.Instance.PlaySound(global::Setup.exe.Properties.Resources.Windows_Pop_2);
            button_cancel.Text = "Next >";
        }

        private void button_cancel_Exit(object sender, EventArgs e)
        {
            button_cancel.Text = "Cancel";
        }
    }
}
