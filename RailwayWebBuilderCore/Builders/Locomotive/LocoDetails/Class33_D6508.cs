using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class33_D6508 : LocomotiveDetailsBase
    {
        public Class33_D6508()
        {
            Title = "D6508, Class 33";
            PageTitle = "D6508";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class33-D6508\";
            ExportImagePath = Constants.LocoRef + "images\\D6508\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Class 33, also known as the BRCW Type 3 or Crompton, is a class of Bo-Bo diesel-electric locomotives, ordered in 1957 and built for the Southern Region of British Railways between 1960 and 1962.";
            Paragraph2 = "They were produced as a more powerful Type 3 (1,550 bhp) development of the 1,160 bhp Type 2 Class 26. This was achieved, quite simply, by removing the steam heating boiler and fitting a larger 8 cylinder version of the previous 6 cylinder engine. This was possible because of the traffic requirements of the Southern Region: locomotive-hauled passenger traffic depended on seasonal tourist traffic and was heavier in the summer, when carriage heating was not needed. In the winter, their expected use was to be for freight. Thus, they became the most powerful BR Bo-Bo diesel locomotive.[1] The perennially unreliable steam heating boiler could also be avoided.";
            Paragraph2 = "A total of 98 were built by the Birmingham Railway Carriage and Wagon Company (BRCW) and they were known as 'Cromptons' after the Crompton Parkinson electrical equipment installed in them.[2] Like their lower-powered BRCW sisters, the Class 26 and Class 27 locomotives, their bodywork and cab ends were of all steel construction. They were very similar in appearance to Class 26 locos, but carried Southern Region two-digit headcode blinds between the cab windows.";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 33");
            Keywords.Add("BRCW Type 3");
            Keywords.Add("Crompton");
            Keywords.Add("Class 33");
        }
    }
}