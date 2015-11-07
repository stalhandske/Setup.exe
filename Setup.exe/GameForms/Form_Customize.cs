using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Setup.exe.GameForms
{
	public partial class Form_Customize : GameForm
	{
		private Point _targetPosition;
		private int moveCount;
        private bool moveBack;

		public Form_Customize()
		{
			InitializeComponent();
			for (var i = 0; i < checkedListBox.Items.Count; i++)
			{
				checkedListBox.SetItemChecked(i, true);
			}
			_targetPosition = checkedListBox.Location;
			Program.RandomGenerator = new Random(42);
			UpdateSelection();
		}

		private void UpdateSelection()
		{
			InstallationSetting.SelectedComponents=new List<string>();
			foreach (var item in checkedListBox.CheckedItems)
			{
				InstallationSetting.SelectedComponents.Add(item.ToString());
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
			UpdateSelection();
		}

		private void checkedListBox_SelectedValueChanged(object sender, EventArgs e)
		{
			moveCount++;
			if (moveCount < 4)
			{
				var p = checkedListBox.Location;
				p.X += 75;
				p.Y += 75;
				_targetPosition = p;
			}
			else
			{
				if (moveCount%4 == 0)
					_targetPosition = new Point(Program.RandomGenerator.Next(800), Program.RandomGenerator.Next(600));
			}
		}

		public override void OnGameUpdate()
		{
			var p = checkedListBox.Location;
			var speed = 0.1f;
			checkedListBox.Location = new Point((int) Math.Round((p.X*(1 - speed) + _targetPosition.X*speed)),
				(int) Math.Round(p.Y*(1 - speed) + _targetPosition.Y*speed));
			base.OnGameUpdate();

            if (moveBack)
            {
                Point point = button_back.Location;
                point.X -= 1;
                button_back.Location = point;
            }
		}

        private void button_back_Click(object sender, EventArgs e)
        {
            moveBack = true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            moveBack = false;
        }
    }
}