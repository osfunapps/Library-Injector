using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Config_Maker.project;
using Library_Injector.Properties;

namespace Library_Injecter
{
    public partial class LibraryForm : Form, FilesInjecterCallback
    {
        private string DONE_MESSAGE = "Done! read output window to see changes :)";

        public LibraryForm()
        {
            InitializeComponent();
            LoadPreviousParams();
        }

        private void LoadPreviousParams()
        {
            libraryFileTB.Text = Settings.Default.libraryFilePath;
            projectsRootTB.Text = Settings.Default.projectsRoot;
        }

        private void outputFolderDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void outputFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                projectsRootTB.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void logBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Logger.GetTxt(), Logger.TITLE);
        }

        private void pythonPathDialog_FileOk(object sender, CancelEventArgs e)
        {
            libraryFileTB.Text = TitleExporter(sender.ToString());
        }

        private string TitleExporter(string fileLongStr)
        {
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 10);

        }

        private void libraryFileBrowse_Click(object sender, EventArgs e)
        {
            pythonPathDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (libraryFileTB.Text == "" || projectsRootTB.Text == "")
            {
                MessageBox.Show("hmm.. something is missing...");
                return;
            }
            FilesInjecter filesInjecter = new FilesInjecter();
            filesInjecter.AlterFiles(this, outputRTB, projectsRootTB.Text, libraryFileTB.Text);
            //filesInjecter.AlterFiles("C:\\search here\\entries", "C:\\search here\\generalremotelib-release.aar");
        }

        public void onInjectDone()
        {
            MessageBox.Show(DONE_MESSAGE, Logger.TITLE);
        }

        private void projectsRootTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void projectsRootDropHandler(object sender, DragEventArgs e)
        {
            projectsRootTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void LibraryFileDropHandler(object sender, DragEventArgs e)
        {
            libraryFileTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void outputRTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
