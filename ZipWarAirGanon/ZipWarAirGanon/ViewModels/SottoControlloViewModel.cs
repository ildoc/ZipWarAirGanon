using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class SottoControlloViewModel : TwoButtonViewModel
    {
        public SottoControlloViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Situazione";
            Text = "\"Abbiamo sotto controllo la situazione, abbiamo il capitale?\"";
            LeftButtonText = "Si";
            RightButtonText = "No";
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.RestituireBeni);
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.FanculoComplotto);
        }
    }
}
