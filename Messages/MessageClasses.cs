using MVVMcomics.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMcomics.Messages
{
    public class SeriesClicked
    {
        public string Name { get; set; }
         public string Path { get; set; }
         public string Seriesimagepath { get; set; }
         public ObservableCollection<ComicIssue> ListComicIssues { get; set; }
        public SeriesClicked (string name, string path, ObservableCollection<ComicIssue>listComicIssues)
        {
            Name = name;Path = path;ListComicIssues = listComicIssues;
        }
    }
    public class IssueClicked
    {
        public ComicIssue SelectedIssue { get; set; }
        public IssueClicked(ComicIssue selectedIssue)
        {
            SelectedIssue = selectedIssue;
        }
    }
    public class Pageindexchanged
    {
        public int index { get; set; }
        public Pageindexchanged(int pageindex)
        {
            index = pageindex;
        }
    }
    public class StatusMessage
    {
        public StatusMessage(
          string status,
          int timeoutMilliseconds)
        {
            Status = status;
            TimeoutMilliseconds = timeoutMilliseconds;
        }
        public string Status
        {
            get; private set;
        }
        public int TimeoutMilliseconds
        {
            get; private set;
        }
    }
}
