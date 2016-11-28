using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class FanculoComplottoViewModel : SingleButtonViewModel
    {
        public FanculoComplottoViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "UFFA!";
            Text = "\"ANDATE TUTTI AFFANCULO!!!11! È UN COMPLOTTO DELLA ZIP UOR ERGEINON and sons!\"";
            ButtonText = "Attiva sequestro capitali";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.SequestroCapitali);
        }
    }
}
