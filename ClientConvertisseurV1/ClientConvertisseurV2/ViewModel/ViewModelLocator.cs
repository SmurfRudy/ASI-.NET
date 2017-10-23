using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV2.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    /// 
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<RootViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<InvertedConvertViewModel>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        public RootViewModel Root { get => ServiceLocator.Current.GetInstance<RootViewModel>(); }
        public MainViewModel Main { get => ServiceLocator.Current.GetInstance<MainViewModel>(); }
        public InvertedConvertViewModel InvertedConvert { get => ServiceLocator.Current.GetInstance<InvertedConvertViewModel>(); }
    }
}
