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
        Service.WSService monService;
        public MainPage()
        {
            monService = new Service.WSService();
  
            this.InitializeComponent();
            ActionGetData();
        }
        private async void ActionGetData()
        {
            try { List<Model.Devise> result = await monService.getAllDevisesAsync();
                this.ComboBoxDevise.DataContext = result;
                this.ComboBoxDevise.ItemsSource = result;
                this.ComboBoxDevise.SelectedValuePath = "id";
                this.ComboBoxDevise.DisplayMemberPath = "deviseName";
            } 
            catch (Exception e)
            {
                this.ErrorMessage.Content = ("Erreur WebService");
                this.ErrorMessage.IsEnabled = true;

            }

        }
        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void ConvertirButton_Click(object sender, RoutedEventArgs e)
        {
            double initialAm;
            Model.Devise finaldevise;
            double totalAmount;
            try
            {initialAm = Double.Parse(this.InitialAmount.Text);
                finaldevise = (Model.Devise) this.ComboBoxDevise.SelectedItem;
                totalAmount = initialAm * finaldevise.taux;
                this.AmountDeviseValue.Text = totalAmount.ToString();
            }
            catch (Exception f)
            {
                this.ErrorMessage.Content = ("Erreur récupération des données initiales");
                this.ErrorMessage.IsEnabled = true;

            }
        }
    }
}
