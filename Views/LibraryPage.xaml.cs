using System;

using MVVMcomics.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMcomics.Views
{
    public sealed partial class LibraryPage : Page
    {
        private LibraryViewModel ViewModel
        {
            get { return DataContext as LibraryViewModel; }
        }

        public LibraryPage()
        {
            InitializeComponent();
        }
    }
}
