namespace LauncherWoW
{
    partial class OptionsForm
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
            this.realmlistTextbox = new System.Windows.Forms.TextBox();
            this.btn_setRealmlist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_browseCache = new System.Windows.Forms.Button();
            this.btn_browseWowExe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_optionsAnnuler = new System.Windows.Forms.Button();
            this.btn_optionsValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chck_cleanCache = new System.Windows.Forms.CheckBox();
            this.chck_autoClose = new System.Windows.Forms.CheckBox();
            this.autoClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // realmlistTextbox
            // 
            this.realmlistTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.realmlistTextbox.Location = new System.Drawing.Point(171, 126);
            this.realmlistTextbox.Name = "realmlistTextbox";
            this.realmlistTextbox.Size = new System.Drawing.Size(176, 20);
            this.realmlistTextbox.TabIndex = 27;
            this.realmlistTextbox.Text = "Realmlist";
            this.realmlistTextbox.TextChanged += new System.EventHandler(this.realmlistTextbox_TextChanged);
            // 
            // btn_setRealmlist
            // 
            this.btn_setRealmlist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_setRealmlist.Location = new System.Drawing.Point(353, 123);
            this.btn_setRealmlist.Name = "btn_setRealmlist";
            this.btn_setRealmlist.Size = new System.Drawing.Size(75, 23);
            this.btn_setRealmlist.TabIndex = 26;
            this.btn_setRealmlist.Text = "Appliquer";
            this.btn_setRealmlist.UseVisualStyleBackColor = true;
            this.btn_setRealmlist.Click += new System.EventHandler(this.btn_setRealmlist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Realmlist du serveur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Emplacement du dossier de Cache";
            // 
            // btn_browseCache
            // 
            this.btn_browseCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_browseCache.Location = new System.Drawing.Point(353, 87);
            this.btn_browseCache.Name = "btn_browseCache";
            this.btn_browseCache.Size = new System.Drawing.Size(75, 23);
            this.btn_browseCache.TabIndex = 23;
            this.btn_browseCache.Text = "Parcourir ...";
            this.btn_browseCache.UseVisualStyleBackColor = true;
            this.btn_browseCache.Click += new System.EventHandler(this.btn_browseCache_Click);
            // 
            // btn_browseWowExe
            // 
            this.btn_browseWowExe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_browseWowExe.Location = new System.Drawing.Point(353, 58);
            this.btn_browseWowExe.Name = "btn_browseWowExe";
            this.btn_browseWowExe.Size = new System.Drawing.Size(75, 23);
            this.btn_browseWowExe.TabIndex = 22;
            this.btn_browseWowExe.Text = "Parcourir ...";
            this.btn_browseWowExe.UseVisualStyleBackColor = true;
            this.btn_browseWowExe.Click += new System.EventHandler(this.btn_browseWowExe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Emplacement Wow.exe";
            // 
            // btn_optionsAnnuler
            // 
            this.btn_optionsAnnuler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_optionsAnnuler.Location = new System.Drawing.Point(272, 160);
            this.btn_optionsAnnuler.Name = "btn_optionsAnnuler";
            this.btn_optionsAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btn_optionsAnnuler.TabIndex = 20;
            this.btn_optionsAnnuler.Text = "Annuler";
            this.btn_optionsAnnuler.UseVisualStyleBackColor = true;
            this.btn_optionsAnnuler.Click += new System.EventHandler(this.btn_optionsAnnuler_Click);
            // 
            // btn_optionsValider
            // 
            this.btn_optionsValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_optionsValider.Location = new System.Drawing.Point(353, 160);
            this.btn_optionsValider.Name = "btn_optionsValider";
            this.btn_optionsValider.Size = new System.Drawing.Size(75, 23);
            this.btn_optionsValider.TabIndex = 19;
            this.btn_optionsValider.Text = "Valider";
            this.btn_optionsValider.UseVisualStyleBackColor = true;
            this.btn_optionsValider.Click += new System.EventHandler(this.btn_optionsValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vider le cache au lancement du jeu";
            // 
            // chck_cleanCache
            // 
            this.chck_cleanCache.AutoSize = true;
            this.chck_cleanCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_cleanCache.Location = new System.Drawing.Point(353, 35);
            this.chck_cleanCache.Name = "chck_cleanCache";
            this.chck_cleanCache.Size = new System.Drawing.Size(15, 14);
            this.chck_cleanCache.TabIndex = 17;
            this.chck_cleanCache.UseVisualStyleBackColor = true;
            // 
            // chck_autoClose
            // 
            this.chck_autoClose.AutoSize = true;
            this.chck_autoClose.Checked = true;
            this.chck_autoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_autoClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chck_autoClose.Location = new System.Drawing.Point(353, 8);
            this.chck_autoClose.Name = "chck_autoClose";
            this.chck_autoClose.Size = new System.Drawing.Size(15, 14);
            this.chck_autoClose.TabIndex = 16;
            this.chck_autoClose.UseVisualStyleBackColor = true;
            // 
            // autoClose
            // 
            this.autoClose.AutoSize = true;
            this.autoClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.autoClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.autoClose.Location = new System.Drawing.Point(12, 5);
            this.autoClose.Name = "autoClose";
            this.autoClose.Size = new System.Drawing.Size(259, 17);
            this.autoClose.TabIndex = 15;
            this.autoClose.Text = "Fermer le launcher au lancement du jeu";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 197);
            this.Controls.Add(this.realmlistTextbox);
            this.Controls.Add(this.btn_setRealmlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_browseCache);
            this.Controls.Add(this.btn_browseWowExe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_optionsAnnuler);
            this.Controls.Add(this.btn_optionsValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chck_cleanCache);
            this.Controls.Add(this.chck_autoClose);
            this.Controls.Add(this.autoClose);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox realmlistTextbox;
        private System.Windows.Forms.Button btn_setRealmlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_browseCache;
        private System.Windows.Forms.Button btn_browseWowExe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_optionsAnnuler;
        private System.Windows.Forms.Button btn_optionsValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chck_cleanCache;
        private System.Windows.Forms.CheckBox chck_autoClose;
        private System.Windows.Forms.Label autoClose;
    }
}