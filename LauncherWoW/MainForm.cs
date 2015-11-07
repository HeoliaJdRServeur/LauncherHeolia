using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWoW
{
    public partial class MainForm : Form
    {
        private string _MD5Serveur = "";
        private string _patchName = "";
        private string _dataDirectory = Properties.Settings.Default.dataDirectory;
        private string _urlServeur = Properties.Settings.Default.urlServeur;
        private string _urlPatchServer = "http://151.80.12.125/" + Properties.Settings.Default.urlServeur + "/launcher/patch/";
        private string _urlPatchlist = "http://151.80.12.125/" + Properties.Settings.Default.urlServeur + "/launcher/patchlist.txt";
        private string _urlWowExe = "http://151.80.12.125/" + Properties.Settings.Default.urlServeur + "/launcher/exe/Wow.exe";
        private bool _downloadInProgress = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_infoDownload.Text = "";
            Ping testConnection = new Ping();
            try
            {
                // DEBUG : Affichage URL serveur
                //Console.WriteLine(_urlServeur);
                PingReply reply = testConnection.Send(_urlServeur);
                // DEBUG : Etat du ping
                //Console.WriteLine("Etat du ping : " + reply.Status);
                if (reply.Status.ToString() == "Success")
                {
                    webBrowser.Navigate("http://151.80.12.125/" + _urlServeur + "/launcher/web/index.php");
                    DownloadFile(_urlPatchlist, _dataDirectory, "patchlist.txt");
                }
                else
                {
                    label_update.Text = "Erreur réseau : Vérifiez votre connexion internet.";
                    DialogResult reponse;
                    reponse = MessageBox.Show("Impossible de joindre l'hôte distant. Vérifiez que vous êtes bien connecté à internet." + "\n" + "Si le problème persiste, contactez votre administrateur", "Connexion au serveur en échec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
            // PAS DE CONNEXION INTERNET
            catch (PingException)
            {
                label_update.Text = "Erreur réseau : Vérifiez votre connexion internet.";
                DialogResult reponse;
                reponse = MessageBox.Show("Impossible de joindre l'hôte distant. Vérifiez que vous êtes bien connecté à internet." + "\n" + "Si le problème persiste, contactez votre administrateur", "Connexion au serveur en échec",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Méthode allant télécharger le fichier patchlist et regarder ce qu'il y a à faire dans le dossier de jeu
        /// </summary>
        private void DownloadFile(string url, string storage, string fileName)
        {
            WebClient client = new WebClient();
            // Source, destination
            try
            {
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChangedPatchlist);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompletedPatchlist);
                client.DownloadFileAsync(new Uri(url), storage + fileName);
                //client.DownloadFile(new Uri(url), (storage + fileName));
            }
            catch (WebException)
            {
                label_update.Text = "Impossible de récupérer le fichier.";
            }
            catch (FileNotFoundException)
            {
                label_update.Text = "Fichier introuvable.";
            }
        }
        private void client_DownloadFileCompletedPatchlist(object sender, AsyncCompletedEventArgs e)
        {
            label_infoDownload.Text = "";
            ReadPatchList();
        }

        private void client_DownloadProgressChangedPatchlist(object sender, DownloadProgressChangedEventArgs e)
        {
            label_infoDownload.Text = "Téléchargement du fichier patchlist.txt en cours";
        }

        private void ReadPatchList()
        {
            try
            {
                string[] lines = File.ReadAllLines(_dataDirectory + "patchlist.txt");
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(new Char[] { ',' });
                    _patchName = data[0];
                    _MD5Serveur = data[1];
                    if (data[2] == "1") // Patch à télécharger
                    {
                        if (!NeedUpdate(data[0]) && !_downloadInProgress) // Si pas besoin de MAJ et pas de DL en cours ...
                        {
                            btn_play.Enabled = true;
                            updateBar.Visible = false;
                            label_update.Text = "";
                            label_infoDownload.Text = "";
                        }
                        else if (NeedUpdate(data[0]) && !_downloadInProgress) // Si besoin de MAJ
                        {
                            _downloadInProgress = true;
                            webBrowser.Navigate("http://151.80.12.125/" + _urlServeur + "/launcher/web/patch-notes.php");
                            label_infoDownload.Text = "Téléchargement du " + data[0] + " en cours...";
                            DownloadMPQFile((_urlPatchServer + data[0]), _dataDirectory, data[0]);
                        }
                    }
                    else if (data[2] == "0") // Patch à supprimer
                    {
                        DeletePatch(data[2]);
                    }
                    // DEBUG : AFFICHAGE MD5 SERVEUR
                    //Console.WriteLine(_MD5Serveur);
                    //Console.WriteLine(_patchName);
                    //Console.WriteLine("Valeur du champ suppression : " + data[2]);
                }
            }
            catch (FileNotFoundException)
            {
                DialogResult reponse;
                reponse = MessageBox.Show("Le fichier patchlist.txt est introuvable.", "Fichier introuvable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            catch (DirectoryNotFoundException)
            {
                DialogResult reponse;
                reponse = MessageBox.Show("Le Launcher doit se trouver dans votre dossier de jeu !", "Dossier Data introuvable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Méthode vérifiant si le jeu du client doit être mis à jour ou non
        /// </summary>
        /// <returns></returns>
        private bool NeedUpdate(string patchName)
        {
            if (!File.Exists(_dataDirectory + patchName))
            {
                // DEBUG : VERIFIE PRESENCE PATCH
                //Console.WriteLine("Patch inexistant");
                return true;
            }
            else if (MD5Compare(_MD5Serveur, _dataDirectory + patchName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Compare les empreintes MD5 sous forme de chaine de caractères
        /// </summary>
        /// <param name="clefMD5Serveur"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool MD5Compare(string clefMD5Serveur, string filename)
        {
            // Si la comparaison échoue
            if (GenerateMD5HashFromFile(filename) != clefMD5Serveur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Génère l'empreinte MD5 du patch du dossier de jeu
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GenerateMD5HashFromFile(string filename)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var buffer = md5.ComputeHash(File.ReadAllBytes(filename));
                var sb = new StringBuilder();
                for (int i = 0; i < buffer.Length; i++)
                {
                    sb.Append(buffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public void DownloadMPQFile(string url, string storage, string fileName)
        {
            btn_play.Enabled = false;
            updateBar.Visible = true;

            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(url), storage + fileName);
        }

        /// <summary>
        /// Permet l'affichage de la progression du téléchargement sur la Progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            // BYTES = OCTETS
            //updateBar.Cursor = Cursors.WaitCursor;
            // DEBUG : Taille du patch à DL en Ko
            //Console.WriteLine((totalBytes / 1024));
            label_update.Text = (bytesIn / 1024).ToString("0.00") + " Ko/ " + (totalBytes / 1024).ToString("0.00") + " Ko ( " + Math.Truncate(percentage).ToString() + "% )";
            updateBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        /// <summary>
        /// Actions lorsque le téléchargement est terminé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Play.Enabled = true;
            //labelUpdate.Text = "Votre jeu est à jour";
            //infoDownload.Text = "";
            _downloadInProgress = false;
            ReadPatchList();
        }

        /// <summary>
        /// Supprime tous les fichiers .wdb du dossier de cache
        /// </summary>
        public void CleanCache()
        {
            try
            {
                // DEBUG : Emplacement cache
                //Console.WriteLine("Cache : "+Properties.Settings.Default.cacheDirectory);
                foreach (string filePath in Directory.GetFiles(Properties.Settings.Default.cacheDirectory, "*.wdb"))
                {
                    File.Delete(filePath);
                }
            }
            catch (DirectoryNotFoundException)
            {
                DialogResult reponse;
                reponse = MessageBox.Show("Le Launcher doit se trouver dans votre dossier de jeu !" + "\n" + "Votre cache n'a pas été vidé.", "Dossier de Cache introuvable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Supprime les patchs dans le dossier de jeu si spécifié dans le patchlist.txt
        /// </summary>
        /// <param name="patchName"></param>
        public void DeletePatch(string patchName)
        {
            File.Delete("Data\\" + patchName);
        }
        private void btn_options_Click(object sender, EventArgs e)
        {
            OptionsForm about = new OptionsForm();
            about.ShowInTaskbar = false;
            about.ShowDialog();
        }

        private void btn_changelog_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://151.80.12.125/" + _urlServeur + "/launcher/web/patch-notes.php");
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowInTaskbar = false;
            about.ShowDialog();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.empltWow);
            }
            catch (Win32Exception)
            {
                OpenFileDialog emplctWow = new OpenFileDialog();
                do
                {
                    emplctWow.Title = "Veuillez indiquer l'emplacement de votre Wow.exe";
                    emplctWow.Filter = "Fichiers binaires | *.exe";
                    emplctWow.InitialDirectory = Environment.SpecialFolder.ProgramFilesX86.ToString();
                    emplctWow.ShowDialog();
                    Properties.Settings.Default.empltWow = emplctWow.FileName.ToString();
                    Properties.Settings.Default.Save();
                }
                while (emplctWow.FileName.ToString() == "");
                System.Diagnostics.Process.Start(emplctWow.FileName);
                // DEBUG : AFFICHAGE EMPLACEMENT APRES SAUVEGARDE
                //Console.WriteLine("Emplacement : " + _wowExe);
            }
            catch (System.InvalidOperationException)
            {
                OpenFileDialog emplctWow = new OpenFileDialog();
                do
                {
                    emplctWow.Title = "Veuillez indiquer l'emplacement de votre Wow.exe";
                    emplctWow.Filter = "Fichiers binaires | *.exe";
                    emplctWow.InitialDirectory = Environment.SpecialFolder.ProgramFilesX86.ToString();
                    emplctWow.ShowDialog();
                    Properties.Settings.Default.empltWow = emplctWow.FileName.ToString();
                    Properties.Settings.Default.Save();
                }
                while (emplctWow.FileName.ToString() == "");
                System.Diagnostics.Process.Start(emplctWow.FileName);
            }
            if (Properties.Settings.Default.cleanCache) // Si le joueur veut nettoyer le cache avant le lancement
                CleanCache();
            if (Properties.Settings.Default.autoClose) // Si le joueur veut fermer le launcher après le lancement
                Close();
            File.Delete("Data\\patchlist.txt");
        }

        /// <summary>
        /// Méthode magique pour forcer les liens à s'ouvrir avec le navigateur par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            HtmlElement Link = webBrowser.Document.ActiveElement;
            String Url = Link.GetAttribute("href");
            e.Cancel = !Url.Equals("");
            if (e.Cancel)
            {
                if (!Url.StartsWith("//") && Url.StartsWith("/"))
                {
                    Url = webBrowser.Url.Host + Url;
                };
                Process.Start(Url);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
