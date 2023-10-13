using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using RailwayWebBuilderCore.Enums;
using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public interface IDieselClass
    {
        StockTypes StockType { get; set; } 
        string ClassName { get; set; }
        List<string> Keywords { get; }
        List<ILocoDetails> LocoNumbers { get; set; }
        string Paragraph1 { get; set; }
        string Paragraph2 { get; set; }
        string Paragraph3 { get; set; }

        List<string> GetAllImages(string tag);

        void PreviewLocos(HTMLBuilder pageBuilder, WebPage webPage);
    }

    public interface ISteamClass
    {
        string ClassName { get; set; }
        List<string> Keywords { get; }
        List<ILocoDetails> LocoNumbers { get; set; }
        string Paragraph1 { get; set; }
        string Paragraph2 { get; set; }
        string Paragraph3 { get; set; }

        List<string> GetAllImages(string tag);

        void PreviewLocos(HTMLBuilder pageBuilder, WebPage webPage);
    }
}