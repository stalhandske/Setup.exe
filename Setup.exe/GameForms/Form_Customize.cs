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
    public partial class Form_Customize : GameForm
    {
        int moveCount = 0;

        public Form_Customize()
        {
            InitializeComponent();
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }

        private void textBox_browse_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            DialogBox.ShowDialogBox("No need for that, I'll find the best place to install all of the stuff.");
        }

        private void button_next_Click(object sender, EventArgs e)
        {

            GameManager.Instance.NextEvent();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            moveCount++;
            if (moveCount < 4)
            { 
                Point p = checkedListBox.Location;
                p.X += 75;
                p.Y += 75;
                checkedListBox.Location = p;
            }
        }
        
    }
}
