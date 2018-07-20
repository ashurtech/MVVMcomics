using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Storage;
namespace MVVMcomics.Models
{
    public class ComicSeries
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Seriesimagepath { get; set; }
        public ObservableCollection<ComicIssue> ListComicIssues { get; set; }

        public static ObservableCollection<ComicSeries> GetSomeComics()
        {
            ObservableCollection<ComicSeries> comicserieslist = new ObservableCollection<ComicSeries>();
            ObservableCollection<ComicIssue> testlist = new ObservableCollection<ComicIssue>();
            testlist.Add(new ComicIssue
            {
                Name = "Venom 3 (2018)",
                Path = @"\\FREENAS\Vault\comics\Venom (2018)\Venom 3 (2018).cbz",
                Seriesimagepath = @"\\FREENAS\Vault\comics\Venom (2018)\cover.jpg"
            });
            comicserieslist.Add(new ComicSeries
            {
                    Name = "Venom",
                    Path = @"\\FREENAS\Vault\comics\Venom (2018)",
                    Seriesimagepath = @"\\FREENAS\Vault\comics\Venom (2018)\cover.jpg",
                    ListComicIssues = testlist
            });
            comicserieslist.Add(new ComicSeries
            {
                Name = "This Damned Band",
                Path = @"\\FREENAS\Vault\comics\This Damned Band(2015)",
                Seriesimagepath = @"\\FREENAS\Vault\comics\This Damned Band(2015)\cover.jpg"
            });
            comicserieslist.Add(new ComicSeries
            {
                Name = "Moon Girl and Devil Dinosaur",
                Path = @"\\FREENAS\Vault\comics\Moon Girl and Devil Dinosaur (2015)",
                Seriesimagepath = @"\\FREENAS\Vault\comics\Moon Girl and Devil Dinosaur (2015)\cover.jpg"
            });
            comicserieslist.Add(new ComicSeries
            {
                Name = "Daredevil",
                Path = @"\\FREENAS\Vault\comics\Daredevil (2015)",
                Seriesimagepath = @"\\FREENAS\Vault\comics\Daredevil (2015)\cover.jpg"
            });

            return comicserieslist;
        }
       public static async Task<ObservableCollection<ComicSeries>> AsyncGetComicsFromPath()
        {
            ObservableCollection<ComicSeries> comicserieslist = new ObservableCollection<ComicSeries>();
            var comicsPath = @"\\FREENAS\Vault\Comics";
            StorageFolder comicRootFolder = await StorageFolder.GetFolderFromPathAsync(comicsPath);
            IReadOnlyList<StorageFolder> folderList = await comicRootFolder.GetFoldersAsync();

            foreach (StorageFolder folder in folderList)
            {
                Debug.WriteLine("dir is" + folder.Name);
                bool isValidComicFolder = false;
                StorageFolder thisComicSeriesFolder = await StorageFolder.GetFolderFromPathAsync(folder.Path);
                IReadOnlyList<StorageFile> thisfileList = await thisComicSeriesFolder.GetFilesAsync();
                ObservableCollection<ComicIssue> templist = new ObservableCollection<ComicIssue>();
                foreach (StorageFile afile in thisfileList)
                {
                    if (afile.FileType == ".cbz" ) //|| afile.FileType == ".cbr")
                    {
                        isValidComicFolder = true;
                        templist.Add(new ComicIssue
                        {
                            Name = afile.DisplayName,
                            Path = afile.Path,
                            Seriesimagepath = folder.Path + @"\cover.jpg"
                        });

                    }
                }
                if (isValidComicFolder == true)
                {
                    comicserieslist.Add(new ComicSeries
                    {
                        Name = folder.DisplayName,
                        Path = folder.Path,
                        Seriesimagepath = folder.Path + @"\cover.jpg",
                        ListComicIssues = templist
                    }
                    );
                };
            }
            Debug.WriteLine("got all the things");
            return comicserieslist;
        }
        public static async Task<ObservableCollection<ComicIssue>> AsyncGetIssuesFromPath(string seriespath)
        {
            ObservableCollection<ComicIssue> comicissuelist = new ObservableCollection<ComicIssue>();
            StorageFolder seriesRootFolder = await StorageFolder.GetFolderFromPathAsync(seriespath);
            IReadOnlyList<StorageFile> filelist = await seriesRootFolder.GetFilesAsync();

            foreach (StorageFile file in filelist)
            {
                if (file.FileType == ".cbz" || file.FileType == ".cbr")
                {
                    comicissuelist.Add(new ComicIssue
                        {
                           Name = file.Name,
                           Path = file.Path,
                           Seriesimagepath = (seriespath + @"\cover.jpg")
                        }
                        );
                }
            }


            return comicissuelist;
        }
    }
}
