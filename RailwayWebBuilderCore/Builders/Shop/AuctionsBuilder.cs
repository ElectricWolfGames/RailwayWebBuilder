using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;

using System.IO;

namespace RailwayWebBuilderCore.Builders.Shop
{
    public class AuctionsBuilder
    {
        public static void Build()
        {
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.Shop);
            string htmlpath = Constants.RootPath + "\\" + Constants.Shop + "\\";

            var sb = new PageBuilder("GCRAuctions.html", htmlpath, new ShopGCRAuctionsHeader(), "../");
            sb.Append(NavBarHelper.NavBar("../"));
            sb.Append("<div class='container mt-4'>");
            sb.Jumbotron("<h2>Friends of The Great Central Mainline: Auctions</h2>", "", 8);

            sb.Append("<h2>Cuneo Picture Auction</h2>");
            string imageName = Constants.RawDataPath + @"\Shop\Images\Cuneo Picture Auction.jpg";

            sb.Append("<div class='col-md-12'>");
            sb.AddImageCenter(htmlpath, htmlpath + "images", imageName);
            sb.Append("</div>");

            sb.Append("</br></br></br></br>");
            sb.Append("<p>Don’t miss this opportunity to own a beautiful piece of railway history. " +
                "This is an exquisite limited edition print by celebrated railway artist Terence Cuneo. " +
                "It depicts LMS Princess Coronation Class No. 46229 Duchess Of Hamilton being coaled. " +
                "What’s more it is signed by the late artist to mark the return to steam of the locomotive in 1989. " +
                "The image of course includes Cuneo’s trademark mouse!</p>");
            sb.Append("</br>");
            sb.Append("<p>Donated to Friends by a member of the fundraising team, the frame is in reasonable condition and the picture isn’t faded at all. "+
                "At 36 inches across and 29 inches tall you’ll need a good sized wall to hang it from but it will definitely be a conversation starter. "+
                "We’re selling the print by auction with every penny going to the Reunification project.</p>");
            sb.Append("</br>");
            sb.Append("<p>Bids should start at £100, please submit your best offer via email to <strong>gcr.friends.auctions@gmail.com</strong></p>");
            sb.Append("<p>or by post to</p>");

            sb.Append("<div class='col-md-10'>");

            sb.Append("<h4>'FoGCML' Cuneo Picture Auction</br>"+
"Lovatt House</br>" +
"3 Wharncliffe Road</br>" +
"Loughborough</br>" +
"LE11 1SL</br>" +"</h4>");
            sb.Append("</div>");

            sb.Append("</br>");
            sb.Append("<p>Please include with your bid, your name, postal address and contact telephone number.</p>");
            sb.Append("<h2>The latests Bid is at £1000!</h2>");
            sb.Append("<p>The best bid received by midday on the 31st of January 2022 will receive the print - with free collection to be arranged at Loughborough Central station or by delivery to a UK address via courier at additional cost.</p>");
            

            sb.Append("<p>We will be showing the print on the friends stand (Loughborough station platform No1) </p>");
            sb.Append("<p>At the <a href='https://www.gcrailway.co.uk/special-events/last-hurrah-of-the-season/'>Last Hurrah</a> on the November 20th & 21st ");
            sb.Append("and The Winter Gala - January 28th, 29th & 30th</p>");
            sb.Append("<p>Thank you for your support.</p>");

            sb.Append("</br>");
            sb.Append("</br>");
            string link = $"<a href='https://www.gcrailway.co.uk/unify/' >here</a>";
            sb.Append($"<p>For more details about Reunification click {link}</p>");

            
            sb.Append("More images can be seen here, Click on one to take a closer look.");
            AddGallrey(sb, Constants.RawDataPath + @"\Shop\CuneoImages", @"D:\Trains\_WebsiteData\Shop\CuneoImages");

            sb.Append("</br>");
            sb.Append("</div>");

            sb.Output();
        }

        private static  void AddGallrey(PageBuilder pageBuilder, string imagePath, string galleryPath)
        {
            Directory.CreateDirectory(imagePath);

            string LocalPath  = Constants.RootPath + Constants.Shop + "\\";
            pageBuilder.AddImages(LocalPath, LocalPath + "images", galleryPath);
        }

    }
}