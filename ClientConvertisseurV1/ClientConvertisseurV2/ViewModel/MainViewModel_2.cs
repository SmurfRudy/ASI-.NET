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

namespace ClientConvertisseurV2.ViewModel
{
    public class MainViewModel_2 : ViewModelBase
    {
        public ICommand BtnSetConversion { get; private set; }
        Service.ErrorMessage erreur_message = new Service.ErrorMessage();
        private Model.Devise _comboBoxDeviseItem;
        public Model.Devise ComboBoxDeviseItem
        {
            get { return _comboBoxDeviseItem; }
            set
            {
                _comboBoxDeviseItem = value;
                RaisePropertyChanged();
            }
        }
        private Service.WSService clientWS;
        private string _finalAmount;
        public string FinalAmount
        {
            get { return _finalAmount; }
            set
            {
                _finalAmount = value;
                RaisePropertyChanged();
            }
        }

        private string _montantEuros;
        public string MontantEuros
        {
            get { return _montantEuros; }
            set
            {
                _montantEuros = value;
                RaisePropertyChanged();
            }
        }
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                RaisePropertyChanged();
            }
        }
        
        private ObservableCollection<Model.Devise> _comboBoxDevises;
        public ObservableCollection<Model.Devise> ComboBoxDevises
        {
            get { return _comboBoxDevises; }
            set
            {
                _comboBoxDevises = value;
                RaisePropertyChanged();// Pour notifier de la modification de ses données
            }
        }
    
        public MainViewModel_2()
        {
            this.clientWS = new Service.WSService();
            ActionGetData();
            BtnSetConversion = new RelayCommand(ActionSetConversionAsync);
        }
        private async void ActionGetData()
        {

            var result = await clientWS.getAllDevisesAsync();
            ComboBoxDevises = new ObservableCollection<Model.Devise>(result);
        }

        private async void ActionSetConversionAsync()
        {
            try
            {
                if (this.ComboBoxDeviseItem != null)
                {
                    if ((Double.Parse(this.MontantEuros))>0)
                    {
                        try
                        {
                            this.FinalAmount = (Double.Parse(this.MontantEuros) * this.ComboBoxDeviseItem.taux).ToString();
                        }
                        catch (Exception e)
                        {
                            await erreur_message.sendMessageErrorAsync("Erreur dans le calucl final");
                        }
                    }
                    else
                    {
                        await erreur_message.sendMessageErrorAsync("Le montant initial n'est pas spécifié en nombre positif");
                    }

                }
                else
                {
                    await erreur_message.sendMessageErrorAsync("Récupération devise non spécifié");
                }
            }
            catch (Exception e)
            {
                this.ErrorMessage = ("Erreur Dans la récupération des données");
                await erreur_message.sendMessageErrorAsync("Erreur");
            }



        }

    }
}
