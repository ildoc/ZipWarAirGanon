using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class AnonimatoGarantitoViewModel : TwoButtonViewModel
    {
        public AnonimatoGarantitoViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Il nostro anonimato...";
            Text = "\"...è garantito?\"";
            LeftButtonText = "Si";
            RightButtonText = "No";
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.MeravigliosoCrossChecking);
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.OcchialiETuta);
        }
    }
}
