using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class37_D6700 : LocomotiveDetailsBase
    {
        public Class37_D6700()
        {
            Title = "D6700, Class 37";
            PageTitle = "D6700";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class37-D6700\";
            ExportImagePath = Constants.LocoRef + "images\\D6700\\";
            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "D6700,Class37";

            Paragraph1 = "The British Rail Class 37 is a diesel-electric locomotive. Also known as the English Electric Type 3," +
                "the class was ordered as part of the British Rail modernisation plan. They were numbered in two series, " +
                "D6600–D6608 and D6700–D6999";
            Paragraph2 = "The Class 37 became a familiar sight on many parts of the British Rail network, " +
                "in particular forming the main motive power for InterCity services in East Anglia and within Scotland. " +
                "They also performed well on secondary and inter-regional services for many years. " +
                "The Class 37s are known to some railway enthusiasts as 'tractors', a nickname given due to the similarities between the class's engine and a tractor's";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 37");
            Keywords.Add("Class 37");
            Keywords.Add("English Electric Type 3");
            Keywords.Add("tractors");
        }
    }
}