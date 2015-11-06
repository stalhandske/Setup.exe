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
    public partial class Form_OSWarning : GameForm
    {
        public Form_OSWarning()
        {
            InitializeComponent();
        }

        private void label_publisher_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameManager.Instance.NextEvent();
        }
    }
}
