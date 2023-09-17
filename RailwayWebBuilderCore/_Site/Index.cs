using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;

namespace RailwayWebBuilderCore._Site
{
    [PageTitle("index2.html")]
    [Navigation(NavigationTypes.Main, 0)]
    public class Index : PageDetails
    {
        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Home";
            MenuTitle = "Home";
            DontBuildPage = true;
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main);
            WebPage.StartBody();

            WebPage.EndBody();
            WebPage.Output();
        }
    }
}