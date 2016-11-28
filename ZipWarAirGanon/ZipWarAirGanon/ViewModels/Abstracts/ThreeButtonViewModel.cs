using Prism.Commands;
using Prism.Navigation;

namespace ZipWarAirGanon.ViewModels.Abstracts
{
    public abstract class ThreeButtonViewModel : SingleButtonViewModel
    {
        public DelegateCommand RightButtonCommand { get; private set; }
        public DelegateCommand LeftButtonCommand { get; private set; }

        public ThreeButtonViewModel(INavigationService navigationService) : base(navigationService)
        {
            LeftButtonCommand = new DelegateCommand(NavigateLeftView);
            RightButtonCommand = new DelegateCommand(NavigateRightView);
        }

        private string _leftButtonText;

        public string LeftButtonText
        {
            get { return _leftButtonText; }
            set { SetProperty(ref _leftButtonText, value); }
        }

        private string _rightButtonText;

        public string RightButtonText
        {
            get { return _rightButtonText; }
            set { SetProperty(ref _rightButtonText, value); }
        }

        protected abstract void NavigateLeftView();

        protected abstract void NavigateRightView();
    }
}
