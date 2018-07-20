using System;

using CommonServiceLocator;

using GalaSoft.MvvmLight.Ioc;

using MVVMcomics.Services;
using MVVMcomics.Views;

namespace MVVMcomics.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<LibraryViewModel, LibraryPage>();
            Register<SeriesViewModel, SeriesPage>();
            Register<IssueViewModel, IssuePage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public IssueViewModel IssueViewModel => ServiceLocator.Current.GetInstance<IssueViewModel>();

        public SeriesViewModel SeriesViewModel => ServiceLocator.Current.GetInstance<SeriesViewModel>();

        public LibraryViewModel LibraryViewModel => ServiceLocator.Current.GetInstance<LibraryViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
