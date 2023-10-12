using RailwayWebBuilderCore._SiteData.LocoRefs.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class42_D821 : Class42Base
    {
        public Class42_D821()
        {
            Title = "D821, Class 42, Warship, GreyHound";

            PageTitle = "D821";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class42_D821\";
            ExportImagePath = Constants.LocoRef + "images\\D821\\";

            FindTags = "D821";

            Keywords.Add(Title);
            Keywords.Add(PageTitle);
        }
    }
}