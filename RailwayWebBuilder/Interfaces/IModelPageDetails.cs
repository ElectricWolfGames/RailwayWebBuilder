using RailwayWebBuilder.Data;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilder.Interfaces
{
    public interface IModelPageDetails
    {
        string Name { get; set; }

        string Descrption { get; set; }

        string ImagesPath { get; set; }

        List<string> ImagesToExclude { get; set; }

        DateTime TripDate { get; set; }

        string ImageFolder { get; set; }

        string EventDates { get; set; }

        string EventAddress { get; set; }

        string YouTubeLink { get; set; }

        string ImagePreview { get; set; }

        List<LayoutDetails> Layouts { get; set; }
    }
}
