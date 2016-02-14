using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BisectApp.ViewModel
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            Register();
        }

        private void Register()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }
    }
}
