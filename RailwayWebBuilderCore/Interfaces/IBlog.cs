using System;

namespace RailwayWebBuilder.Interfaces
{
    public interface IBlog
    {
        string Carousel { get; set; }
        string CarouselText { get; set; }
        DateTime Date { get; set; }
        bool Featured { get; set; }
        string KeyImage { get; set; }
        string Link { get; set; }
        IModelEvent ModelEvent { get; set; }
        string Name { get; set; }
        string Paragraph { get; set; }

        string GetCarouselKeyImagePath();

        string GetKeyImagePath();
    }
}
