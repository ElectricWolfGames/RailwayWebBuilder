using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("DieselList.html")]
[Navigation(NavigationTypes.Main, 2)]
public class DieselList : PageDetails
{
    public DieselList()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Locomotive Photo Reference Collection";
        MenuTitle = "DieselList";
        DontShowNavigation = true;

        Keywords.AddRange(LocoRef.GetKeywords(StockTypes.Diesel));
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
        WebPage.Append(LocoRef.CreatelItemList(WebPage, StockTypes.Diesel));

        WebPage.Append("</div>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private static string CreateReferenceLinks()
    {
        return @"<div class='mb-4'>
  <h6 class='text-muted mb-2'>Browse by</h6>
  <a href='DieselDesigners.html'         class='btn btn-outline-secondary mr-2 mb-2'>&#9998; Designers</a>
  <a href='DieselWheelArrangements.html' class='btn btn-outline-secondary mr-2 mb-2'>&#9900; Wheel Arrangements</a>
  <a href='DieselBuilders.html'          class='btn btn-outline-secondary mr-2 mb-2'>&#9965; Builders</a>
  <a href='DieselMaxSpeeds.html'         class='btn btn-outline-secondary mr-2 mb-2'>&#128650; Max Speed</a>
  <a href='DieselPowers.html'            class='btn btn-outline-secondary mr-2 mb-2'>&#9889; Power</a>
</div>";
    }
}