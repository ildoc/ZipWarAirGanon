using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class CheckMafiosiViewModel : ThreeButtonViewModel
    {
        public CheckMafiosiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Check Mafiosi";
            Text = "\"È come i mafiosi?\"";
            ButtonText = "No";
            LeftButtonText = "Leggermente Peggio";
            RightButtonText = "Si";
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.SequestroCapitali);
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.Figuriamoci);
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.DecurtamentoSVG4);
        }
    }
}
