using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using App3.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Toolkit.Uwp.UI.Controls;
using MVVMcomics.Messages;
using MVVMcomics.Models;
using MVVMcomics.Views;
using Windows.UI.Xaml.Controls;

namespace MVVMcomics.ViewModels
{
    public class SeriesViewModel : ViewModelBase
    {
        private SeriesClicked _seriesclicked;
        private ComicSeries _selectedSeries;
        private AdaptiveGridView _AdaptiveGridViewControl;
        private ObservableCollection<ComicIssue> _source;
        private ICommand _issueClickCommand;
        public ICommand IssueClickCommand => _issueClickCommand ?? (_issueClickCommand = new RelayCommand<ItemClickEventArgs>(IssueClickmethod));
        


         public ComicSeries SelectedSeries
        {
            get => _selectedSeries;
            set => Set(ref _selectedSeries, value);
        }

        public ObservableCollection<ComicIssue> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public void Initialize(AdaptiveGridView AdaptiveGridViewControl)
        {
            _AdaptiveGridViewControl = AdaptiveGridViewControl;
        }
        public SeriesViewModel()
        {
            MessengerInstance.Register<SeriesClicked>(this, (message) =>
             {
                 Debug.WriteLine("got a message");
                 this._seriesclicked = message;
                 Debug.WriteLine("WHY GOD WHY");
                 Source = _seriesclicked.ListComicIssues;
                 Debug.WriteLine("IS SOURCE UPDATED?");
                //var aSelectedSeries = new ComicSeries();
                //aSelectedSeries.Name = _seriesclicked.Name;
                //aSelectedSeries.Path = _seriesclicked.Path;
                //aSelectedSeries.ListComicIssues = _seriesclicked.ListComicIssues;
                //SelectedSeries = aSelectedSeries;
                //Source = aSelectedSeries.ListComicIssues;

             });
            Debug.WriteLine("FUCK ME");
            
               // SelectedSeries.Path = message.Path;
               // SelectedSeries.ListComicIssues = message.ListComicIssues;
            //});
            //Source = SelectedSeries.ListComicIssues;
        }
        private void IssueClickmethod(ItemClickEventArgs args)
        {
            var selectedIssue = args.ClickedItem as ComicIssue;
            Debug.WriteLine("issue click");
            Debug.WriteLine(selectedIssue.Name);
            Debug.WriteLine(selectedIssue.Path);
            //Messenger.Default.Send<IssueClicked>(new IssueClicked(selectedIssue.Name, selectedIssue.Path));
            NavigationService.Navigate<IssuePage>(selectedIssue);
            MessengerInstance.Send(new IssueClicked(selectedIssue));
        }
        
    }
}
