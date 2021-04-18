using System.Text;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILocomotiveRefPage
    {
        bool Active { get; set; }
        StringBuilder Details { get; }
        string ExportImagePath { get; }
        string PageTitle { get; set; }
        string RawImagePath { get; }
        string Title { get; }

        void Build();
    }
}