using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class MeravigliosoCrossCheckingViewModel : SingleButtonViewModel

    {
        public MeravigliosoCrossCheckingViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Meraviglioso Cross Checking";
            Text = "\"Per mettere in relazione tutti i dati anagrafici dei documenti dei passaporti.\"";
            ButtonText = "Ritiro dei passaporti";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.RitiroPassaporti);
        }
    }
}
