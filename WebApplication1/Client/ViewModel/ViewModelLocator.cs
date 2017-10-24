using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;

namespace Client.ViewModel
{
    class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        public MainViewModel Main { get => ServiceLocator.Current.GetInstance<MainViewModel>(); }
        //public ConvertViewModel Convert { get => ServiceLocator.Current.GetInstance<ConvertViewModel>(); }
        //public InvertedConvertViewModel InvertedConvert { get => ServiceLocator.Current.GetInstance<InvertedConvertViewModel>(); }
    }
}
