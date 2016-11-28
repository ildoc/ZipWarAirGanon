using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class StartViewModel : SingleButtonViewModel
    {
        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.CrossChecking);
        }

        public StartViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Questa gente dice";
            Text = "\"Adesso vado via do le dimissioni e basta!\"";
            ButtonText = "Attiva CROSS CHECKING";
        }
    }
}
