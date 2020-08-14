using RailwayWebBuilder.Headers;
using RailwayWebBuilder.Interfaces;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public abstract class ModelEventPageDetails : HeaderBase, IModelEvent
    {
        public string Descrption { get; set; }
        public string EventAddress { get; set; }
        public string EventDates { get; set; }
        public LatitudeLongitude EventLocation { get; set; }
        public string ImageFolder { get; set; }
        public string ImagePreview { get; set; }
        public string ImagesPath { get; set; }
        public List<string> ImagesToExclude { get; set; }
        public List<string> Keywords { get; set; } = new List<string>();
        public List<LayoutDetails> Layouts { get; set; } = new List<LayoutDetails>();
        public string MetaDetails { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime TripDate { get; set; }
        public string YouTubeLink { get; set; }

        public static IEnumerable<string> ModelEventKeywords()
        {
            return new string[] { "Model trains", "Model railway", "Exhibition", "Model", "Train show" };
        }

        public void CopyLayoutsToKeywords()
        {
            foreach (var layout in Layouts)
            {
                Keywords.Add(layout.Name);
            }
        }

        public void Fix()
        {
            ImagePreview = ImagePreview.Replace(".jpg", ".JPG");
        }
    }
}
