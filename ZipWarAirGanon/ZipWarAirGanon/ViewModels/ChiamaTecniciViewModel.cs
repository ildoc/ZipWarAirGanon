using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class ChiamaTecniciViewModel : SingleButtonViewModel
    {
        public ChiamaTecniciViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "I migliori tecnici";
            Text = "\"Inizializzare subito Zip War Airganon\"";
            ButtonText = "Allerta migliori uffici giudiziari";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.AllertaUffici);
        }
    }
}
