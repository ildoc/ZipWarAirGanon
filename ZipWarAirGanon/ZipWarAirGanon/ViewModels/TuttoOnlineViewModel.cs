using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class TuttoOnlineViewModel : SingleButtonViewModel
    {
        public TuttoOnlineViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Mettere tutto online";
            Text = "\"Per aumentare accessi al blog.\"";
            ButtonText = "Consentire uscita politici";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.UscitaPolitici);
        }
    }
}
