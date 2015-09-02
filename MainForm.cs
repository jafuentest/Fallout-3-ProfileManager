using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FO3ProfileManager
{
	public partial class MainForm : Form
	{
		private string[] fileLines;

		public MainForm()
		{
			InitializeComponent();
		}

		private void EditIniFile(string profileName)
		{
			string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string filePath = myDocumentsPath + @"\" + Properties.Resources.Fallout3DotIniPath;
			fileLines = File.ReadAllLines(filePath);

			for (int i = 0; i < fileLines.Length; i++)
				if (fileLines[i].StartsWith(Properties.Resources.ConfigKey))
					fileLines[i] = Properties.Resources.ConfigKey + Properties.Resources.RootSavesSubPath + profileName;

			File.WriteAllLines(filePath, fileLines);
		}

		private void SaveSetting(string key, string value)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings.Remove(key);
			config.AppSettings.Settings.Add(new KeyValueConfigurationElement(key, value));
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}

		private void SaveSettings(Dictionary<string,string> settings)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			foreach (KeyValuePair<string, string> setting in settings)
			{
				config.AppSettings.Settings.Remove(setting.Key);
				config.AppSettings.Settings.Add(new KeyValueConfigurationElement(setting.Key, setting.Value));
			}
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}

		#region Events
		private void MainLoad(object sender, EventArgs e)
		{
			// Check game exe path
			if (String.IsNullOrEmpty(ConfigurationManager.AppSettings["GameExePath"]))
			{
				Dictionary<string, string> settings = new Dictionary<string,string>();
				MessageBox.Show("No exe path in settings");
				using (RegistryKey key = Registry.LocalMachine.OpenSubKey(Properties.Resources.RegistryPath))
				{
					string path = (string)key.GetValue(Properties.Resources.RegistryKey);
					settings.Add("GameExePath", path);
				}
				string fileName = Properties.Resources.DefaultExe;
				settings.Add("GameExeFileName", fileName);
				SaveSettings(settings);
			}

			// Load combo box
			string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			DirectoryInfo dir = new DirectoryInfo(myDocumentsPath + @"\" + Properties.Resources.RootSavesFullPath);
			foreach (DirectoryInfo subDir in dir.GetDirectories())
				cbo_profiles.Items.Add(subDir.Name);
			cbo_profiles.SelectedIndex = 0;
		}

		private void btn_launch_Click(object sender, EventArgs e)
		{
			EditIniFile((string)cbo_profiles.SelectedItem);

			try
			{
				ProcessStartInfo psi = new ProcessStartInfo();
				psi.WorkingDirectory = ConfigurationManager.AppSettings["GameExePath"];
				psi.FileName = ConfigurationManager.AppSettings["GameExePath"] +
					@"\" + ConfigurationManager.AppSettings["GameExeFileName"];
				psi.Arguments = "";
				psi.CreateNoWindow = true;

				Process.Start(psi);

				Configuration appConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				appConfiguration.Save(ConfigurationSaveMode.Full, true);

				Application.Exit();
			}
			catch (Exception)
			{
				MessageBox.Show(Properties.Resources.RegistryError);
			}
		}

		private void changeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Application|*.exe|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = ConfigurationManager.AppSettings["GameExePath"];
			DialogResult result = openFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				Dictionary<string, string> settings = new Dictionary<string, string>();
				settings.Add("GameExePath", Path.GetDirectoryName(openFileDialog.FileName));
				settings.Add("GameExeFileName", Path.GetFileName(openFileDialog.FileName));
				SaveSettings(settings);
			}
		}
		#endregion

		private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NewProfile().ShowDialog(this);
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented =p");
		}
	}
}
