using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass222 : DieselClassBase
    {
        // TODO: CLass 222 missing paragraphs, Image not tag with number
        public DieselClass222()
        {
            ClassName = "Class 222";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("222000"),
                new LocoDetails("222001"),
                new LocoDetails("222002"),
                new LocoDetails("222003"),
                new LocoDetails("222004"),
                new LocoDetails("222005"),
                new LocoDetails("222006"),
                new LocoDetails("222007"),
                new LocoDetails("222008"),
                new LocoDetails("222009"),
                new LocoDetails("222010"),
                new LocoDetails("222011"),
                new LocoDetails("222012"),
                new LocoDetails("222013"),
                new LocoDetails("222014"),
                });
        }
    }
}