namespace FO3ProfileManager
{
	partial class NewProfile
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
			this.txt_profileName = new System.Windows.Forms.TextBox();
			this.lab_profileName = new System.Windows.Forms.Label();
			this.btn_createProfile = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tex_profileName
			// 
			this.txt_profileName.Location = new System.Drawing.Point(46, 34);
			this.txt_profileName.Name = "tex_profileName";
			this.txt_profileName.Size = new System.Drawing.Size(160, 20);
			this.txt_profileName.TabIndex = 0;
			// 
			// lab_profileName
			// 
			this.lab_profileName.AutoSize = true;
			this.lab_profileName.Location = new System.Drawing.Point(43, 18);
			this.lab_profileName.Name = "lab_profileName";
			this.lab_profileName.Size = new System.Drawing.Size(70, 13);
			this.lab_profileName.TabIndex = 1;
			this.lab_profileName.Text = "Profile Name:";
			// 
			// btn_createProfile
			// 
			this.btn_createProfile.Location = new System.Drawing.Point(46, 60);
			this.btn_createProfile.Name = "btn_createProfile";
			this.btn_createProfile.Size = new System.Drawing.Size(160, 23);
			this.btn_createProfile.TabIndex = 2;
			this.btn_createProfile.Text = "Create Profile";
			this.btn_createProfile.UseVisualStyleBackColor = true;
			this.btn_createProfile.Click += new System.EventHandler(this.btn_createProfile_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(46, 92);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(160, 23);
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// NewProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 127);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_createProfile);
			this.Controls.Add(this.lab_profileName);
			this.Controls.Add(this.txt_profileName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NewProfile";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_profileName;
		private System.Windows.Forms.Label lab_profileName;
		private System.Windows.Forms.Button btn_createProfile;
		private System.Windows.Forms.Button btn_cancel;
	}
}