using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class Vedi740DecurtataViewModel : ThreeButtonViewModel
    {
        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.Figuriamoci);
        }

        public Vedi740DecurtataViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "740 Decurtata";
            Text = "\"Ha guadagnato più di 1200€ al mese?\"";
            ButtonText = "Si, ma già da prima";
            LeftButtonText = "Si";
            RightButtonText = "No";
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.CheckMafiosi);
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.Figuriamoci);
        }
    }
}
