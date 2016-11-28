using Prism.Navigation;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.ViewModels.Abstracts;

namespace ZipWarAirGanon.ViewModels
{
    public class RiprovaUscitaViewModel : SingleButtonViewModel
    {
        public RiprovaUscitaViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Riproviamo a farli uscire";
            Text = "\"Ora che sono poveri non vogliono più uscire e anzi vogliono combattere contro i cittadini che prendono 12000€ al mese in Parlamento.\"";
            ButtonText = "Non è vero";
        }

        protected override void NavigateView()
        {
            _navigationService.NavigateAsync(PageNames.NonVero);
        }
    }
}
