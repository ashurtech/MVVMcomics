﻿#pragma checksum "C:\Users\zac.ASHURTECH.000\source\repos\MVVMcomics\MVVMcomics\Views\SeriesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7521BEBCA8FE03BECF481BE7ADB4D9C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMcomics.Views
{
    partial class SeriesPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SeriesPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISeriesPage_Bindings
        {
            private global::MVVMcomics.Views.SeriesPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView obj4;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj5;
            private global::Windows.UI.Xaml.Controls.Image obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;

            private SeriesPage_obj1_BindingsTracking bindingsTracking;

            public SeriesPage_obj1_Bindings()
            {
                this.bindingsTracking = new SeriesPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Views\SeriesPage.xaml line 64
                        this.obj4 = (global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView)target;
                        break;
                    case 5: // Views\SeriesPage.xaml line 72
                        this.obj5 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    case 6: // Views\SeriesPage.xaml line 56
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 7: // Views\SeriesPage.xaml line 57
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // ISeriesPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MVVMcomics.Views.SeriesPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MVVMcomics.Views.SeriesPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::MVVMcomics.ViewModels.SeriesViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Source(obj.Source, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IssueClickCommand(obj.IssueClickCommand, phase);
                        this.Update_ViewModel_SelectedSeries(obj.SelectedSeries, phase);
                    }
                }
            }
            private void Update_ViewModel_Source(global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Source(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SeriesPage.xaml line 64
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_IssueClickCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\SeriesPage.xaml line 72
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj5, obj, null);
                }
            }
            private void Update_ViewModel_SelectedSeries(global::MVVMcomics.Models.ComicSeries obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SelectedSeries_Seriesimagepath(obj.Seriesimagepath, phase);
                        this.Update_ViewModel_SelectedSeries_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_ViewModel_SelectedSeries_Seriesimagepath(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\SeriesPage.xaml line 56
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj6, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_ViewModel_SelectedSeries_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\SeriesPage.xaml line 57
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SeriesPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SeriesPage_obj1_Bindings> weakRefToBindingObj; 

                public SeriesPage_obj1_BindingsTracking(SeriesPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SeriesPage_obj1_Bindings>(obj);
                }

                public SeriesPage_obj1_Bindings TryGetBindingObject()
                {
                    SeriesPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Source(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SeriesPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::MVVMcomics.ViewModels.SeriesViewModel obj = sender as global::MVVMcomics.ViewModels.SeriesViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Source":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::MVVMcomics.ViewModels.SeriesViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::MVVMcomics.ViewModels.SeriesViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Source(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SeriesPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Source(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    SeriesPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue> cache_ViewModel_Source = null;
                public void UpdateChildListeners_ViewModel_Source(global::System.Collections.ObjectModel.ObservableCollection<global::MVVMcomics.Models.ComicIssue> obj)
                {
                    if (obj != cache_ViewModel_Source)
                    {
                        if (cache_ViewModel_Source != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Source).PropertyChanged -= PropertyChanged_ViewModel_Source;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_Source).CollectionChanged -= CollectionChanged_ViewModel_Source;
                            cache_ViewModel_Source = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Source = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Source;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_Source;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // Views\SeriesPage.xaml line 33
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Views\SeriesPage.xaml line 64
                {
                    this.AdaptiveGridViewControl = (global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView)(target);
                }
                break;
            case 6: // Views\SeriesPage.xaml line 56
                {
                    this.SeriesImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // Views\SeriesPage.xaml line 57
                {
                    this.SeriesTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\SeriesPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SeriesPage_obj1_Bindings bindings = new SeriesPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

