using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class TastiACasaccioViewModel : SingleButtonViewModel
    {
        public TastiACasaccioViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Dopo un po'";
            Text = "\"Fare finta di andare in bagno e invece chiamare i migliori grafici.\"";
            ButtonText = "Inizializza Adobe Suite CS7";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.AdobeSuite);
        }
    }
}
