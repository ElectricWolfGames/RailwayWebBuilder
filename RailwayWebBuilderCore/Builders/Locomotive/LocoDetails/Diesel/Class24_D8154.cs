using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class24_D5054 : LocomotiveDetailsBase
    {
        public Class24_D5054() 
        {
            Title = "D5054, Class 24, Bo-Bo";
            Class = "Class 20";

            Paragraph1 = "The British Railways Class 24 diesel locomotives, also known as the Sulzer Type 2, were built from 1958 to 1961. One hundred and fifty-one were built at Derby, Crewe and Darlington, the first twenty of them as part of the British Railways 1955 Modernisation Plan. This class was used as the basis for the development of the Class 25 locomotives.";
            Paragraph2 = "";
            PageTitle = "D5054";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class20-D5054\";
            ExportImagePath = Constants.LocoRef + "images\\D5054\\";
            StockType = StockTypes.Diesel;
            FindTags = "D5054,Class24 ";

            Keywords.Add("Sulzer Type 2");
            Keywords.Add("British Rail");
            Keywords.Add("English Electric Type 1");
            Keywords.Add("Class 24");
        }
    }
}