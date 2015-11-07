namespace Setup.exe.GameForms
{
    partial class Form_Finish
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_background = new System.Windows.Forms.Label();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Enabled = false;
            this.button_back.Location = new System.Drawing.Point(221, 327);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 51;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(295, 327);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 50;
            this.button_next.Text = "Finish";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(2, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.Color.White;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(222, 68);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(209, 78);
            this.label_description.TabIndex = 56;
            this.label_description.Text = "The setup wizard has successfully installed\r\n16 Toolbars\r\n31 Anti Adware Blockers" +
    "\r\n52 Desktop Shortcuts\r\n\r\nDo you want to restart to complete setup?";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.White;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(222, 16);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(183, 25);
            this.label_title.TabIndex = 55;
            this.label_title.Text = "Completing Setup...";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 2);
            this.label2.TabIndex = 54;
            this.label2.Text = "label2";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Setup.exe.Properties.Resources.Finish;
            this.pictureBox_logo.Location = new System.Drawing.Point(8, 8);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(192, 288);
            this.pictureBox_logo.TabIndex = 53;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_background
            // 
            this.label_background.BackColor = System.Drawing.Color.White;
            this.label_background.Location = new System.Drawing.Point(199, 0);
            this.label_background.Name = "label_background";
            this.label_background.Size = new System.Drawing.Size(287, 312);
            this.label_background.TabIndex = 57;
            // 
            // radioButton_yes
            // 
            this.radioButton_yes.AutoSize = true;
            this.radioButton_yes.BackColor = System.Drawing.Color.White;
            this.radioButton_yes.Location = new System.Drawing.Point(224, 168);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(167, 17);
            this.radioButton_yes.TabIndex = 58;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.Text = "Yes, restart my computer now.";
            this.radioButton_yes.UseVisualStyleBackColor = false;
            // 
            // radioButton_no
            // 
            this.radioButton_no.BackColor = System.Drawing.Color.White;
            this.radioButton_no.Location = new System.Drawing.Point(224, 184);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(248, 56);
            this.radioButton_no.TabIndex = 58;
            this.radioButton_no.TabStop = true;
            this.radioButton_no.Text = "No, I will restart my computer later.";
            this.radioButton_no.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(224, 232);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(248, 40);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Please restart my computer at a random point while I\'m doing something important." +
    "";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(399, 327);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 52;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton_no);
            this.Controls.Add(this.radioButton_yes);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_background);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Finish";
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_background;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_cancel;
    }
}