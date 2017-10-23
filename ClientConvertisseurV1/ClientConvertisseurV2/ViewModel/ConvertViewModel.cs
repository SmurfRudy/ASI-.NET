using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientConvertisseurV2.ViewModel
{
    class ConvertViewModel : ViewModelBase
    {
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
        private string _montantResultat;
        public string MontantResultat
        {
            get { return _montantResultat; }
            set
            {
                _montantResultat = value;
                RaisePropertyChanged();
            }
        }

        public ICommand BtnSetConversion { get; private set; }
        Service.WSService service = Service.WSService.getInstance();
        Service.ErrorDialog error = new Service.ErrorDialog();
        public ConvertViewModel()
        {
            ActionGetData();
            BtnSetConversion = new RelayCommand(ActionSetConversion);
        }
        private async void ActionGetData()
        {
            var result = await service.getAllDevisesAsync();
            ComboBoxDevises = new ObservableCollection<Model.Devise>(result);
        }
        private async void ActionSetConversion()
        {
            if (MontantEuros == null)
            {
                await error.showErrorAsync("Veuillez remplir le montant");
            }
            else
            {
                if (MontantEuros.Equals(""))
                {
                    await error.showErrorAsync("Veuillez remplir le montant");
                }
                else
                {
                    if (ComboBoxDeviseItem == null)
                    {
                        await error.showErrorAsync("Veuillez choisir une devise");
                    }
                    else
                    {
                        Double result = Double.Parse(MontantEuros) * ComboBoxDeviseItem.taux;
                        MontantResultat = result.ToString();
                    }
                }
            }
        }
    }
}
