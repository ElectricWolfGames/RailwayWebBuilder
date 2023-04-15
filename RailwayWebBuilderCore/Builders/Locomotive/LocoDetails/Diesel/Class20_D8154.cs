using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class20_D8154 : LocomotiveDetailsBase
    {
        public Class20_D8154()
        {
            Title = "D8154, Class 20, Bo-Bo";
            Class = "Class 20";

            Paragraph1 = "The British Rail (BR) Class 20, otherwise known as an English Electric Type 1, is a class of diesel-electric locomotive. In total, 228 locomotives in the class were built by English Electric between 1957 and 1968, the large number being in part because of the failure of other early designs in the same power range to provide reliable locomotives.";
            Paragraph2 = "The locomotives were originally numbered D8000–D8199 and D8300–D8327. They are known by railway enthusiasts as 'Choppers'";
            PageTitle = "D8154";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class20-D8154\";
            ExportImagePath = Constants.LocoRef + "images\\D8154\\";
            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "D8154,Class20 ";

            Keywords.Add("British Rail");
            Keywords.Add("English Electric Type 1");
            Keywords.Add("Choppers");
            Keywords.Add("Class 20");
        }
    }
}