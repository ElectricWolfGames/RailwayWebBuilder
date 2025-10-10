using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Coaches;

public class CoachesTestCar2 : CoachesClassBase
{
    public CoachesTestCar2()
    {
        ClassName = "Test Car 2 (ex-BSK)";
        StockType = StockTypes.Coach;

        Paragraph1 = "TOPS QXX, Wolverton 1962";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("ADB975397"),
            });
    }
}