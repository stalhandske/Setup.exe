namespace Setup.exe.GameForms
{
	partial class Form_Installation
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.button_cancel = new System.Windows.Forms.Button();
			this.label_status = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Setup.exe.Properties.Resources.Install;
			this.pictureBox1.Location = new System.Drawing.Point(24, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(56, 56);
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(16, 66);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(248, 23);
			this.progressBar.TabIndex = 57;
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(280, 66);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 56;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// label_status
			// 
			this.label_status.AutoSize = true;
			this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_status.Location = new System.Drawing.Point(86, 10);
			this.label_status.Name = "label_status";
			this.label_status.Size = new System.Drawing.Size(41, 13);
			this.label_status.TabIndex = 59;
			this.label_status.Text = "label1";
			// 
			// Form_Installation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 99);
			this.Controls.Add(this.label_status);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.button_cancel);
			this.Name = "Form_Installation";
			this.Text = "Form_Installation";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Label label_status;
	}
}