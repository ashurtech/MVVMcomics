using System;

using MVVMcomics.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMcomics.Views
{
    public sealed partial class IssuePage : Page
    {
        private IssueViewModel ViewModel
        {
            get { return DataContext as IssueViewModel; }
        }

        public IssuePage()
        {
            InitializeComponent();
        }
    }
}
