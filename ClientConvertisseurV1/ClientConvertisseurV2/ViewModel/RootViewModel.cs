using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ClientConvertisseurV2.ViewModel
{
    public class RootViewModel : ViewModelBase
    {
        public ICommand BtnConverter { get; set; }
        public ICommand BtnInverterConverter { get; set; }

        public RootViewModel()
        {
            BtnConverter = new RelayCommand(goToConverter);
            BtnInverterConverter = new RelayCommand(goToInverterConverter);
        }
        private void goToConverter()
        {
            View.MainPage r = (View.MainPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            (sv.Content as Frame).Navigate(typeof(View.MainPage));
        }
        private void goToInverterConverter()
        {
            View.MainPage r = (View.MainPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            (sv.Content as Frame).Navigate(typeof(View.MainPage_2));
        }
    }
}
