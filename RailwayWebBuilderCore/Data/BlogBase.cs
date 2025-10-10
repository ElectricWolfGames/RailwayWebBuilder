using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore.Data;

public abstract class BlogBase : IBlog
{
    public string Carousel { get; set; }
    public string CarouselText { get; set; }
    public DateTime Date { get; set; }
    public bool Featured { get; set; }
    public string KeyImage { get; set; }
    public string Link { get; set; }
    public IModelEvent ModelEvent { get; set; }
    public string Name { get; set; }
    public string Paragraph { get; set; }

    public string GetCarouselKeyImagePath()
    {
        return $"Others\\images\\{Carousel}";
    }

    public string GetKeyImagePath()
    {
        string keyImage = KeyImage;
        if (string.IsNullOrWhiteSpace(KeyImage))
        {
            if (!string.IsNullOrWhiteSpace(ModelEvent?.ImagePreview))
            {
                keyImage = $"{Constants.ModelEvents}\\{ModelEvent.ImageFolder}\\images\\{ModelEvent.ImagePreview}";
            }
        }

        return keyImage;
    }
}