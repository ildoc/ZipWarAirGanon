using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class Vedi740ViewModel : SingleButtonViewModel
    {
        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.Vedi740Decurtata);
        }

        public Vedi740ViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "740";
            Text = "\"Vedere il loro 740 all'inizio, il 740 di oggi, decurtata, con questo algoritmo che lo fa automaticamente, uno stipendio di 1200 euro al mese, quello che rimane verrà restituito.\"";
            ButtonText = "Vedi il 740 decurtata";
        }
    }
}
