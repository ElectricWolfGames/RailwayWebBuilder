using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("CoachesList.html")]
[Navigation(NavigationTypes.Main, 2)]
public class CoachesList : PageDetails
{
    public CoachesList()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Locomotive Photo Reference Collection";
        MenuTitle = "CoachesList";
        DontShowNavigation = true;

        Keywords.AddRange(LocoRef.GetKeywords(StockTypes.Coach));
    }

    public override void CreatePage()
    {
        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-12'>");

        WebPage.Append("<div class='container mt-12'>");

        WebPage.Append("</br>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));
        WebPage.Append(LocoRef.CreatelItemList(WebPage, StockTypes.Coach));

        WebPage.Append("</div>");

        WebPage.Append("</div>");

        WebPage.EndBody();
        WebPage.Output();
    }
}