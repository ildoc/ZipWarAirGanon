using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class InveceNoViewModel : SingleButtonViewModel
    {
        public InveceNoViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Invece no!";
            Text = "\"!1111!!!!1\"";
            ButtonText = "Invece sì e te lo dimostreremo";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.Last);
        }
    }
}
