using RailwayWebBuilder.Data;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilder.Interfaces
{
    public interface IModelPageDetails
    {
        string Descrption { get; set; }
        string EventAddress { get; set; }
        string EventDates { get; set; }
        LatitudeLongitude EventLocation { get; set; }
        string ImageFolder { get; set; }
        string ImagePreview { get; set; }
        string ImagesPath { get; set; }
        List<string> ImagesToExclude { get; set; }
        List<LayoutDetails> Layouts { get; set; }
        string Name { get; set; }
        DateTime TripDate { get; set; }
        string YouTubeLink { get; set; }
    }
}
