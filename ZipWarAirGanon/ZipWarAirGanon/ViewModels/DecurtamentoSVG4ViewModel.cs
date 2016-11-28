using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class DecurtamentoSVG4ViewModel : SingleButtonViewModel
    {
        public DecurtamentoSVG4ViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Attivazione automatica";
            Text = "\"Decurtamento SVG4\"";
            ButtonText = "Chiama i migliori tecnici";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.ChiamaTecnici);
        }
    }
}
