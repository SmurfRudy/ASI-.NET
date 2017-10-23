using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace Client.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand BtnPrevious { get; set; }
        public ICommand BtnHome { get; set; }
        public ICommand BtnMovies { get; set; }
        public ICommand BtnAccount { get; set; }
        public ICommand BtnParameters { get; set; }

        public MainViewModel()
        {
            BtnPrevious = new RelayCommand(goToPrevious);
            BtnHome = new RelayCommand(goToHome);
            BtnMovies = new RelayCommand(goToMovies);
            BtnAccount = new RelayCommand(goToAccount);
            BtnParameters = new RelayCommand(goToParameters);
        }

        private void goToPrevious()
        {
            //Frame myFrame = MainSplitView.Content as Frame;
            //if (myFrame.CanGoBack)
            //{
            //    myFrame.GoBack();
            //}
        }

        private void goToHome()
        {

        }

        private void goToMovies()
        {

        }

        private void goToAccount()
        {

        }

        private void goToParameters()
        {

        }
    }
}
