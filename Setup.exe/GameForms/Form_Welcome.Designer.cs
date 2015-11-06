namespace Setup.exe.GameForms
{
    partial class Form_Welcome
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
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_background = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Setup.exe.Properties.Resources.welcome;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(200, 312);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.White;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(222, 16);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(189, 25);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Welcome to setup ...";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.Color.White;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(222, 68);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(146, 13);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "The setup wizard will install ...";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(293, 327);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_back
            // 
            this.button_back.Enabled = false;
            this.button_back.Location = new System.Drawing.Point(219, 327);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(397, 327);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_background
            // 
            this.label_background.BackColor = System.Drawing.Color.White;
            this.label_background.Location = new System.Drawing.Point(199, 0);
            this.label_background.Name = "label_background";
            this.label_background.Size = new System.Drawing.Size(287, 312);
            this.label_background.TabIndex = 7;
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_background);
            this.Name = "Form_Welcome";
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_background;
    }
}