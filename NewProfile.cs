using System;
using System.IO;
using System.Windows.Forms;

namespace FO3ProfileManager
{
	public partial class NewProfile : Form
	{
		public NewProfile()
		{
			InitializeComponent();
		}

		private void btn_createProfile_Click(object sender, EventArgs e)
		{
			string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string savesPath = Properties.Resources.RootSavesFullPath;
			string profilePath = savesPath + txt_profileName.Text;

			if (Directory.Exists(profilePath))
				MessageBox.Show(Properties.Resources.ProfileExists);
			else
			{
				Directory.CreateDirectory(profilePath);
				this.Dispose();
			}
		}
		
		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
