using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class AllertaUfficiViewModel : TwoButtonViewModel
    {
        public AllertaUfficiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "I migliori ufficiali giudiziali...";
            Text = "\"...e migliori forze di polizia. È il momento giusto?\"";
            LeftButtonText = "Si";
            RightButtonText = "No";
        }

        protected override void NavigateLeftView()
        {
            _navigationService.NavigateAsync(PageNames.PostoGiusto);
        }

        protected override void NavigateRightView()
        {
            _navigationService.NavigateAsync(PageNames.AllertaUffici);
        }
    }
}
