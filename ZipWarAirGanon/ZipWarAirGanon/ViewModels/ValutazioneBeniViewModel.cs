using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class ValutazioneBeniViewModel : TwoButtonViewModel
    {
        public ValutazioneBeniViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Valutazione immediata";
            Text = "\"Dei beni patrimoniali sia in Italia che all'estero dove sono gli scudi fiscali, ci sono nomi, cognomi, c'è tutto?\"";
            LeftButtonText = "Si";
            RightButtonText = "No";
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.SottoControllo);
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.FanculoComplotto);
        }
    }
}
