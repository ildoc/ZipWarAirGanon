using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class SequestroCapitaliViewModel : SingleButtonViewModel
    {
        public SequestroCapitaliViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Attivazione";
            Text = "\"Procedura sequestro capitali\"";
            ButtonText = "Restituire i beni";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.RestituireBeni);
        }
    }
}
