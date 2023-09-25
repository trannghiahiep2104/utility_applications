namespace utility_applications
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_encryption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_delete = new System.Windows.Forms.GroupBox();
            this.lb_loading = new System.Windows.Forms.Label();
            this.lb_SelectScanMode1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_SelectScanMode = new System.Windows.Forms.Label();
            this.lb_instructSetFoder = new System.Windows.Forms.Label();
            this.bttselect_all = new System.Windows.Forms.Button();
            this.bttscan = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttgetpath = new System.Windows.Forms.Button();
            this.lstv_listFileDelete = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbx_setting = new System.Windows.Forms.GroupBox();
            this.cbb_settingLanguage = new System.Windows.Forms.ComboBox();
            this.btt_loseSetting = new System.Windows.Forms.Button();
            this.lb_language = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbx_lockFoder = new System.Windows.Forms.GroupBox();
            this.btt_Browse = new System.Windows.Forms.Button();
            this.btt_unlock = new System.Windows.Forms.Button();
            this.btt_Lock = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lb_foderPathLockfoder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.gbx_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_setting.SuspendLayout();
            this.gbx_lockFoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_delete,
            this.tsm_encryption,
            this.tsm_setting});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(216, 450);
            this.menuStrip2.TabIndex = 34;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsm_delete
            // 
            this.tsm_delete.AutoSize = false;
            this.tsm_delete.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsm_delete.Image")));
            this.tsm_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsm_delete.Name = "tsm_delete";
            this.tsm_delete.Size = new System.Drawing.Size(210, 60);
            this.tsm_delete.Text = "Delete files";
            this.tsm_delete.Click += new System.EventHandler(this.tsm_delete_Click);
            // 
            // tsm_encryption
            // 
            this.tsm_encryption.AutoSize = false;
            this.tsm_encryption.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_encryption.Image = ((System.Drawing.Image)(resources.GetObject("tsm_encryption.Image")));
            this.tsm_encryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsm_encryption.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.tsm_encryption.Name = "tsm_encryption";
            this.tsm_encryption.Size = new System.Drawing.Size(210, 60);
            this.tsm_encryption.Text = "Encode";
            this.tsm_encryption.Click += new System.EventHandler(this.tsm_encryption_Click);
            // 
            // tsm_setting
            // 
            this.tsm_setting.AutoSize = false;
            this.tsm_setting.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_setting.Image = ((System.Drawing.Image)(resources.GetObject("tsm_setting.Image")));
            this.tsm_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsm_setting.Name = "tsm_setting";
            this.tsm_setting.Size = new System.Drawing.Size(210, 60);
            this.tsm_setting.Text = "Setting";
            this.tsm_setting.Click += new System.EventHandler(this.tsm_setting_Click);
            // 
            // gbx_delete
            // 
            this.gbx_delete.Controls.Add(this.lb_loading);
            this.gbx_delete.Controls.Add(this.lb_SelectScanMode1);
            this.gbx_delete.Controls.Add(this.pictureBox1);
            this.gbx_delete.Controls.Add(this.comboBox1);
            this.gbx_delete.Controls.Add(this.lb_SelectScanMode);
            this.gbx_delete.Controls.Add(this.lb_instructSetFoder);
            this.gbx_delete.Controls.Add(this.bttselect_all);
            this.gbx_delete.Controls.Add(this.bttscan);
            this.gbx_delete.Controls.Add(this.bttDelete);
            this.gbx_delete.Controls.Add(this.bttgetpath);
            this.gbx_delete.Controls.Add(this.lstv_listFileDelete);
            this.gbx_delete.Controls.Add(this.progressBar1);
            this.gbx_delete.Location = new System.Drawing.Point(219, 0);
            this.gbx_delete.Name = "gbx_delete";
            this.gbx_delete.Size = new System.Drawing.Size(670, 430);
            this.gbx_delete.TabIndex = 35;
            this.gbx_delete.TabStop = false;
            // 
            // lb_loading
            // 
            this.lb_loading.AutoSize = true;
            this.lb_loading.BackColor = System.Drawing.Color.Transparent;
            this.lb_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loading.ForeColor = System.Drawing.Color.Red;
            this.lb_loading.Location = new System.Drawing.Point(373, 302);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(44, 16);
            this.lb_loading.TabIndex = 29;
            this.lb_loading.Text = "100%";
            this.lb_loading.Visible = false;
            // 
            // lb_SelectScanMode1
            // 
            this.lb_SelectScanMode1.AutoSize = true;
            this.lb_SelectScanMode1.ForeColor = System.Drawing.Color.Red;
            this.lb_SelectScanMode1.Location = new System.Drawing.Point(15, 144);
            this.lb_SelectScanMode1.Name = "lb_SelectScanMode1";
            this.lb_SelectScanMode1.Size = new System.Drawing.Size(562, 16);
            this.lb_SelectScanMode1.TabIndex = 30;
            this.lb_SelectScanMode1.Text = "Note: If you select all scan mode, the software will scan all files in the root f" +
    "older and subfolders";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quét tất cả"});
            this.comboBox1.Location = new System.Drawing.Point(18, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_SelectScanMode
            // 
            this.lb_SelectScanMode.AutoSize = true;
            this.lb_SelectScanMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SelectScanMode.Location = new System.Drawing.Point(15, 76);
            this.lb_SelectScanMode.Name = "lb_SelectScanMode";
            this.lb_SelectScanMode.Size = new System.Drawing.Size(182, 16);
            this.lb_SelectScanMode.TabIndex = 24;
            this.lb_SelectScanMode.Text = "Please select scan mode";
            // 
            // lb_instructSetFoder
            // 
            this.lb_instructSetFoder.AutoSize = true;
            this.lb_instructSetFoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_instructSetFoder.Location = new System.Drawing.Point(15, 37);
            this.lb_instructSetFoder.Name = "lb_instructSetFoder";
            this.lb_instructSetFoder.Size = new System.Drawing.Size(446, 16);
            this.lb_instructSetFoder.TabIndex = 23;
            this.lb_instructSetFoder.Text = "Please select the folder where you want to delete duplicate files";
            // 
            // bttselect_all
            // 
            this.bttselect_all.Location = new System.Drawing.Point(110, 163);
            this.bttselect_all.Name = "bttselect_all";
            this.bttselect_all.Size = new System.Drawing.Size(73, 27);
            this.bttselect_all.TabIndex = 22;
            this.bttselect_all.Text = "Select all";
            this.bttselect_all.UseVisualStyleBackColor = true;
            this.bttselect_all.Click += new System.EventHandler(this.bttselect_all_Click);
            // 
            // bttscan
            // 
            this.bttscan.Location = new System.Drawing.Point(18, 163);
            this.bttscan.Name = "bttscan";
            this.bttscan.Size = new System.Drawing.Size(73, 27);
            this.bttscan.TabIndex = 21;
            this.bttscan.Text = "To scan";
            this.bttscan.UseVisualStyleBackColor = true;
            this.bttscan.Click += new System.EventHandler(this.bttscan_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(234, 163);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(73, 27);
            this.bttDelete.TabIndex = 20;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttgetpath
            // 
            this.bttgetpath.BackColor = System.Drawing.Color.Transparent;
            this.bttgetpath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttgetpath.BackgroundImage")));
            this.bttgetpath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttgetpath.Location = new System.Drawing.Point(491, 29);
            this.bttgetpath.Name = "bttgetpath";
            this.bttgetpath.Size = new System.Drawing.Size(41, 32);
            this.bttgetpath.TabIndex = 19;
            this.bttgetpath.UseVisualStyleBackColor = false;
            this.bttgetpath.Click += new System.EventHandler(this.bttgetpath_Click);
            // 
            // lstv_listFileDelete
            // 
            this.lstv_listFileDelete.AutoArrange = false;
            this.lstv_listFileDelete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstv_listFileDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstv_listFileDelete.HideSelection = false;
            this.lstv_listFileDelete.Location = new System.Drawing.Point(3, 205);
            this.lstv_listFileDelete.Name = "lstv_listFileDelete";
            this.lstv_listFileDelete.Size = new System.Drawing.Size(664, 222);
            this.lstv_listFileDelete.TabIndex = 0;
            this.lstv_listFileDelete.UseCompatibleStateImageBehavior = false;
            this.lstv_listFileDelete.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 201;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(634, 667);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 32;
            // 
            // gbx_setting
            // 
            this.gbx_setting.Controls.Add(this.cbb_settingLanguage);
            this.gbx_setting.Controls.Add(this.btt_loseSetting);
            this.gbx_setting.Location = new System.Drawing.Point(325, 58);
            this.gbx_setting.Name = "gbx_setting";
            this.gbx_setting.Size = new System.Drawing.Size(481, 318);
            this.gbx_setting.TabIndex = 36;
            this.gbx_setting.TabStop = false;
            this.gbx_setting.Text = "setting";
            // 
            // cbb_settingLanguage
            // 
            this.cbb_settingLanguage.FormattingEnabled = true;
            this.cbb_settingLanguage.Items.AddRange(new object[] {
            "Vietnam",
            "Enghlis"});
            this.cbb_settingLanguage.Location = new System.Drawing.Point(98, 77);
            this.cbb_settingLanguage.Name = "cbb_settingLanguage";
            this.cbb_settingLanguage.Size = new System.Drawing.Size(181, 24);
            this.cbb_settingLanguage.TabIndex = 1;
            this.cbb_settingLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btt_loseSetting
            // 
            this.btt_loseSetting.Location = new System.Drawing.Point(397, 9);
            this.btt_loseSetting.Name = "btt_loseSetting";
            this.btt_loseSetting.Size = new System.Drawing.Size(75, 23);
            this.btt_loseSetting.TabIndex = 0;
            this.btt_loseSetting.Text = "close";
            this.btt_loseSetting.UseVisualStyleBackColor = true;
            this.btt_loseSetting.Click += new System.EventHandler(this.btt_loseSetting_Click);
            // 
            // lb_language
            // 
            this.lb_language.AutoSize = true;
            this.lb_language.Location = new System.Drawing.Point(0, 0);
            this.lb_language.Name = "lb_language";
            this.lb_language.Size = new System.Drawing.Size(68, 16);
            this.lb_language.TabIndex = 2;
            this.lb_language.Text = "Language";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gbx_lockFoder
            // 
            this.gbx_lockFoder.Controls.Add(this.btt_Browse);
            this.gbx_lockFoder.Controls.Add(this.btt_unlock);
            this.gbx_lockFoder.Controls.Add(this.btt_Lock);
            this.gbx_lockFoder.Controls.Add(this.txtPath);
            this.gbx_lockFoder.Controls.Add(this.lb_foderPathLockfoder);
            this.gbx_lockFoder.Controls.Add(this.label1);
            this.gbx_lockFoder.Location = new System.Drawing.Point(221, 0);
            this.gbx_lockFoder.Name = "gbx_lockFoder";
            this.gbx_lockFoder.Size = new System.Drawing.Size(664, 450);
            this.gbx_lockFoder.TabIndex = 2;
            this.gbx_lockFoder.TabStop = false;
            this.gbx_lockFoder.Text = "Lock foder";
            // 
            // btt_Browse
            // 
            this.btt_Browse.Location = new System.Drawing.Point(545, 173);
            this.btt_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Browse.Name = "btt_Browse";
            this.btt_Browse.Size = new System.Drawing.Size(100, 28);
            this.btt_Browse.TabIndex = 12;
            this.btt_Browse.Text = "....";
            this.btt_Browse.UseVisualStyleBackColor = true;
            this.btt_Browse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btt_unlock
            // 
            this.btt_unlock.Location = new System.Drawing.Point(350, 229);
            this.btt_unlock.Margin = new System.Windows.Forms.Padding(4);
            this.btt_unlock.Name = "btt_unlock";
            this.btt_unlock.Size = new System.Drawing.Size(153, 49);
            this.btt_unlock.TabIndex = 11;
            this.btt_unlock.Text = "Unlock";
            this.btt_unlock.UseVisualStyleBackColor = true;
            this.btt_unlock.Click += new System.EventHandler(this.btt_unlock_Click);
            // 
            // btt_Lock
            // 
            this.btt_Lock.Location = new System.Drawing.Point(151, 229);
            this.btt_Lock.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Lock.Name = "btt_Lock";
            this.btt_Lock.Size = new System.Drawing.Size(143, 49);
            this.btt_Lock.TabIndex = 10;
            this.btt_Lock.Text = "Lock";
            this.btt_Lock.UseVisualStyleBackColor = true;
            this.btt_Lock.Click += new System.EventHandler(this.btt_Lock_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(114, 175);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(421, 22);
            this.txtPath.TabIndex = 9;
            // 
            // lb_foderPathLockfoder
            // 
            this.lb_foderPathLockfoder.AutoSize = true;
            this.lb_foderPathLockfoder.Location = new System.Drawing.Point(21, 179);
            this.lb_foderPathLockfoder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_foderPathLockfoder.Name = "lb_foderPathLockfoder";
            this.lb_foderPathLockfoder.Size = new System.Drawing.Size(79, 16);
            this.lb_foderPathLockfoder.TabIndex = 8;
            this.lb_foderPathLockfoder.Text = "Folder Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOCK FOLDER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.gbx_lockFoder);
            this.Controls.Add(this.gbx_delete);
            this.Controls.Add(this.gbx_setting);
            this.Controls.Add(this.lb_language);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.gbx_delete.ResumeLayout(false);
            this.gbx_delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_setting.ResumeLayout(false);
            this.gbx_lockFoder.ResumeLayout(false);
            this.gbx_lockFoder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete;
        private System.Windows.Forms.ToolStripMenuItem tsm_encryption;
        private System.Windows.Forms.ToolStripMenuItem tsm_setting;
        private System.Windows.Forms.GroupBox gbx_delete;
        private System.Windows.Forms.Label lb_loading;
        private System.Windows.Forms.Label lb_SelectScanMode1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_SelectScanMode;
        private System.Windows.Forms.Label lb_instructSetFoder;
        private System.Windows.Forms.Button bttselect_all;
        private System.Windows.Forms.Button bttscan;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttgetpath;
        private System.Windows.Forms.ListView lstv_listFileDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbx_setting;
        private System.Windows.Forms.Label lb_language;
        private System.Windows.Forms.ComboBox cbb_settingLanguage;
        private System.Windows.Forms.Button btt_loseSetting;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbx_lockFoder;
        private System.Windows.Forms.Button btt_Browse;
        private System.Windows.Forms.Button btt_unlock;
        private System.Windows.Forms.Button btt_Lock;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lb_foderPathLockfoder;
        private System.Windows.Forms.Label label1;
    }
}

