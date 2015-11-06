namespace Setup.exe
{
	partial class DialogBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_text = new System.Windows.Forms.Label();
			this.button_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_text
			// 
			this.label_text.AutoSize = true;
			this.label_text.Location = new System.Drawing.Point(48, 27);
			this.label_text.Name = "label_text";
			this.label_text.Size = new System.Drawing.Size(69, 13);
			this.label_text.TabIndex = 0;
			this.label_text.Text = "addTextHere";
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(126, 115);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 23);
			this.button_ok.TabIndex = 1;
			this.button_ok.Text = "Ok";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// DialogBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 150);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.label_text);
			this.Name = "DialogBox";
			this.Text = "DialogBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_text;
		private System.Windows.Forms.Button button_ok;
	}
}