using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class NoPassaportiViewModel : SingleButtonViewModel
    {
        public NoPassaportiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Non hanno più i passaporti";
            Text = "\"Oops!\"";
            ButtonText = "Rifategli i passaporti";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.RifarePassaporti);
        }
    }
}
