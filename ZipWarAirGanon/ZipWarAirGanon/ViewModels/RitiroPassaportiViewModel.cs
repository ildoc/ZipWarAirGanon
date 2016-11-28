using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class RitiroPassaportiViewModel : SingleButtonViewModel
    {
        public RitiroPassaportiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Attivazione crowd-out-sourcing";
            Text = "\"In aggiunta all'out-sourcing normale.\"";
            ButtonText = "Valutazione immediata dei beni";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.ValutazioneBeni);
        }
    }
}
