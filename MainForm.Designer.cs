namespace FO3ProfileManager
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_launch = new System.Windows.Forms.Button();
			this.cbo_profiles = new System.Windows.Forms.ComboBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.smi_actions = new System.Windows.Forms.ToolStripMenuItem();
			this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.smi_settings = new System.Windows.Forms.ToolStripMenuItem();
			this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pic_thumbsUp = new System.Windows.Forms.PictureBox();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_thumbsUp)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_launch
			// 
			this.btn_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_launch.Location = new System.Drawing.Point(12, 58);
			this.btn_launch.Name = "btn_launch";
			this.btn_launch.Size = new System.Drawing.Size(260, 45);
			this.btn_launch.TabIndex = 1;
			this.btn_launch.Text = "Play";
			this.btn_launch.UseVisualStyleBackColor = true;
			this.btn_launch.Click += new System.EventHandler(this.btn_launch_Click);
			// 
			// cbo_profiles
			// 
			this.cbo_profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_profiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_profiles.Location = new System.Drawing.Point(12, 27);
			this.cbo_profiles.Name = "cbo_profiles";
			this.cbo_profiles.Size = new System.Drawing.Size(260, 25);
			this.cbo_profiles.TabIndex = 2;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_actions,
            this.smi_settings});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(284, 24);
			this.menuStrip.TabIndex = 3;
			this.menuStrip.Text = "menuStrip1";
			// 
			// smi_actions
			// 
			this.smi_actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.toolStripMenuItem1});
			this.smi_actions.Name = "smi_actions";
			this.smi_actions.Size = new System.Drawing.Size(59, 20);
			this.smi_actions.Text = "Actions";
			// 
			// newProfileToolStripMenuItem
			// 
			this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
			this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.newProfileToolStripMenuItem.Text = "New Profile";
			this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
			this.toolStripMenuItem1.Text = "Scan SaveGames";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// smi_settings
			// 
			this.smi_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem});
			this.smi_settings.Name = "smi_settings";
			this.smi_settings.Size = new System.Drawing.Size(61, 20);
			this.smi_settings.Text = "Settings";
			// 
			// changeToolStripMenuItem
			// 
			this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
			this.changeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.changeToolStripMenuItem.Text = "Set Game exe";
			this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
			// 
			// pic_thumbsUp
			// 
			this.pic_thumbsUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_thumbsUp.Image = global::FO3ProfileManager.Properties.Resources.ThumbsUp;
			this.pic_thumbsUp.Location = new System.Drawing.Point(12, 115);
			this.pic_thumbsUp.Name = "pic_thumbsUp";
			this.pic_thumbsUp.Size = new System.Drawing.Size(260, 268);
			this.pic_thumbsUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_thumbsUp.TabIndex = 4;
			this.pic_thumbsUp.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 395);
			this.Controls.Add(this.pic_thumbsUp);
			this.Controls.Add(this.cbo_profiles);
			this.Controls.Add(this.btn_launch);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fallout 3 Profile Manager";
			this.Load += new System.EventHandler(this.MainLoad);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_thumbsUp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_launch;
		private System.Windows.Forms.ComboBox cbo_profiles;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem smi_actions;
		private System.Windows.Forms.ToolStripMenuItem smi_settings;
		private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.PictureBox pic_thumbsUp;
	}
}

