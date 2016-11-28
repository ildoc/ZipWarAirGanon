using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class UscitaPoliticiViewModel : SingleButtonViewModel
    {
        public UscitaPoliticiViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Uscita dei politici";
            Text = "\"Consentire uscita dei politici, è doveroso mandarli via da questo paese, che non ritornino più.\"";
            ButtonText = "Non hanno più i passaporti";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.NoPassaporti);
        }
    }
}
