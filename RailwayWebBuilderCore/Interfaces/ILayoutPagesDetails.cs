using System;
using System.Text;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILayoutPagesDetails
    {
        bool Active { get; set; }
        StringBuilder Details { get; }
        string ExportImagePath { get; }
        string RawImagePath { get; }
        string Title { get; }
        DateTime When { get; }
        string YouTubeLink { get; }
    }
}