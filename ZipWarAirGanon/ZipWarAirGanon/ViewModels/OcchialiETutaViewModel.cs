using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class OcchialiETutaViewModel : SingleButtonViewModel
    {
        public OcchialiETutaViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Cambio d'abito tattico";
            Text = "\"Indossare occhiali da sci e tuta da ritardato.\"";
            ButtonText = "Attiva meraviglioso CROSS CHECKING";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.MeravigliosoCrossChecking);
        }
    }
}
