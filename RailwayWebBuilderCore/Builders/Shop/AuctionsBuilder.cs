using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;

using System.IO;

namespace RailwayWebBuilderCore.Builders.Shop
{

    // shorturl.at/xIN26
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

            Plates(sb);

            /*sb.Append("<h2>Cuneo Picture Auction</h2>");
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
            sb.Append("<p>Donated to Friends by a member of the fundraising team, the frame is in reasonable condition and the picture isn’t faded at all. " +
                "At 36 inches across and 29 inches tall you’ll need a good sized wall to hang it from but it will definitely be a conversation starter. " +
                "We’re selling the print by auction with every penny going to the Reunification project.</p>");
            sb.Append("</br></br>");
            sb.Append("</br>");
            sb.Append("This Auctions has now ended");
            sb.Append("</br></br>");
            sb.Append("With the winning bid by Hugh Penri-Williams for the value of £1000.");
            sb.Append("</br>");
            sb.Append("</br>");
            sb.Append("Another auction will be starting soon.");
            sb.Append("</br></br>");
            sb.Append("</br></br>");
            sb.Append("</br></br>");
            */
            /*sb.Append("<p>Bids should start at £100, please submit your best offer via email to <strong>gcr.friends.auctions@gmail.com</strong></p>");
            sb.Append("<p>or by post to</p>");

            sb.Append("<div class='col-md-10'>");

            sb.Append("<h4>'FoGCML' Cuneo Picture Auction</br>" +
"Lovatt House</br>" +
"3 Wharncliffe Road</br>" +
"Loughborough</br>" +
"LE11 1SL</br>" + "</h4>");
            sb.Append("</div>");

            sb.Append("</br>");
            sb.Append("<p>Please include with your bid, your name, postal address and contact telephone number.</p>");
            sb.Append("<h2>The latests Bid is at £1001!</h2>");
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
            AddGallrey(sb, Constants.RawDataPath + @"\Shop\CuneoImages", Constants.DriveLetter + @"Trains\_WebsiteData\Shop\CuneoImages");

            sb.Append("</br>");*/
            sb.Append("</div>");

            sb.Output();
        }

        private static void Plates(PageBuilder sb)
        {
            sb.Append("<h2>Locomotive shed plate and Locomotive builders plate</h2>");

            string htmlpath = Constants.RootPath + "\\" + Constants.Shop + "\\";

            string imageName = Constants.RawDataPath + @"\Shop\Images\Locomotive shed.jpg";
            string imageName2 = Constants.RawDataPath + @"\Shop\Images\Locomotive builders.jpg";


            sb.Append("<p>Back in October a member of the Friends stand team kindly donated a signed print by famous railway artist Terence Cuneo. " +
                "It was duly auctioned and thanks to a very generous bidder raised one thousand pounds for the Reunification fund.</p>");

            sb.Append("<p>Thanks to another kind donation, now we have two new lots to be auctioned with all proceeds going to the same cause.</p>");

            sb.Append("<p>Since promoting the auction in good faith, the possibility the builders plate may be a replica has been raised with us.</p>");
            sb.Append("<p>Should you wish to see the plates in person, please email below.</p>");

            sb.Append("<h2>Lot A</h2>");
            sb.Append("<p>First is a locomotive shed plate, 36C. We don’t know which locomotive it was removed from, " +
                "but the code relates to Frodingham near Scunthorpe, a sub shed of 36A Doncaster. Bids should start at £150 for this lot.</p>");
            sb.Append("<div class='col-md-8'>");
            sb.AddImageCenter(htmlpath, htmlpath + "images", imageName);
            sb.Append("</div>");
            sb.Append("</br></br>");

            sb.Append("<h2>Lot B</h2>");
            sb.Append("<p>The second is a locomotive builders plate; a distinctive diamond from the North British Locomotive Company. " +
                "Dated 1947, number 26094.This is from London & North Eastern Railway 'B1' class 4-6-0 No 1193, " +
                "subsequently British Railways No 61193, built May 1947, withdrawn September 1962. Bids should also start at £150 for this lot.</p>");

            sb.Append("<div class='col-md-8'>");
            sb.AddImageCenter(htmlpath, htmlpath + "images", imageName2);
            sb.Append("</div>");
            sb.Append("</br></br>");

            sb.Append("<p>The auction will close at the end of 30th June 2022 with the highest bidder(s) notified immediately so the items can be collected. Once again, thank you for your support and good luck bidding.</p>");

            //sb.Append("More images can be seen here, Click on one to take a closer look.");
            //AddGallrey(sb, Constants.RawDataPath + @"\Shop\CuneoImages", Constants.DriveLetter + @"Trains\_WebsiteData\Shop\CuneoImages");

            sb.Append("<p>Please submit your best offer via email to <strong>gcr.friends.auctions@gmail.com</strong></p>");
            sb.Append("<p>or by post to</p>");
            sb.Append("<div class='col-md-10'>");
            sb.Append("<h4>'FoGCML' Locomotive plate Auction</br>" +
                    "Lovatt House</br>" +
                    "3 Wharncliffe Road</br>" +
                    "Loughborough</br>" +
                    "LE11 1SL</br>" + "</h4>");
            sb.Append("</div>");


            sb.Append("</br></br>");

            sb.Append("<p>Please include with your bid, your name, postal address and contact telephone number. And the LOT you are bidding on.</p>");

            sb.Append("<p>We will be showing the plates on the friends stand (Loughborough station platform No1) </p>");
            sb.Append("<p>At the <a href='https://www.gcrailway.co.uk/Railways-At-Work-Gala/'>Railways at Work Gala</a> on the November 19th and 20th March 2022</p>");

            sb.Append("<p>Thank you for your support.</p>");

            sb.Append("</br>");
            sb.Append("</br>");
            string link = $"<a href='https://www.gcrailway.co.uk/unify/' >here</a>";
            sb.Append($"<p>For more details about Reunification click {link}</p>");

            sb.Append("</br></br>");
            sb.Append("</br></br>");

        }



        private static void AddGallrey(PageBuilder pageBuilder, string imagePath, string galleryPath)
{
Directory.CreateDirectory(imagePath);

string LocalPath = Constants.RootPath + Constants.Shop + "\\";
pageBuilder.AddImages(LocalPath, LocalPath + "images", galleryPath);
}

        /*private static string CuneoPictureAuction()
        {
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
        sb.Append("<p>Donated to Friends by a member of the fundraising team, the frame is in reasonable condition and the picture isn’t faded at all. " +
            "At 36 inches across and 29 inches tall you’ll need a good sized wall to hang it from but it will definitely be a conversation starter. " +
            "We’re selling the print by auction with every penny going to the Reunification project.</p>");
        sb.Append("</br></br>");


        sb.Append("<p>Bids should start at £100, please submit your best offer via email to <strong>gcr.friends.auctions@gmail.com</strong></p>");
        sb.Append("<p>or by post to</p>");

        sb.Append("<div class='col-md-10'>");

        sb.Append("<h4>'FoGCML' Cuneo Picture Auction</br>" +
        "Lovatt House</br>" +
        "3 Wharncliffe Road</br>" +
        "Loughborough</br>" +
        "LE11 1SL</br>" + "</h4>");
        sb.Append("</div>");

        sb.Append("</br>");
        sb.Append("<p>Please include with your bid, your name, postal address and contact telephone number.</p>");
        sb.Append("<h2>The latests Bid is at £1001!</h2>");
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
        AddGallrey(sb, Constants.RawDataPath + @"\Shop\CuneoImages", Constants.DriveLetter + @"Trains\_WebsiteData\Shop\CuneoImages");

        sb.Append("</br>");
        sb.Append("</div>");

        }*/
    }
}

/*
 * I suggest the following text for the next auction which I’ll send to George with two pictures as well. 
Karl will you be able to fill in the blank about where the plates can be seen?
And Barry can you fill in the blank about the event where they will be on display?
I hope they are more portable than the painting!

I’ve had a brief scout on line and plates like this have sold for £200 in auction,
so starting at £150 seems fair to me. 

Cheers
Tom




AUCTION SUCCESS AND NEW LOTS TO BID ON!

Back in October a member of the Friends stand team kindly donated a signed print by famous railway artist Terence Cuneo.
It was duly auctioned and thanks to a very generous bidder raised one thousand pounds for the Reunification fund.

Thanks to another kind donation, now we have two new lots to be auctioned with all proceeds going to the same cause.
First is a locomotive shed plate, 36C. We don’t know which locomotive it was removed from, but the code relates to Frodingham near Scunthorpe, a sub shed of 36A Doncaster. 
Bids should start at £150 for this lot.

The second is a locomotive builders plate; a distinctive diamond from the North British Locomotive Company.
Dated 1947, number 26094. This is from London & North Eastern Railway "B1" class 4-6-0 No 1193,
subsequently British Railways No 61193, built May 1947, withdrawn September 1962.
Bids should also start at £150 for this lot.

You see both items and make a bid at this website… XXX and they will be on display at XXX event on the Friends of the Great Central Main Line website. 

The auction will close at the end of 30th June 2022 with the highest bidder(s) notified immediately so the items can be collected. 
Once again, thank you for your support and good luck bidding.
 */