using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class CrossCheckingViewModel : SingleButtonViewModel
    {
        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.Vedi740);
        }

        public CrossCheckingViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Attivazione";
            Text = "\"Abbiamo un meraviglioso cross checking per intensificare e intersecare tutti i dati mondiali delle banche e delle dichiarazioni fiscali.\"";
            ButtonText = "Vedi il 740";
        }
    }
}
