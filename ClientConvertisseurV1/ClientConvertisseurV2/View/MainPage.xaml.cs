using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

<<<<<<< HEAD
// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238
=======
// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
>>>>>>> 71c5c606c6b23313cac7c97fa318da2b4f4abc4d

namespace ClientConvertisseurV2.View
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
<<<<<<< HEAD
        public MainPage(Frame frame)
        {
            this.InitializeComponent();
            this.MainSplitView.Content = frame;
            (MainSplitView.Content as Frame).Navigate(typeof(ConvertPage));
        }

        public void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }
=======
        Service.WSService monService;
        public MainPage()
        {
            monService = new Service.WSService();
  
            this.InitializeComponent();
           
        }


       
>>>>>>> 71c5c606c6b23313cac7c97fa318da2b4f4abc4d
    }
}
