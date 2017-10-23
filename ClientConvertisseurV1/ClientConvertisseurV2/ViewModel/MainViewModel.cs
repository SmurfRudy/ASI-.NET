using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ClientConvertisseurV2.ViewModel
{
    class MainViewModel : ViewModelBase
    { 
        public ICommand BtnConverter { get; set; }
        public ICommand BtnInvertedConverter { get; set; }

        public MainViewModel()
        {
            BtnConverter = new RelayCommand(goToConverter);
            BtnInvertedConverter = new RelayCommand(goToInvertedConverter);
        }

        private void goToConverter()
        {
            View.MainPage r = (View.MainPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            (sv.Content as Frame).Navigate(typeof(View.ConvertPage));
        }

        private void goToInvertedConverter()
        {
            View.MainPage r = (View.MainPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            (sv.Content as Frame).Navigate(typeof(View.InvertedConvertPage));
        }
    }
}
