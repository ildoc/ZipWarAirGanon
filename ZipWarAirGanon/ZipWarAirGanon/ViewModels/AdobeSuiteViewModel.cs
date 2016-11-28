using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class AdobeSuiteViewModel : SingleButtonViewModel
    {
        public AdobeSuiteViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Adobe Suite CS7";
            Text = "\"Modificare i 740 iniziali e finali.\"";
            ButtonText = "E ora vedi il 740";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.Vedi740);
        }
    }
}
