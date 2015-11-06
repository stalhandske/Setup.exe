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
                // INSERT NEW LICENSE AGREEMENT HERE
                firstNext = false;
            }
            else
            {
                GameManager.Instance.NextEvent();
            }
        
        }
    }
}
