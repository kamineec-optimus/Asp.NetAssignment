using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileExtractionUtility;

namespace TestBackUpUtility
{
    [TestClass]
    public class BackUpTest
    {
        /// <summary>
        /// Const string used in testing
        /// </summary>
        private const string sourcePath = @"D:\backup";
        private const string destinationPath = @"D:\BackUp2";
        private const string invalidFolderPath = @"D:\backup\BackUp";
        private DateTime selectedDate = DateTime.Parse("12/26/2014");
        
        /// <summary>
        /// Test method to test backup according to date provided
        /// </summary>
        [TestMethod]
        public void CopyFilesAsPerDateProvided()
        {
            try
            {
                DataBackupOperations.GetBackUp(sourcePath, destinationPath, selectedDate);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method to test if user provided an invalid path
        /// </summary>
        [TestMethod]
        public void TestIfSourceFolderDoesNotExist()
        {
            try
            {
                DataBackupOperations.GetBackUp(invalidFolderPath, destinationPath, selectedDate);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
