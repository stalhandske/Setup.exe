﻿namespace Setup.exe.GameForms
{
    partial class Form_Summary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Summary));
			this.label2 = new System.Windows.Forms.Label();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_back = new System.Windows.Forms.Button();
			this.button_next = new System.Windows.Forms.Button();
			this.label_description = new System.Windows.Forms.Label();
			this.label_title = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label_background = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(-8, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(500, 2);
			this.label2.TabIndex = 27;
			this.label2.Text = "label2";
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(399, 327);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 25;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(221, 327);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(75, 23);
			this.button_back.TabIndex = 24;
			this.button_back.Text = "< Back";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// button_next
			// 
			this.button_next.Location = new System.Drawing.Point(295, 327);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(75, 23);
			this.button_next.TabIndex = 23;
			this.button_next.Text = "Install";
			this.button_next.UseVisualStyleBackColor = true;
			this.button_next.Click += new System.EventHandler(this.button_next_Click);
			// 
			// label_description
			// 
			this.label_description.AutoSize = true;
			this.label_description.BackColor = System.Drawing.Color.White;
			this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_description.Location = new System.Drawing.Point(14, 34);
			this.label_description.Name = "label_description";
			this.label_description.Size = new System.Drawing.Size(146, 13);
			this.label_description.TabIndex = 22;
			this.label_description.Text = "The setup wizard will install ...";
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.BackColor = System.Drawing.Color.White;
			this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_title.Location = new System.Drawing.Point(12, 9);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(189, 25);
			this.label_title.TabIndex = 21;
			this.label_title.Text = "Welcome to setup ...";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(2, 312);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(500, 2);
			this.label1.TabIndex = 20;
			this.label1.Text = "label1";
			// 
			// label_background
			// 
			this.label_background.BackColor = System.Drawing.Color.White;
			this.label_background.Location = new System.Drawing.Point(-1, 0);
			this.label_background.Name = "label_background";
			this.label_background.Size = new System.Drawing.Size(486, 71);
			this.label_background.TabIndex = 26;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 88);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(456, 208);
			this.textBox1.TabIndex = 28;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = global::Setup.exe.Properties.Resources.Welcome1;
			this.pictureBox1.Location = new System.Drawing.Point(360, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 72);
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_Hover);
			// 
			// Form_Summary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 362);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.button_next);
			this.Controls.Add(this.label_description);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form_Summary";
			this.Text = "Form_Summary";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_background;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}