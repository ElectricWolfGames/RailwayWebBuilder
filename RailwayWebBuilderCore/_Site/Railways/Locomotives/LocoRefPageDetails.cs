using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore._SiteData.LocoRefs;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Helpers;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("Place holder Page")]
[Navigation(NavigationTypes.Main, 2)]
[AddGallery()]
public class LocoRefPageDetails : PageDetails
{
    public LocoRefPageDetails()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Loco ref";
        MenuTitle = "Loco Ref";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public IDieselClass DieselClassBase { get; set; }
    public string GalleryPath { get; set; }
    public string LocoNumber { get; set; }
    public string NextLocoNumber { get; set; }
    public string PrevLocoNumber { get; set; }

    public override void CreatePage()
    {
        DisplayTitle = $"{DieselClassBase.ClassName}: {LocoNumber}";
        MenuTitle = $"{DieselClassBase.ClassName}: {LocoNumber}";

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");

        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, "../"));

        WebPage.Append($"<h2>{DieselClassBase.ClassName}: {LocoNumber}</h2>");
        WebPage.Append(CreateClassInfoPanel());
        WebPage.Append($"<p>{DieselClassBase.Paragraph1}</p>");
        WebPage.Append($"<p>{DieselClassBase.Paragraph2}</p>");
        WebPage.Append(GoogleAdsHelper.AdsBanner);

        WebPage.Append(CreateGallery());
        WebPage.Append(GoogleAdsHelper.AddSideAd());
        WebPage.Append(CreateLocoNavigation());

        WebPage.HtmlPath = "Locomotives\\Ref";
        WebPage.HtmlTitle = $"{LocoNumber}.html";

        WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
        WebPage.SetDontBuild = false;

        WebPage.Append("</div>");
        WebPage.Append(HTMLRailHelper.Modal());
        WebPage.Append("<script src='../../Scripts/script.js'></script>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private string CreateLocoNavigation()
    {
        var sb = new StringBuilder();
        sb.AppendLine("<div class='d-flex justify-content-between mt-4 mb-2'>");

        if (!string.IsNullOrEmpty(PrevLocoNumber))
            sb.AppendLine($"<a href='{PrevLocoNumber}.html' class='btn btn-outline-secondary'>&larr; {PrevLocoNumber}</a>");
        else
            sb.AppendLine("<span></span>");

        if (!string.IsNullOrEmpty(NextLocoNumber))
            sb.AppendLine($"<a href='{NextLocoNumber}.html' class='btn btn-outline-secondary'>{NextLocoNumber} &rarr;</a>");
        else
            sb.AppendLine("<span></span>");

        sb.AppendLine("</div>");
        return sb.ToString();
    }

    private string CreateClassInfoPanel()
    {
        if (DieselClassBase is not ClassBase cb)
            return string.Empty;

        var sb = new StringBuilder();
        sb.AppendLine("<div class='card bg-light mb-4'>");
        sb.AppendLine("<div class='card-body'>");

        // --- Base facts row (all loco types) ---
        sb.AppendLine("<div class='row'>");
        AppendSpecTile(sb, "Builder", cb.Builder);
        AppendSpecTile(sb, "Built", cb.BuildDate);
        if (cb.TotalProduced > 0)
        {
            sb.AppendLine("<div class='col-sm-6 col-md-3 mb-2'>");
            sb.AppendLine("<small class='text-muted d-block'>Total Produced</small>");
            sb.AppendLine($"<span class='font-weight-bold'>{cb.TotalProduced}</span>");
            sb.AppendLine("</div>");
        }
        AppendSpecTile(sb, "Power Type", cb.PowerType);
        sb.AppendLine("</div>");

        // --- Steam-specific specs ---
        if (DieselClassBase is SteamClassBase sc)
        {
            bool hasSpecs = !string.IsNullOrEmpty(sc.Designer)
                || !string.IsNullOrEmpty(sc.WhyteNotation)
                || !string.IsNullOrEmpty(sc.Cylinders)
                || !string.IsNullOrEmpty(sc.BoilerPressure)
                || !string.IsNullOrEmpty(sc.MaxSpeed)
                || !string.IsNullOrEmpty(sc.TractiveEffort)
                || !string.IsNullOrEmpty(sc.DriverWheelDia)
                || !string.IsNullOrEmpty(sc.LeadingWheelDia)
                || !string.IsNullOrEmpty(sc.TrailingWheelDia)
                || !string.IsNullOrEmpty(sc.LocoWeight)
                || !string.IsNullOrEmpty(sc.TenderWeight)
                || !string.IsNullOrEmpty(sc.Length);

            if (hasSpecs)
            {
                sb.AppendLine("<hr class='my-2'/>");
                sb.AppendLine("<div class='row'>");
                AppendSpecTile(sb, "Designer", sc.Designer);
                AppendSpecTile(sb, "Wheel Arrangement", sc.WhyteNotation);
                AppendSpecTile(sb, "Cylinders", sc.Cylinders);
                AppendSpecTile(sb, "Boiler Pressure", sc.BoilerPressure);
                AppendSpecTile(sb, "Max Speed", sc.MaxSpeed);
                AppendSpecTile(sb, "Tractive Effort", sc.TractiveEffort);
                sb.AppendLine("</div>");
                sb.AppendLine("<div class='row'>");
                AppendSpecTile(sb, "Driver Wheel Dia.", sc.DriverWheelDia);
                AppendSpecTile(sb, "Leading Wheel Dia.", sc.LeadingWheelDia);
                AppendSpecTile(sb, "Trailing Wheel Dia.", sc.TrailingWheelDia);
                AppendSpecTile(sb, "Length", sc.Length);
                AppendSpecTile(sb, "Loco Weight", sc.LocoWeight);
                AppendSpecTile(sb, "Tender Weight", sc.TenderWeight);
                sb.AppendLine("</div>");
            }
        }

        if (!string.IsNullOrEmpty(cb.WikiLink))
        {
            sb.AppendLine($"<a href='{cb.WikiLink}' class='btn btn-sm btn-outline-secondary mt-2' target='_blank'>Wikipedia &rarr;</a>");
        }

        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        return sb.ToString();
    }

    private static void AppendSpecTile(StringBuilder sb, string label, string value)
    {
        if (string.IsNullOrEmpty(value))
            return;
        sb.AppendLine("<div class='col-sm-6 col-md-3 mb-2'>");
        sb.AppendLine($"<small class='text-muted d-block'>{label}</small>");
        sb.AppendLine($"<span class='font-weight-bold'>{value}</span>");
        sb.AppendLine("</div>");
    }

    private string CreateGallery()
    {
        var pageBuilder = new HTMLBuilder();
        string htmlpath = Constants._aRootPath + @"\\Locomotives\\Ref\\";
        string imagePath = $"{htmlpath}images";

        Directory.CreateDirectory(imagePath);
        pageBuilder.Text($"<hr/>");
        pageBuilder.Text("<h2>Gallery</h2>");
        pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, GalleryPath);
        return pageBuilder.Output();
    }
}