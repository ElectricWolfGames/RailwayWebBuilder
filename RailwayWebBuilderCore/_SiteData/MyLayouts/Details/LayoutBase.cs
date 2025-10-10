using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details;

public abstract class LayoutBase : ILayoutPagesDetails
{
    public bool Active { get; set; } = true;
    public StringBuilder Details { get; set; }
    public int EpisodeNumber { get; set; }
    public string ExportImagePath { get; set; }
    public string RawImagePath { get; set; }
    public string Title { get; set; }
    public DateTime When { get; set; }
    public string YouTubeLink { get; set; }

    protected void InitDatedPaths()
    {
        Details = new StringBuilder();
        RawImagePath = Constants.RawDataPath + @$"MyLayout\{When.ToString("yyyy-MM-dd")} {EpisodeNumber}\";
        ExportImagePath = Constants.FullMyLayouts + $"images\\{When.ToString("yyyyMMdd")}\\";
    }
}