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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ClientConvertisseurV1
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Service.WSService service;
        public MainPage()
        {
            this.InitializeComponent();
            service = new Service.WSService();
            ActionGetData();
        }

        private async void ActionGetData()
        {
            var result = await service.getAllDevisesAsync();
            this.ComboBoxDevise.DataContext = new List<Model.Devise>(result);
        }

        private void Convert(object sender, RoutedEventArgs e)
        {
            var selectedDevise = this.ComboBoxDevise.SelectedItem;
            if (selectedDevise != null)
            {
                Model.Devise devise = (Model.Devise)selectedDevise;
                if (this.TextBoxEuros.Text != "")
                {
                    Double result = Double.Parse(this.TextBoxEuros.Text) * devise.taux;
                    this.TextAmount.Text = result.ToString();
                }
            }
        }
    }
}
