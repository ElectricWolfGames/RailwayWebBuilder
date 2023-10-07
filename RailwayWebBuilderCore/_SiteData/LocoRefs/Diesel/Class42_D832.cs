using RailwayWebBuilderCore._SiteData.LocoRefs.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class42_D832 : Class42Base
    {
        public Class42_D832()
        {
            Title = "D832, Class 42, Warship, Onslaught";

            PageTitle = "D832";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class42_D832\";
            ExportImagePath = Constants.LocoRef + "images\\D832\\";

            FindTags = "D832";

            Keywords.Add(Title);
            Keywords.Add(PageTitle);
        }
    }
}