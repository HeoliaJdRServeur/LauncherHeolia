namespace LauncherWoW
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.updateBar = new System.Windows.Forms.ProgressBar();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_changelog = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.label_infoDownload = new System.Windows.Forms.Label();
            this.label_update = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(800, 580);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser_NewWindow);
            // 
            // updateBar
            // 
            this.updateBar.BackColor = System.Drawing.Color.Black;
            this.updateBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.updateBar.Location = new System.Drawing.Point(22, 511);
            this.updateBar.Name = "updateBar";
            this.updateBar.Size = new System.Drawing.Size(646, 17);
            this.updateBar.TabIndex = 14;
            // 
            // btn_play
            // 
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_play.Location = new System.Drawing.Point(688, 511);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(100, 44);
            this.btn_play.TabIndex = 10;
            this.btn_play.Text = "Jouer";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_about
            // 
            this.btn_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_about.Image = global::LauncherWoW.Properties.Resources.button1;
            this.btn_about.Location = new System.Drawing.Point(236, 534);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(21, 21);
            this.btn_about.TabIndex = 13;
            this.btn_about.Text = "?";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_changelog
            // 
            this.btn_changelog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_changelog.Image = global::LauncherWoW.Properties.Resources.button1;
            this.btn_changelog.Location = new System.Drawing.Point(129, 534);
            this.btn_changelog.Name = "btn_changelog";
            this.btn_changelog.Size = new System.Drawing.Size(98, 21);
            this.btn_changelog.TabIndex = 12;
            this.btn_changelog.Text = "Changelog";
            this.btn_changelog.UseVisualStyleBackColor = true;
            this.btn_changelog.Click += new System.EventHandler(this.btn_changelog_Click);
            // 
            // btn_options
            // 
            this.btn_options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_options.Image = global::LauncherWoW.Properties.Resources.button1;
            this.btn_options.Location = new System.Drawing.Point(22, 534);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(98, 21);
            this.btn_options.TabIndex = 11;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // label_infoDownload
            // 
            this.label_infoDownload.AutoSize = true;
            this.label_infoDownload.BackColor = System.Drawing.Color.Black;
            this.label_infoDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoDownload.ForeColor = System.Drawing.Color.White;
            this.label_infoDownload.Location = new System.Drawing.Point(283, 495);
            this.label_infoDownload.Name = "label_infoDownload";
            this.label_infoDownload.Size = new System.Drawing.Size(64, 13);
            this.label_infoDownload.TabIndex = 16;
            this.label_infoDownload.Text = "Informations";
            // 
            // label_update
            // 
            this.label_update.AutoSize = true;
            this.label_update.BackColor = System.Drawing.Color.Black;
            this.label_update.ForeColor = System.Drawing.Color.White;
            this.label_update.Location = new System.Drawing.Point(31, 495);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(0, 13);
            this.label_update.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.label_infoDownload);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.updateBar);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_changelog);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ProgressBar updateBar;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_changelog;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Label label_infoDownload;
        private System.Windows.Forms.Label label_update;
    }
}

