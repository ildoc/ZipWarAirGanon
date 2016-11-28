using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class FiguriamociViewModel : SingleButtonViewModel
    {
        public FiguriamociViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Figuriamoci";
            Text = "\"Premere velocemente dei tasti a casaccio sulla tastiera come i programmatori dei film.\"";
            ButtonText = "Senza guardare la tastiera";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.TastiACasaccio);
        }
    }
}
