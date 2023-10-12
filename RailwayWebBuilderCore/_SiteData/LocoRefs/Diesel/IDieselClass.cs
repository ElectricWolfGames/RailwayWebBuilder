﻿using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public interface IDieselClass
    {
        string ClassName { get; set; }
        List<ILocoDetails> LocoNumbers { get; set; }
        string Paragraph1 { get; set; }
        string Paragraph2 { get; set; }
        string Paragraph3 { get; set; }

        List<string> GetAllImages(string tag);

        void PreviewLocos(HTMLBuilder pageBuilder, WebPage webPage);
    }
}