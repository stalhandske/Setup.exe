﻿namespace Setup.exe.GameForms
{
    partial class Form_InstallationType
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label_description = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_background = new System.Windows.Forms.Label();
            this.label_choose = new System.Windows.Forms.Label();
            this.radioButton_typical = new System.Windows.Forms.RadioButton();
            this.radioButton_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_veryCustom = new System.Windows.Forms.RadioButton();
            this.label_typical = new System.Windows.Forms.Label();
            this.label_custom = new System.Windows.Forms.Label();
            this.label_veryCustom = new System.Windows.Forms.Label();
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
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(221, 327);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 24;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(295, 327);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 23;
            this.button_next.Text = "Next >";
            this.button_next.UseVisualStyleBackColor = true;
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
            // label_choose
            // 
            this.label_choose.AutoSize = true;
            this.label_choose.Location = new System.Drawing.Point(21, 88);
            this.label_choose.Name = "label_choose";
            this.label_choose.Size = new System.Drawing.Size(122, 13);
            this.label_choose.TabIndex = 28;
            this.label_choose.Text = "Please select setup type";
            // 
            // radioButton_typical
            // 
            this.radioButton_typical.AutoSize = true;
            this.radioButton_typical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_typical.Location = new System.Drawing.Point(24, 124);
            this.radioButton_typical.Name = "radioButton_typical";
            this.radioButton_typical.Size = new System.Drawing.Size(66, 17);
            this.radioButton_typical.TabIndex = 29;
            this.radioButton_typical.TabStop = true;
            this.radioButton_typical.Text = "Typical";
            this.radioButton_typical.UseVisualStyleBackColor = true;
            this.radioButton_typical.CheckedChanged += new System.EventHandler(this.radioButton_typical_CheckedChanged);
            // 
            // radioButton_custom
            // 
            this.radioButton_custom.AutoSize = true;
            this.radioButton_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_custom.Location = new System.Drawing.Point(24, 180);
            this.radioButton_custom.Name = "radioButton_custom";
            this.radioButton_custom.Size = new System.Drawing.Size(66, 17);
            this.radioButton_custom.TabIndex = 30;
            this.radioButton_custom.TabStop = true;
            this.radioButton_custom.Text = "Custom";
            this.radioButton_custom.UseVisualStyleBackColor = true;
            // 
            // radioButton_veryCustom
            // 
            this.radioButton_veryCustom.AutoSize = true;
            this.radioButton_veryCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_veryCustom.Location = new System.Drawing.Point(24, 236);
            this.radioButton_veryCustom.Name = "radioButton_veryCustom";
            this.radioButton_veryCustom.Size = new System.Drawing.Size(95, 17);
            this.radioButton_veryCustom.TabIndex = 31;
            this.radioButton_veryCustom.TabStop = true;
            this.radioButton_veryCustom.Text = "Very Custom";
            this.radioButton_veryCustom.UseVisualStyleBackColor = true;
            // 
            // label_typical
            // 
            this.label_typical.AutoSize = true;
            this.label_typical.Location = new System.Drawing.Point(130, 128);
            this.label_typical.Name = "label_typical";
            this.label_typical.Size = new System.Drawing.Size(65, 13);
            this.label_typical.TabIndex = 32;
            this.label_typical.Text = "Bla bla bla...";
            // 
            // label_custom
            // 
            this.label_custom.AutoSize = true;
            this.label_custom.Location = new System.Drawing.Point(130, 182);
            this.label_custom.Name = "label_custom";
            this.label_custom.Size = new System.Drawing.Size(65, 13);
            this.label_custom.TabIndex = 32;
            this.label_custom.Text = "Bla bla bla...";
            // 
            // label_veryCustom
            // 
            this.label_veryCustom.AutoSize = true;
            this.label_veryCustom.Location = new System.Drawing.Point(130, 240);
            this.label_veryCustom.Name = "label_veryCustom";
            this.label_veryCustom.Size = new System.Drawing.Size(65, 13);
            this.label_veryCustom.TabIndex = 32;
            this.label_veryCustom.Text = "Bla bla bla...";
            // 
            // Form_InstallationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.label_veryCustom);
            this.Controls.Add(this.label_custom);
            this.Controls.Add(this.label_typical);
            this.Controls.Add(this.radioButton_veryCustom);
            this.Controls.Add(this.radioButton_custom);
            this.Controls.Add(this.radioButton_typical);
            this.Controls.Add(this.label_choose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_background);
            this.Name = "Form_InstallationType";
            this.Text = "Setup";
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
        private System.Windows.Forms.Label label_choose;
        private System.Windows.Forms.RadioButton radioButton_typical;
        private System.Windows.Forms.RadioButton radioButton_custom;
        private System.Windows.Forms.RadioButton radioButton_veryCustom;
        private System.Windows.Forms.Label label_typical;
        private System.Windows.Forms.Label label_custom;
        private System.Windows.Forms.Label label_veryCustom;
    }
}