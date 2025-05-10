using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore.Configuration;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.GCR
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    internal class Auction : PageDetails
    {
        public Auction()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Auction Terence Cuneo";
            MenuTitle = "Auction";
            DontShowNavigation = true;
        }

        public static string CreateHero(PageDetails pageDetails)
        {
            HTMLBuilder pageBuilder = new();
            pageBuilder.Jumbotron(pageDetails.DisplayTitle, string.Empty);
            return pageBuilder.Output();
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");
            WebPage.Append("</br>");
            WebPage.Append(LocoRef.CreateHero(this));

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-{8}'>");
            WebPage.Append(CreateDescription());
            WebPage.Append("</div>");
            WebPage.Append("</div>");
            WebPage.Append(CreateGallery());

            WebPage.Append(CreateReunification());

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string CreateGallery()
        {
            var pageBuilder = new HTMLBuilder();
            string htmlpath = Constants._aRootPath + "GCR\\";
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("<h2>Gallery</h2>");
            string galleryPath = Constants.RawDataPath + @"GCR\Auction\";
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, galleryPath);
            return pageBuilder.Output();
        }

        private string CreateDescription()
        {
            HTMLBuilder pageBuilder = new();

            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("Back in 2021, the Friends of the Great Central Main Line auctioned the Duchess of Hamilton Terence Cuneo's limited edition print, which raised £1000 for the reunification project.");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.Text("We are back to try that same again with two painting");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.TextBoldText("", "Terence Cuneo's", " limited edition prints 'Flying Scotsman.' 820/850");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.TextBoldText("", "David Shepherd’s", " famous painting ’Nine Elms, The Last Hours’ depicts a BR Standard 5 and a West Country Class loco on a rundown shed, speaking powerfully to a poignant moment in history, which happily was far from steam’s last stand");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.Text($"<br/><br/>");

            pageBuilder.Image("Full.jpg", 100);
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.Image("Nine-Elms-The-Last-Hours.jpg", 100);

            pageBuilder.Text($"<br/><br/>");
            pageBuilder.TextBold("If you would like to place a bid email ", "gcr.friends.auctions@gmail.com");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.Text("Please provide which painting you would like to bid on and how much with your phone number and address. All details will be deleted upon the completion of the auction.");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.Text("The closing date is Easter Monday 21 April. At 12:00 noon, with collection to be arranged from Loughborough after the auction has closed. ");
            pageBuilder.Text($"<br/><br/>");
            pageBuilder.Text($"<br/><br/>");

            return pageBuilder.Output();
        }

        private string CreateReunification()
        {
            HTMLBuilder pageBuilder = new();

            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("For more infomation on the reunification project please visit ");
            pageBuilder.Text($"<a href='https://www.gcrailway.co.uk/unify/'>www.gcrailway.co.uk/unify/</a>");

            pageBuilder.Text($"<br/><br/>");

            return pageBuilder.Output();
        }

        /*I herewith submit a bid of GBP / £ 1,000.00 (one thousand pounds) for the Terence Cuneo limited edition print (No820 of 850) of 46229 Duchess of Hamilton at a coaling stage.

As the closing date is far away, how can I stay informed of whether my bid is still the highest, please?

Although I am located in the south of France, I have a UK resident family member who could collect the item in the case of winning.

Bon week-end, Hugh Penri-Williams.*/
    }
}