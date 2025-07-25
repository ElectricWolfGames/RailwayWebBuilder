﻿using RailwayWebBuilderCore.Data;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface IModelPageDetails
    {
        string CreateLayoutFolders { get; set; }
        string Descrption { get; set; }

        string EventDates { get; set; }

        string ImageFolder { get; set; }
        string ImagePreview { get; set; }
        string ImagesPath { get; set; }
        List<string> ImagesToExclude { get; set; }
        List<LayoutDetails> Layouts { get; set; }
        ILocations Location { get; set; }
        string Name { get; set; }
        DateTime TripDate { get; set; }
        string YouTubeLink { get; set; }
    }
}