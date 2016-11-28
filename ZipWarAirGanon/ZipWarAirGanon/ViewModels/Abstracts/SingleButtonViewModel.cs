using Prism.Commands;
using Prism.Navigation;

namespace ZipWarAirGanon.ViewModels.Abstracts
{
    public abstract class SingleButtonViewModel : BaseViewModel
    {
        private string _buttonText;

        public string ButtonText
        {
            get { return _buttonText; }
            set { SetProperty(ref _buttonText, value); }
        }

        protected abstract void NavigateView();

        public DelegateCommand ButtonCommand { get; private set; }

        public SingleButtonViewModel(INavigationService navigationService) : base(navigationService)
        {
            ButtonCommand = new DelegateCommand(NavigateView);
        }
    }
}
