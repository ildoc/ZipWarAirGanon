using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class InveceSiViewModel : SingleButtonViewModel
    {
        public InveceSiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Invece sì!";
            Text = "\"!11!1\"";
            ButtonText = "Invece no!";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.InveceNo);
        }
    }
}
