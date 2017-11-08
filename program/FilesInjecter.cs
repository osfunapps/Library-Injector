using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Library_Injector.Properties;

namespace Library_Injecter
{
    internal class FilesInjecter
    {
        private static string cppScript = "\"" + Directory.GetCurrentDirectory() + "\\cpp script files\\" + "Library Injecter Helper.exe\"";
        private FilesInjecterCallback callback;

        public void AlterFiles(FilesInjecterCallback callback, RichTextBox outputRTB, string projectsRoot, string libraryFilePath)
        {
            this.callback = callback;
            SaveParams(projectsRoot, libraryFilePath);
            projectsRoot = FormatString(projectsRoot);
            libraryFilePath = FormatString(libraryFilePath);
            RunCmd(projectsRoot, libraryFilePath, outputRTB);

        }

      private void SaveParams(string projectsRoot, string libraryFilePath)
        {
            Settings.Default.Upgrade();
            Settings.Default.projectsRoot = projectsRoot;
            Settings.Default.libraryFilePath = libraryFilePath;
            Settings.Default.Save();
        }


        private void RunCmd(string projectRoot, string libraryFilePath, RichTextBox outputRtb)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cppScript;

            //project root and then library file path
            start.Arguments = projectRoot + libraryFilePath;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    outputRtb.Text = reader.ReadToEnd();
                }
            }

            callback.onInjectDone();

        }

        private string FormatString(string inputStr)
        {
            return " \"" + inputStr + "\"";
        }


    }

    public interface FilesInjecterCallback
    {
        void onInjectDone();
    }
}