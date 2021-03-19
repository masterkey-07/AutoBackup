namespace AutoBackup
{
    partial class FormAutoBackup
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoBackup));
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.txtBackupFolderPath = new System.Windows.Forms.TextBox();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.btnBackupFolderPath = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.Black;
            this.txtFolderPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.ForeColor = System.Drawing.Color.White;
            this.txtFolderPath.Location = new System.Drawing.Point(12, 27);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(333, 22);
            this.txtFolderPath.TabIndex = 0;
            // 
            // txtBackupFolderPath
            // 
            this.txtBackupFolderPath.BackColor = System.Drawing.Color.Black;
            this.txtBackupFolderPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupFolderPath.ForeColor = System.Drawing.Color.White;
            this.txtBackupFolderPath.Location = new System.Drawing.Point(12, 93);
            this.txtBackupFolderPath.Name = "txtBackupFolderPath";
            this.txtBackupFolderPath.Size = new System.Drawing.Size(333, 22);
            this.txtBackupFolderPath.TabIndex = 1;
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderPath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnFolderPath.Location = new System.Drawing.Point(351, 27);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(40, 22);
            this.btnFolderPath.TabIndex = 2;
            this.btnFolderPath.Text = "...";
            this.btnFolderPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFolderPath.UseVisualStyleBackColor = true;
            this.btnFolderPath.Click += new System.EventHandler(this.btnFolderPath_Click);
            // 
            // btnBackupFolderPath
            // 
            this.btnBackupFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupFolderPath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnBackupFolderPath.Location = new System.Drawing.Point(351, 93);
            this.btnBackupFolderPath.Name = "btnBackupFolderPath";
            this.btnBackupFolderPath.Size = new System.Drawing.Size(40, 22);
            this.btnBackupFolderPath.TabIndex = 3;
            this.btnBackupFolderPath.Text = "...";
            this.btnBackupFolderPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackupFolderPath.UseVisualStyleBackColor = true;
            this.btnBackupFolderPath.Click += new System.EventHandler(this.btnBackupFolderPath_Click);
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(12, 147);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(384, 30);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run Backup";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.ForeColor = System.Drawing.Color.White;
            this.lblFolder.Location = new System.Drawing.Point(12, 9);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(217, 15);
            this.lblFolder.TabIndex = 5;
            this.lblFolder.Text = "Folder Path to make the Backup";
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupFolder.ForeColor = System.Drawing.Color.White;
            this.lblBackupFolder.Location = new System.Drawing.Point(9, 75);
            this.lblBackupFolder.Name = "lblBackupFolder";
            this.lblBackupFolder.Size = new System.Drawing.Size(280, 15);
            this.lblBackupFolder.TabIndex = 6;
            this.lblBackupFolder.Text = "Folder Path to create the Backup (.zip)";
            // 
            // FormAutoBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(403, 183);
            this.Controls.Add(this.lblBackupFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBackupFolderPath);
            this.Controls.Add(this.btnFolderPath);
            this.Controls.Add(this.txtBackupFolderPath);
            this.Controls.Add(this.txtFolderPath);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAutoBackup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.TextBox txtBackupFolderPath;
        private System.Windows.Forms.Button btnFolderPath;
        private System.Windows.Forms.Button btnBackupFolderPath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblBackupFolder;
    }
}

