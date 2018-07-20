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
using Windows.UI.Xaml.Navigation;

namespace MVVMcomics.ViewModels
{
    public class LibraryViewModel : ViewModelBase
    {
        private ObservableCollection<ComicSeries> _source;
        private AdaptiveGridView _AdaptiveGridViewControl;
        private ICommand _refreshCommand;
        private ICommand _seriesClickCommand;

        public ICommand RefreshCommand => _refreshCommand ?? (_refreshCommand = new RelayCommand<ItemClickEventArgs>(RefreshButton_Click));
        public ICommand SeriesClickCommand => _seriesClickCommand ?? (_seriesClickCommand = new RelayCommand<ItemClickEventArgs>(SeriesClick));

        public ObservableCollection<ComicSeries> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public LibraryViewModel()
        {
            Source = ComicSeries.GetSomeComics();
        }

        private async void RefreshButton_Click(ItemClickEventArgs args)
        {
            // ObservableCollection<ComicSeries> refreshedList = await ComicSeries.AsyncGetComicsFromPath();
            Source = await ComicSeries.AsyncGetComicsFromPath();
        }

        private void SeriesClick(ItemClickEventArgs args)
        {
            var selectedSeries = args.ClickedItem as ComicSeries;
            Debug.WriteLine("clicked");
            Debug.WriteLine(selectedSeries.Name);
            Debug.WriteLine(selectedSeries.Path);
            //App.thestate = selectedSeries.Name;
            //App.theSelectedSeries = selectedSeries;
            string theSelectedSeries = "theSelectedSeries";
            //localstore.Save(theSelectedSeries,selectedSeries);
            
            NavigationService.Navigate<SeriesPage>(selectedSeries);
            MessengerInstance.Send(new SeriesClicked(selectedSeries.Name, selectedSeries.Path, selectedSeries.ListComicIssues));
        }
        





    }
}
