using eWolfBootstrap.Builders;
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
        int Order { get; set; }
        string PageTitle { get; set; }
        string Paragraph1 { get; set; }
        string Paragraph2 { get; set; }
        string Paragraph3 { get; set; }
        string RawImagePath { get; }
        string Title { get; }

        void AddImagestoHeaderPage(PageBuilder pageBuilder, int number, string seeMore);

        void Build();
    }
}