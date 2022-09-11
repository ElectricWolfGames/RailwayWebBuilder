using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class08_D3690 : LocomotiveDetailsBase
    {
        public Class08_D3690()
        {
            Title = "D3690, Class 08, 0-6-0";
            PageTitle = "D3690";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-D3690\";
            ExportImagePath = Constants.LocoRef + "images\\D3690\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Class 08 is a class of diesel-electric shunting locomotive builtby British Railways (BR). " +
                "As the standard BR general-purpose diesel shunter, the class became a familiar sight at major stations and freight yards. " +
                "Since their introduction in 1952 however, the nature of rail traffic in Britain has changed considerably. " +
                "Freight trains are now mostly fixed rakes of wagons, and passenger trains are mostly multiple units, neither requiring the attention of a shunting locomotive. " +
                "Consequently, a large proportion of the class has been withdrawn from mainline use and stored, scrapped, exported or sold to industrial or heritage railways.";
            Paragraph2 = "As of 2020, around 100 locomotives remained working on industrial sidings and on the main British network." +
                "On heritage railways, they have become common, appearing on many of the preserved standard-gauge lines in Britain, with over 70 preserved including the first one built.";

            Keywords.Add("British Rail");
            Keywords.Add("diesel-electric shunting");
            Keywords.Add("diesel shunter");
            Keywords.Add("1952");
        }
    }
}