using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class SheffieldVictoria : LayoutBase
    {
        public SheffieldVictoria()
        {
            Name = LayoutNamesEnums.SheffieldVictoria;
            Gauge = Gauges.N_Gauge;
            Owner = "Graham Hartley";
            Description = "The station was engineered by John Fowler of Forth Railway bridge fame and was opened in 1851\r\nreplacing an earlier station in Sheffield. Fowler's design included a 40 ft high viaduct over the Wicker\r\nwith an impressive arched bridge which remains today. The station roof was originally a large glass\r\noverall roof, which was dismantled after WW2 bomb damage rendered it unsafe. After the war\r\n\r\nthe line was electrified (1500 v DC) and had through services onto the Great Central extension to\r\nLondon with named expresses Eg. The Master Cutler, The South Yorkshireman. The Beeching\r\n\r\nreport condemned the GC and Sheffield Victoria into history closing in 1970 to passengers.";
        }
    }
}