using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class RestituireBeniViewModel : SingleButtonViewModel
    {
        public RestituireBeniViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Restituzione";
            Text = "\"Restituire i beni patrimoniali al popolo italiano.\"";
            ButtonText = "Mettere tutto online";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.TuttoOnline);
        }
    }
}
