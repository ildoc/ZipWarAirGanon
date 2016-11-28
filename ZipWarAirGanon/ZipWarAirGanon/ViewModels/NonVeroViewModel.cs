using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class NonVeroViewModel : SingleButtonViewModel
    {
        public NonVeroViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Non è vero!";
            Text = "\"Non è vero non è vero non è vero!\"";
            ButtonText = "Invece si!";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.InveceSi);
        }
    }
}
