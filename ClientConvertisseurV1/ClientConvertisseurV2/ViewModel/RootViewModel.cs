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
    public class RootViewModel : ViewModelBase
    { 
        public ICommand BtnConverter { get; set; }
        public ICommand BtnInvertedConverter { get; set; }
        public ICommand BtnHamburger { get; set; }

        public RootViewModel()
        {
            BtnConverter = new RelayCommand(goToConverter);
            BtnInvertedConverter = new RelayCommand(goToInvertedConverter);
            BtnHamburger = new RelayCommand(hamburgerClick);
        }

        private void goToConverter()
        {
            View.RootPage r = (View.RootPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            (sv.Content as Frame).Navigate(typeof(View.MainPage));
        }

        private void goToInvertedConverter()
        {
            View.RootPage r = (View.RootPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            (sv.Content as Frame).Navigate(typeof(View.InvertedConvertPage));
        }

        private void hamburgerClick()
        {
            View.RootPage r = (View.RootPage)Window.Current.Content;
            SplitView sv = (SplitView)(r.Content);
            sv.IsPaneOpen = !sv.IsPaneOpen;
        }
    }
}
