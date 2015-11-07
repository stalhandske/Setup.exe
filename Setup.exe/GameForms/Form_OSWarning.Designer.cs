namespace Setup.exe.GameForms
{
    partial class Form_OSWarning
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_publisher = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Setup.exe.Properties.Resources.Shield;
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(16, 80);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(106, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name: Setup Inc.";
            // 
            // label_publisher
            // 
            this.label_publisher.AutoSize = true;
            this.label_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_publisher.Location = new System.Drawing.Point(16, 104);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(176, 13);
            this.label_publisher.TabIndex = 1;
            this.label_publisher.Text = "Publisher: Unknown Publisher";
            this.label_publisher.Click += new System.EventHandler(this.label_publisher_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(80, 16);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(253, 52);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "The publisher could not be verified \r\n...although he is probably a nice guy.\r\n\r\nA" +
    "re you sure you want to run this software?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Don\'t Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_Enter);
            // 
            // Form_OSWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 165);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_publisher);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_OSWarning";
            this.Text = "Windows - Security Warning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}