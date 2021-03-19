using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup
{
    public partial class FormAutoBackup : Form
    {
        public FormAutoBackup()
        {
            InitializeComponent();
            txtFolderPath.Text = Properties.Settings.Default.Folder;
            txtBackupFolderPath.Text = Properties.Settings.Default.BackupFolder;
        }

        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            insertPath(txtFolderPath, getPath());
        }

        private void btnBackupFolderPath_Click(object sender, EventArgs e)
        {
            insertPath(txtBackupFolderPath, getPath());
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (verifyTextboxs())
            {
                BackupManager backupManager = new BackupManager();
                btnRun.Text = "Running...";
                this.Refresh();
                Thread.Sleep(10);
                result = backupManager.Backup(txtFolderPath.Text, txtBackupFolderPath.Text);
            }

            string message = (result) ? "Backup Succefuly Executed" : "Some Error Occured";
            MessageBox.Show(message);

            if (result)
            {
                Properties.Settings.Default.Folder = txtFolderPath.Text;
                Properties.Settings.Default.BackupFolder = txtBackupFolderPath.Text;
                Properties.Settings.Default.Save();
            }

            this.Close();
        }

        private string getPath()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
                return browser.SelectedPath;

            return null;
        }

        private void insertPath(TextBox txt, string path)
        {
            txt.Text = path;
        }

        private bool verifyTextboxs()
        {
            string path1 = txtFolderPath.Text.Trim();
            string path2 = txtBackupFolderPath.Text.Trim();
            return path1.Length > 0 && path2.Length > 0;
        }

        
    }
}
