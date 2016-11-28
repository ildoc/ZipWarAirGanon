using Prism.Unity;
using ZipWarAirGanon.Classes;
using ZipWarAirGanon.Views;

namespace ZipWarAirGanon
{
    public class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(PageNames.Start);
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<Start>(PageNames.Start);
            Container.RegisterTypeForNavigation<CrossChecking>(PageNames.CrossChecking);
            Container.RegisterTypeForNavigation<Vedi740>(PageNames.Vedi740);
            Container.RegisterTypeForNavigation<Vedi740Decurtata>(PageNames.Vedi740Decurtata);
            Container.RegisterTypeForNavigation<Figuriamoci>(PageNames.Figuriamoci);
            Container.RegisterTypeForNavigation<TastiACasaccio>(PageNames.TastiACasaccio);
            Container.RegisterTypeForNavigation<AdobeSuite>(PageNames.AdobeSuite);
            Container.RegisterTypeForNavigation<CheckMafiosi>(PageNames.CheckMafiosi);
            Container.RegisterTypeForNavigation<SequestroCapitali>(PageNames.SequestroCapitali);
            Container.RegisterTypeForNavigation<RestituireBeni>(PageNames.RestituireBeni);
            Container.RegisterTypeForNavigation<TuttoOnline>(PageNames.TuttoOnline);
            Container.RegisterTypeForNavigation<UscitaPolitici>(PageNames.UscitaPolitici);
            Container.RegisterTypeForNavigation<NoPassaporti>(PageNames.NoPassaporti);
            Container.RegisterTypeForNavigation<RifarePassaporti>(PageNames.RifarePassaporti);
            Container.RegisterTypeForNavigation<RiprovaUscita>(PageNames.RiprovaUscita);
            Container.RegisterTypeForNavigation<NonVero>(PageNames.NonVero);
            Container.RegisterTypeForNavigation<InveceSi>(PageNames.InveceSi);
            Container.RegisterTypeForNavigation<InveceNo>(PageNames.InveceNo);
            Container.RegisterTypeForNavigation<Last>(PageNames.Last);
            Container.RegisterTypeForNavigation<DecurtamentoSVG4>(PageNames.DecurtamentoSVG4);
            Container.RegisterTypeForNavigation<ChiamaTecnici>(PageNames.ChiamaTecnici);
            Container.RegisterTypeForNavigation<AllertaUffici>(PageNames.AllertaUffici);
            Container.RegisterTypeForNavigation<PostoGiusto>(PageNames.PostoGiusto);
            Container.RegisterTypeForNavigation<AnonimatoGarantito>(PageNames.AnonimatoGarantito);
            Container.RegisterTypeForNavigation<MeravigliosoCrossChecking>(PageNames.MeravigliosoCrossChecking);
            Container.RegisterTypeForNavigation<RitiroPassaporti>(PageNames.RitiroPassaporti);
            Container.RegisterTypeForNavigation<ValutazioneBeni>(PageNames.ValutazioneBeni);
            Container.RegisterTypeForNavigation<FanculoComplotto>(PageNames.FanculoComplotto);
            Container.RegisterTypeForNavigation<SottoControllo>(PageNames.SottoControllo);
            Container.RegisterTypeForNavigation<OcchialiETuta>(PageNames.OcchialiETuta);
        }
    }
}
