using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BisectApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand ButtonCommand { get; set; }

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                if (value.Equals(_text))
                    return;
                _text = value;
                RaisePropertyChanged(() => Text);
            }
        }

        public MainViewModel()
        {
            ButtonCommand = new RelayCommand(() =>
            {
                Text = "Hello git enthousiast!";
            });
        }
    }
}
