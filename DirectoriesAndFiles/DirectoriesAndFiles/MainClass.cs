using System;
using System.Linq;
using System.IO;
using System.IO.Compression;

namespace DirectoriesAndFiles
{
    class FileHandling
    { 
        /// <summary>
        /// Path of the File
        /// </summary>
        private const string FilePath  = @"C:\FileHandling\FileRead.txt";
        /// <summary>
        /// Name of the drive
        /// </summary>
        private const string DriveName ="C";
        /// <summary>
        /// print Availalble free space
        /// </summary>
        private const string FreeSpace ="Available Free Space : {0}";
        /// <summary>
        /// print Total free Space
        /// </summary>
        private const string TotalSpace  ="Toatal Free Space : {0}";
        /// <summary>
        /// print Total size 
        /// </summary>
        private const string Totalsize = "Total Size : {0}";
        /// <summary>
        /// print Format of the drive
        /// </summary>
        private const string DriveFormat ="Drive Format : {0}";
        /// <summary>
        /// print Type of the drive
        /// </summary>
        private const string DriveType ="Drive Type : {0}";
        /// <summary>
        /// Print Name of the file
        /// </summary>
        private const string NameFile = "Name : {0}";
        /// <summary>
        /// Print root directory of the file
        /// </summary>
        private const string RootDirectory ="Root Directory : {0}";
        /// <summary>
        /// display volume label
        /// </summary>
        private const string VolumeLabel ="Volume Label : {0}";
        /// <summary>
        /// Show information is ready
        /// </summary>
        private const string Info  ="Info Is Ready : {0}";
        /// <summary>
        /// Create a folder in c drive
        /// </summary>
        private const string CreateFolder =@"C:\FileHandling\";
        /// <summary>
        /// print newly created directory
        /// </summary>
        private const string NewDirectory ="Newly Created Directory : {0}";
        /// <summary>
        /// print newly created File
        /// </summary>
        private const string NewFile ="Newly Created File : {0}";
        /// <summary>
        /// Path of the directory
        /// </summary>
        private const string DirectorysPath = "Directory Path : {0}";
        /// <summary>
        /// path of the file to read
        /// </summary>
        private const string ReadFromFile  = @"C:\FileHandling\FileRead.txt";
        /// <summary>
        /// Text of the file
        /// </summary>
        private const string FileText= "FileRead Text : {0}";
        /// <summary>
        /// compress file extension
        /// </summary>
        private const string CompressFile = ".gz";
        /// <summary>
        /// add file
        /// </summary>
        private const string AddFile = "{0} {1}";
        /// <summary>
        /// Information of the file
        /// </summary>
        private const string FileInfo = @"C:\FileHandling\ {0} .gz";
        /// <summary>
        /// Compressed file
        /// </summary>
        private const string CompressedFile="Compressed {0} from {1} to {2} bytes.";

       static void Main(string[] args)
        {
            /// call method CDriveInfo
            CDriveInfo();
           ///Call method to create a new directory
            NewlyCreatedDirectory();
           /// call method to create a file
            NewlyCreatedFile();
           ///call method to Get directory Path
            DirectoryPath();
           /// call method to set file access
            SetFileReadAccess(FilePath, true);
           ///Call method to comprees the file
            FileCompress();
           ///Call method to read write to the file
            FileReadWrite();
            Console.ReadLine();
        }

        /// <summary>
        /// method to get drive info
        /// </summary>
        public static void CDriveInfo()
        {
            DriveInfo info = new DriveInfo(DriveName);

            /// Print sizes.
            Console.WriteLine(FreeSpace,info.AvailableFreeSpace);
            Console.WriteLine(TotalSpace, info.TotalFreeSpace);
            Console.WriteLine(Totalsize, info.TotalSize);
            Console.WriteLine();

            /// Format and type.
            Console.WriteLine(DriveFormat, info.DriveFormat);
            Console.WriteLine(DriveType, info.DriveType);
            Console.WriteLine();

            // Name and directories.
            Console.WriteLine(NameFile, info.Name);
            Console.WriteLine(RootDirectory, info.RootDirectory);
            Console.WriteLine(VolumeLabel, info.VolumeLabel);
            Console.WriteLine();

            // Ready.
            Console.WriteLine(Info,info.IsReady);
        }

        /// <summary>
        /// method to get newely created directory
        /// </summary>
        public static void NewlyCreatedDirectory()
        {
            DateTime lastHigh = new DateTime(1900, 1, 1);
            string highDir = string.Empty; ;
            foreach (string subdir in Directory.GetDirectories(CreateFolder))//Create A Folder In C Drive Name FileHandling In This Case.
            {
                DirectoryInfo fi1 = new DirectoryInfo(subdir);
                DateTime created = fi1.LastWriteTime;

                if (created > lastHigh)
                {
                    highDir = subdir;
                    lastHigh = created;
                }
            }

            Console.WriteLine(NewDirectory, highDir);
        }

        /// <summary>
        /// method to get newly created file
        /// </summary>
        public static void NewlyCreatedFile()
        {
            var directory = new DirectoryInfo(CreateFolder);
            var myFile = directory.GetFiles()
                         .OrderByDescending(f => f.LastWriteTime)
                         .First();

            Console.WriteLine(NewFile, myFile);
        }

        /// <summary>        
        /// get directory path
        /// </summary>
        public static void DirectoryPath()
        {
            string path = Path.GetFullPath(CreateFolder);
            Console.WriteLine(DirectorysPath, path);
        }
        /// <summary>
        /// Method to set file read access
        /// </summary>
        /// <param name="FileName">Name of the file</param>
        /// <param name="SetReadOnly">Set read only access</param>
        public static void SetFileReadAccess(string FileName, bool SetReadOnly)
        {
            FileInfo fInfo = new FileInfo(FileName);

            // Set the IsReadOnly property.
            fInfo.IsReadOnly = SetReadOnly;
        }
        /// <summary>
        /// read/write to the file
        /// </summary>
        public static void FileReadWrite()
        {
            string text = System.IO.File.ReadAllText(ReadFromFile);
            Console.WriteLine(FileText, text);
            System.IO.File.WriteAllText(ReadFromFile, text);
        }
        /// <summary>
        /// compress the file
        /// </summary>
        public static void compressFile()
        {
            MemoryStream memory = new MemoryStream();
            GZipStream gzip = new GZipStream(memory, CompressionMode.Compress, true);
        }
        /// <summary>
        /// compress the file
        /// </summary>
        public static void FileCompress()
        {
            FileInfo fileToCompress = new FileInfo(ReadFromFile);
            using (FileStream originalFileStream = fileToCompress.OpenRead())
            {
                if ((File.GetAttributes(fileToCompress.FullName) &
                   FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != CompressFile)
                {
                    using (FileStream compressedFileStream = File.Create(string.Format(AddFile, fileToCompress.FullName, CompressFile)))
                    {
                        
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                           CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);

                        }
                    }
                    ///create the object of file info 
                    FileInfo info = new FileInfo(string.Format(FileInfo, fileToCompress.Name));
                    ///print the fiel detail
                    Console.WriteLine(CompressedFile,fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
                }

            }
        }
        }
    }

