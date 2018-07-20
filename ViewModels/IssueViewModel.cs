using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Input;
using App3.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMcomics.Messages;
using MVVMcomics.Models;
using MVVMcomics.Views;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace MVVMcomics.ViewModels
{
    public class IssueViewModel : ViewModelBase
    {
        private ComicIssue _selectedIssue;
        private int _currentPageindex;
        private ObservableCollection<string> _pages;
        //public string Currentpage { get; set; }
        private string _currentPage;
        public string theCurrentPage;
        public string theCurrentPageColl;
        private ICommand _issueNextCommand;
        public ICommand IssueNextCommand => _issueNextCommand ?? (_issueNextCommand = new RelayCommand<ItemClickEventArgs>(IssueNextmethod));
        private ICommand _issueBackCommand;
        public ICommand IssueBackCommand => _issueBackCommand ?? (_issueBackCommand = new RelayCommand<ItemClickEventArgs>(IssueBackmethod));
        

        public string CurrentPage
        {
           get => (_pages[_currentPageindex]);                      
        }     

        public int CurrentPageIndex
        {
            get => _currentPageindex;
            //set => Set(ref _currentPageindex, value);
            set => _currentPageindex = value;
        }

        
        public ComicIssue SelectedIssue
        {
            get => _selectedIssue;
            set => Set(ref _selectedIssue, value);
        }

        public ObservableCollection<string> Pages
        {
            get => _pages;
            set => Set(ref _pages, value);
        }
        

        public void decompressPages ()
        {
            var rnd = new Random();
            var rndval = (rnd.Next(999)).ToString();
            string decompDir = ApplicationData.Current.TemporaryFolder.Path + @"\" + SelectedIssue.Name + rndval;
            ZipFile.ExtractToDirectory(_selectedIssue.Path, decompDir);
            ObservableCollection<string> tempColl = new ObservableCollection<string>();
            var foundPages = System.IO.Directory.GetFiles(decompDir, "*.jpg");
            foreach (string jpgpath in foundPages)
            {
                tempColl.Add(jpgpath);
            }
            Pages = tempColl;
            theCurrentPage = _pages[_currentPageindex];
            Debug.WriteLine("did we get pages?");
        }
      

        public IssueViewModel()
        {
            if(_currentPageindex == null) { _currentPageindex = 0; }
            _currentPageindex = 0;
            MessengerInstance.Register<IssueClicked>(this, (message) =>
            {
              Debug.WriteLine("got a message");
            this._selectedIssue = message.SelectedIssue;
            Debug.WriteLine("WHY GOD WHY");

            Debug.WriteLine("IS SOURCE UPDATED?");
            Debug.WriteLine(ApplicationData.Current.TemporaryFolder.Path);
            if(Pages == null) {
                    Debug.WriteLine("gonna decomp");
                    decompressPages(); }
            
            Debug.WriteLine("is decompressed?");

            // Pages = await SelectedIssue.getExtractedPages(SelectedIssue.IssueTempFolder);

            });
            MessengerInstance.Register<Pageindexchanged>(this, (message) =>
            {
                _currentPageindex = message.index;
            });
            
            

        }

        private void IssueNextmethod(ItemClickEventArgs args)
        {
            Debug.WriteLine("next click");
            int newindex = new int();
            if (_currentPageindex < (Pages.Count - 1))
            {
                Debug.WriteLine("index was " + _currentPageindex);
                newindex = _currentPageindex + 1;
                Debug.WriteLine("new index " + _currentPageindex);
            }
            MessengerInstance.Send<Pageindexchanged>(new Pageindexchanged(newindex));
            //theCurrentPage = _pages[_currentPageindex];
            NavigationService.Navigate<IssuePage>(newindex);

        }
        private void IssueBackmethod(ItemClickEventArgs args)
        {
            Debug.WriteLine("back click");
            int newindex = new int();
            if (_currentPageindex > 0 )
            {
                Debug.WriteLine("index was " + _currentPageindex);
                newindex = _currentPageindex - 1;
                Debug.WriteLine("new index " + _currentPageindex);
            }
            MessengerInstance.Send<Pageindexchanged>(new Pageindexchanged(newindex));
            //theCurrentPage = _pages[_currentPageindex];
            NavigationService.Navigate<IssuePage>(newindex);

        }

    }
}
