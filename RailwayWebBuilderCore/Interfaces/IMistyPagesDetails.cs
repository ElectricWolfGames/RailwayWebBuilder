using System;
using System.Text;

namespace RailwayWebBuilderCore.Interfaces;

public interface IMistyPagesDetails
{
    bool Active { get; set; }
    StringBuilder Details { get; }
    int EpisodeNumber { get; }
    string ExportImagePath { get; }
    string RawImagePath { get; }
    string Title { get; }
    DateTime When { get; }
    string YouTubeLink { get; }
}