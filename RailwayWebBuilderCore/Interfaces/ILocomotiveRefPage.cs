using System.Text;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILocomotiveRefPage
    {
        bool Active { get; set; }
        StringBuilder Details { get; }
        string ExportImagePath { get; }
        string PageTitle { get; set; }
        string Paragraph1 { get; set; }
        string Paragraph2 { get; set; }
        string Paragraph3 { get; set; }
        string RawImagePath { get; }
        string Title { get; }
        int Order { get; set; }

        void Build();
    }
}