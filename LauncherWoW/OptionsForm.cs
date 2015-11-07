using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWoW
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            chck_autoClose.Checked = Properties.Settings.Default.autoClose;
            chck_cleanCache.Checked = Properties.Settings.Default.cleanCache;
            realmlistTextbox.Text = Properties.Settings.Default.realmlist;
            if (realmlistTextbox.Text == Properties.Settings.Default.realmlist)
            {
                this.realmlistTextbox.BackColor = Color.LawnGreen;
            }
        }

        private void btn_browseWowExe_Click(object sender, EventArgs e)
        {
            OpenFileDialog emplctWow = new OpenFileDialog();
            emplctWow.Title = "Veuillez indiquer l'emplacement de votre Wow.exe";
            emplctWow.Filter = "Fichiers binaires | *.exe";
            emplctWow.InitialDirectory = Environment.SpecialFolder.ProgramFilesX86.ToString();
            emplctWow.CheckFileExists = true;
            emplctWow.ShowDialog();
            if (emplctWow.FileName.ToString() == "")
            {
                DialogResult reponse;
                reponse = MessageBox.Show("Vous devez sélectionner un fichier !", "Fichier Wow.exe introuvable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                Properties.Settings.Default.empltWow = emplctWow.FileName.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void btn_browseCache_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog cacheDirectory = new FolderBrowserDialog();
            cacheDirectory.Description = "Veuillez indiquer où se trouve le dossier de Cache." + "\n" + "Par défaut : Cache\\WDB\\frFR";
            cacheDirectory.RootFolder = Environment.SpecialFolder.ProgramFilesX86;
            cacheDirectory.ShowDialog();
            if (cacheDirectory.SelectedPath == "")
            {
                DialogResult reponse;
                reponse = MessageBox.Show("Vous devez sélectionner un dossier !", "Dossier de Cache introuvable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                Properties.Settings.Default.cacheDirectory = cacheDirectory.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_setRealmlist_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.realmlist = realmlistTextbox.Text;
            if (File.Exists("Data\\frFR\\realmlist.wtf"))
            {
                try
                {
                    System.IO.File.WriteAllText("Data\\frFR\\realmlist.wtf", Properties.Settings.Default.realmlist);
                    this.realmlistTextbox.BackColor = Color.LawnGreen;
                }
                catch (IOException)
                {
                    DialogResult reponse;
                    reponse = MessageBox.Show("Le fichier realmlist.wtf est déjà en cours d'utilisation par un autre processus." + "\n" + "Fermez le et réessayez" + "\n" + "Si le problème persiste, contactez votre administrateur", "Fichier en cours d'utilisation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                DialogResult reponse;
                reponse = MessageBox.Show("Le fichier realmlist.wtf n'a pas été trouvé à l'emplacement Data\\frFR\\realmlist.wtf" + "\n" + "Créez en un et réessayez." + "\n" + "Si le problème persiste, contactez votre administrateur", "Fichier introuvable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_optionsAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_optionsValider_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoClose = chck_autoClose.Checked;
            Properties.Settings.Default.cleanCache = chck_cleanCache.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void realmlistTextbox_TextChanged(object sender, EventArgs e)
        {
            this.realmlistTextbox.BackColor = Color.White;
        }
    }
}
