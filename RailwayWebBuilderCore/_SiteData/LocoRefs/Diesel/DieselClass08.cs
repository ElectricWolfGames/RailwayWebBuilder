using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass08 : DieselClassBase
    {
        public DieselClass08()
        {
            ClassName = "Class 08";
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Class 08 is a class of diesel-electric shunting locomotive builtby British Railways (BR). " +
"As the standard BR general-purpose diesel shunter, the class became a familiar sight at major stations and freight yards. " +
"Since their introduction in 1952 however, the nature of rail traffic in Britain has changed considerably. " +
"Freight trains are now mostly fixed rakes of wagons, and passenger trains are mostly multiple units, neither requiring the attention of a shunting locomotive. " +
"Consequently, a large proportion of the class has been withdrawn from mainline use and stored, scrapped, exported or sold to industrial or heritage railways.";
            Paragraph2 = "As of 2020, around 100 locomotives remained working on industrial sidings and on the main British network." +
                "On heritage railways, they have become common, appearing on many of the preserved standard-gauge lines in Britain, " +
                "with over 70 preserved including the first one built.";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("08114"),
                new LocoDetails("08220"),
                new LocoDetails("08694"),
                new LocoDetails("08706"),
                new LocoDetails("08784"),
                new LocoDetails("08922"),
                new LocoDetails("13101"),
                new LocoDetails("D3690"),
                new LocoDetails("D4137") });
        }
    }
}