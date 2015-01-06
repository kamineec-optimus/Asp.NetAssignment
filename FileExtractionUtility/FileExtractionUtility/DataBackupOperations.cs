using System;
using System.IO;
using System.Windows.Forms;

namespace FileExtractionUtility
{
    public static class DataBackupOperations
    {
        /// <summary>
        /// Message to be displayed when source folder does not exist
        /// </summary>
        private const string message = "Source folder does not exist";
        private const string backUpMessage = "Backup completed :)";
        private const string getDirectories = "*";
        private const string getFiles = "*.*";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FileExtractionUtility());
        }

        /// <summary>
        /// This method will create the back up of the the files from the selected date
        /// </summary>
        /// <param name="sourcePath">Source path of the files to be backup</param>
        /// <param name="targetPath">Destination path of the files to be back up</param>
        /// <param name="selectedDate">Date from which back up has to be taken</param>
        static public void GetBackUp(string sourcePath, string targetPath, DateTime selectedDate)
        {
            // Check that source folder exist or not
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] directoriesPath = Directory.GetDirectories(sourcePath, getDirectories, SearchOption.AllDirectories);

                // Create all of the directories in the destination 
                foreach (string directoryPath in directoriesPath)
                {
                    DateTime lastWriteTime = Directory.GetLastWriteTime(directoryPath);
                    // Match the modified date of the folder with the date provided by user
                    if (lastWriteTime.Date >= selectedDate.Date)
                    {
                        // Create the directories and replace if already exist with the same name
                        Directory.CreateDirectory(directoryPath.Replace(sourcePath, targetPath));
                    }
                }

                string[] filesPath = Directory.GetFiles(sourcePath, getFiles, SearchOption.AllDirectories);

                // Copy all the files & Replaces any files with the same name
                foreach (string filePath in filesPath)
                {
                    DateTime lastWriteTime = File.GetLastWriteTime(filePath);
                    if (lastWriteTime.Date >= selectedDate.Date)
                    {
                        File.Copy(filePath, filePath.Replace(sourcePath, targetPath), true);
                    }
                }

                MessageBox.Show(backUpMessage);
               

            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
