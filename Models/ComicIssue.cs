using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MVVMcomics.Messages;
using MVVMcomics.Models;
using Windows.Storage;

namespace MVVMcomics.Models
{
    public class ComicIssue : ObservableObject
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Seriesimagepath { get; set; }
        public StorageFolder TempFolderroot { get; set; }
        public StorageFolder IssueTempFolder { get; set; }
        StorageFile Comicfile { get; set; }
        StorageFile ExtractFile { get; set; }
        public ObservableCollection<StorageFile> Pages { get; set; }
        
        
        public async Task<ObservableCollection<StorageFile>> getExtractedPages (StorageFolder folder)
        {
            ObservableCollection<StorageFile> thesePages = new ObservableCollection<StorageFile>();
            IReadOnlyList<StorageFolder> extractedFolders = await folder.GetFoldersAsync();
            foreach (StorageFolder subdir in extractedFolders)
            {
                IReadOnlyList<StorageFile> extractedFiles = await folder.GetFilesAsync();
                foreach (StorageFile aFile in extractedFiles)
                {
                    if (aFile.FileType == ".jpg")
                    {
                        thesePages.Add(aFile);
                        Debug.WriteLine(aFile.DisplayName);
                    }
                }
            }
            return thesePages;
        }

        public async Task decompressComic (string archivePath)
        {
            StorageFile storageFileArchive = await StorageFile.GetFileFromPathAsync(archivePath);
            Stream readArchiveStream = await storageFileArchive.OpenStreamForReadAsync();
            StorageFolder TempFolderroot = ApplicationData.Current.TemporaryFolder;
            Debug.WriteLine("temp folder path is");
            Debug.WriteLine(TempFolderroot.Path);
            var rnd = new Random();
            string newRND = (rnd.Next(100)).ToString();
            StorageFolder IssueTempFolder = await TempFolderroot.CreateFolderAsync(newRND);
            Debug.WriteLine(IssueTempFolder.Path);
            // using (Stream stream = File.OpenRead(Path))
            //using (var reader = ReaderFactory.Open(stream))
            //{
            //   while (reader.MoveToNextEntry())
            // {
            //   if (!reader.Entry.IsDirectory)
            // {
            //   Debug.WriteLine(reader.Entry.Key);
            // StorageFile extractfile = await IssueTempFolder.CreateFileAsync(reader.Entry.Key);
            //System.IO.Stream writestream = (await extractfile.OpenAsync(FileAccessMode.ReadWrite)).AsStream();
            //reader.WriteEntryTo(writestream);                        
            //}
            //}
            //}
            ZipFile.ExtractToDirectory(storageFileArchive.Path, IssueTempFolder.Path);
            }



        



    }
}
