using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
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

        WebPage.Append(CreateGallery());
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
        sb.AppendLine("<div class='row'>");

        if (!string.IsNullOrEmpty(cb.Builder))
        {
            sb.AppendLine("<div class='col-sm-6 col-md-3 mb-2'>");
            sb.AppendLine("<small class='text-muted d-block'>Builder</small>");
            sb.AppendLine($"<span class='font-weight-bold'>{cb.Builder}</span>");
            sb.AppendLine("</div>");
        }
        if (!string.IsNullOrEmpty(cb.BuildDate))
        {
            sb.AppendLine("<div class='col-sm-6 col-md-3 mb-2'>");
            sb.AppendLine("<small class='text-muted d-block'>Built</small>");
            sb.AppendLine($"<span class='font-weight-bold'>{cb.BuildDate}</span>");
            sb.AppendLine("</div>");
        }
        if (cb.TotalProduced > 0)
        {
            sb.AppendLine("<div class='col-sm-6 col-md-3 mb-2'>");
            sb.AppendLine("<small class='text-muted d-block'>Total Produced</small>");
            sb.AppendLine($"<span class='font-weight-bold'>{cb.TotalProduced}</span>");
            sb.AppendLine("</div>");
        }
        if (!string.IsNullOrEmpty(cb.PowerType))
        {
            sb.AppendLine("<div class='col-sm-6 col-md-3 mb-2'>");
            sb.AppendLine("<small class='text-muted d-block'>Power Type</small>");
            sb.AppendLine($"<span class='font-weight-bold'>{cb.PowerType}</span>");
            sb.AppendLine("</div>");
        }

        sb.AppendLine("</div>");

        if (!string.IsNullOrEmpty(cb.WikiLink))
        {
            sb.AppendLine($"<a href='{cb.WikiLink}' class='btn btn-sm btn-outline-secondary mt-2' target='_blank'>Wikipedia &rarr;</a>");
        }

        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        return sb.ToString();
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