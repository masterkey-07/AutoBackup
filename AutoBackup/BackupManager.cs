using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace AutoBackup
{
    class BackupManager
    {
        public bool Backup(string folderpath, string backupfolderpath)
        {
            try
            {
                string BackupPath = $@"{backupfolderpath.Trim()}\{Path.GetFileName(folderpath)}.zip";
                              if (File.Exists(BackupPath))
                    File.Delete(BackupPath);

                ZipFile.CreateFromDirectory(folderpath, BackupPath);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
