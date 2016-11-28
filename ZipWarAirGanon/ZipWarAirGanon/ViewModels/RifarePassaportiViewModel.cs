using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class RifarePassaportiViewModel : SingleButtonViewModel
    {
        public RifarePassaportiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Rifacimento passaporti";
            Text = "\"...\"";
            ButtonText = "Riproviamo a farli uscire";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.RiprovaUscita);
        }
    }
}
