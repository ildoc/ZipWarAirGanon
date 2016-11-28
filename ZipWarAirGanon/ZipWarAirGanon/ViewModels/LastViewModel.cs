using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class LastViewModel : SingleButtonViewModel
    {
        public LastViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Invece sì!";
            Text = "\"E te lo dimostreremo perché anche noi siamo entrati in possesso del...\"";
            ButtonText = "Attiva CROSS CHECKING";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.CrossChecking);
        }
    }
}
