using System;

using MVVMcomics.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMcomics.Views
{
    public sealed partial class SeriesPage : Page
    {
        private SeriesViewModel ViewModel
        {
            get { return DataContext as SeriesViewModel; }
        }

        public SeriesPage()
        {
            InitializeComponent();
        }
    }
}
