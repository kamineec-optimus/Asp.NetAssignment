using System;
using System.IO;
using System.Windows.Forms;

namespace FileExtractionUtility
{
    public partial class FileExtractionUtility : Form
    {
       #region Public Methods 
        public FileExtractionUtility()
        {
            InitializeComponent();
        } 
        #endregion

       #region Private Methods
       /// <summary>
       /// Show File browser to browse the source folder
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void btnSourceBrowse_Click(object sender, EventArgs e)
       {
           // Show the dialog to select the source folder
           DialogResult dialogResult = sourceFolder.ShowDialog();
           if (dialogResult == DialogResult.OK)
           {
               txtSourceFolder.Text = sourceFolder.SelectedPath;
           }
       }

       /// <summary>
       /// Show File browser to browse the destination folder
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void btnDestinationBrowse_Click(object sender, EventArgs e)
       {
           // Show the dialog to select the destination folder
           DialogResult dialogResult = destinationFolder.ShowDialog();
           if (dialogResult == DialogResult.OK)
           {
               txtDestinationFolder.Text = destinationFolder.SelectedPath;
           }
       }

       /// <summary>
       ///  Submit button clicked event
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void btnSubmit_Click(object sender, EventArgs e)
       {
           // Call GetBackUp of DataBackupOperations to perform back up task
           DataBackupOperations.GetBackUp(txtSourceFolder.Text, txtDestinationFolder.Text, selectDate.Value);
           this.Close();

       } 
       #endregion
            
    }
}
