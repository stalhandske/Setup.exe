﻿namespace Setup.exe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBox));
            this.label_text = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_No = new System.Windows.Forms.Button();
            this.pictureBox_Rick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rick)).BeginInit();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.Location = new System.Drawing.Point(96, 24);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(240, 80);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "addTextHere";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(126, 115);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(24, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(56, 50);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(216, 115);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 23);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Visible = false;
            this.button_No.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // pictureBox_Rick
            // 
            this.pictureBox_Rick.Image = global::Setup.exe.Properties.Resources.giphy;
            this.pictureBox_Rick.Location = new System.Drawing.Point(24, -24);
            this.pictureBox_Rick.Name = "pictureBox_Rick";
            this.pictureBox_Rick.Size = new System.Drawing.Size(304, 176);
            this.pictureBox_Rick.TabIndex = 4;
            this.pictureBox_Rick.TabStop = false;
            this.pictureBox_Rick.Visible = false;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 150);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.pictureBox_Rick);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.label_text);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rick)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_text;
		private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.PictureBox pictureBox_Rick;
    }
}