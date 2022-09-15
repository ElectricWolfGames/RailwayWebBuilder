﻿using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails;
using System.Collections.Generic;
using System.Text;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILocomotiveRefPage
    {
        bool Active { get; set; }
        StringBuilder Details { get; }
        string ExportImagePath { get; }
        List<string> Keywords { get; }
        ILocomotiveSpecifications LocomotiveSpecifications { get; }
        int Order { get; set; }
        string PageTitle { get; set; }
        string Paragraph1 { get; set; }
        string Paragraph2 { get; set; }
        string Paragraph3 { get; set; }
        string RawImagePath { get; }
        StockTypes StockType { get; }
        string Title { get; }

        void AddImagestoHeaderPage(PageBuilder pageBuilder, int number, string seeMore);

        void Build();
    }
}