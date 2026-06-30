using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("SteamList.html")]
[Navigation(NavigationTypes.Main, 2)]
public class SteamList : PageDetails
{
    public SteamList()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Locomotive Photo Reference Collection";
        MenuTitle = "SteamList";
        DontShowNavigation = true;

        Keywords.AddRange(LocoRef.GetKeywords(StockTypes.SteamLoco));
    }

    public override void CreatePage()
    {
        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");

        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));
        WebPage.Append(CreateReferenceLinks());
        WebPage.Append(LocoRef.CreatelItemList(WebPage, StockTypes.SteamLoco));

        WebPage.Append("</div>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private static string CreateReferenceLinks()
    {
        return @"<div class='mb-4'>
  <h6 class='text-muted mb-2'>Browse by</h6>
  <a href='LocoDesigners.html'    class='btn btn-outline-secondary mr-2 mb-2'>&#9998; Designers</a>
  <a href='WheelArrangements.html' class='btn btn-outline-secondary mr-2 mb-2'>&#9900; Wheel Arrangements</a>
  <a href='LocoBuilders.html'     class='btn btn-outline-secondary mr-2 mb-2'>&#9965; Builders</a>
</div>";
    }
}