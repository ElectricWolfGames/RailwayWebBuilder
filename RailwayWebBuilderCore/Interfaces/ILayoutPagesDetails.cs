using System;
using System.Text;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILayoutPagesDetails
    {
        DateTime When { get; }
        string RawImagePath { get; }
        string ExportImagePath { get; }
        string YouTubeLink { get; }

        string Title { get; }
        StringBuilder Details { get; }
    }
}