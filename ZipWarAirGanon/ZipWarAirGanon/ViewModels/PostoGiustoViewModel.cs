using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class PostoGiustoViewModel : TwoButtonViewModel
    {
        public PostoGiustoViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "È il posto giusto?";
            Text = "\"Eh? Eh?\"";
            LeftButtonText = "Si";
            RightButtonText = "No";
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.AnonimatoGarantito);
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.PostoGiusto);
        }
    }
}
